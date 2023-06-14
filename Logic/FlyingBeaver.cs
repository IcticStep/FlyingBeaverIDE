using System.Timers;
using DataStorage;
using DataStorage.Accentuations.Api;
using Domain.Analysing.Results;
using Domain.Main;
using Domain.Main.Rhythmics;
using FlyingBeaverIDE.Logic.Api;
using FlyingBeaverIDE.Logic.Services;
using PoemTokenization.Tokenizers;
using RhythmAnalysing;
using RhythmAnalysing.Analyzers;
using Timer = System.Timers.Timer;

namespace FlyingBeaverIDE.Logic;

public class FlyingBeaver : IDataReceiver<Poem>
{
    public FlyingBeaver(DataBaseCredentials dataBaseCredentials, string? localAccentuationsSavePath)
    {
        _poemSaver = new PoemSaver(this);
        _poemTokenizer = new();
        _accentuationsRepository = AccentuationRepositoryProvider.Create(
            dataBaseCredentials, localAccentuationsSavePath);
        _rhythmAnalyzer = new(new SchemeAutoAnalyzer(_accentuationsRepository));
        InitTimer();
    }

    private void InitTimer()
    {
        _analyzeTimer = new Timer(AnalyzeInterval);
        _analyzeTimer.AutoReset = true;
        _analyzeTimer.Elapsed += TryAnalyzePoem;
        _analyzeTimer.Start();
    }

    public readonly double MinAnalyzeInterval = 300;
    public readonly double MaxAnalyzeInterval = 10000;

    public Rhythm[] AvailableRhythms =>
        RhythmBank.TrocheeGroup.Concat(
            RhythmBank.IambGroup).ToArray();
    
    private Timer _analyzeTimer;
    private readonly PoemSaver _poemSaver;
    private readonly PoemTokenizer _poemTokenizer;
    private readonly RhythmAnalyzer _rhythmAnalyzer;
    private readonly IAccentuationsRepository _accentuationsRepository;
    
    private Poem _poem = new("", RhythmBank.Trochee2);
    private double _analyzeInterval = 1500;
    private int _lastAnalyzedHash = string.Empty.GetHashCode();
    private bool _analyzeIsBusy;

    private Poem Poem
    {
        get => (Poem)_poem.Clone();
        set => _poem = value;
    }

    public string PoemText
    {
        get => _poem.Text;
        set
        {
            if (Poem.Text.GetHashCode() == value.GetHashCode())
                return;

            Poem = new Poem(value, Poem.Rhythm);
            OnDataReceived?.Invoke(Poem);
        }
    }

    public Rhythm CurrentRhythm
    {
        get => _poem.Rhythm;
        set => _poem.Rhythm = value;
    }

    public double AnalyzeInterval
    {
        get => _analyzeInterval;
        set
        {
            if(value < MinAnalyzeInterval || value > MaxAnalyzeInterval)
                throw new ArgumentOutOfRangeException(nameof(AnalyzeInterval));
            _analyzeInterval = value;
        }
    }

    public bool HasSavedPath => _poemSaver.HasSavedPath;

    public bool AllChangesSaved => _poemSaver.AllChangesSaved;

    public event Action<Poem>? OnDataReceived;
    public event Action<RhythmResult>? OnRhythmResult;

    public void LoadFromFile(string? path) =>
        Poem = _poemSaver.LoadFromFile(path) ?? Poem;

    public void SavePoemToFile(string? path = default!) =>
        _poemSaver.SavePoemToFile(_poem, path);

    private void TryAnalyzePoem(object? sender, ElapsedEventArgs elapsedEventArgs)
    {
        if(_analyzeIsBusy)
            return;

        _analyzeIsBusy = true;
        var currentHash = Poem.GetHashCode();
        if (currentHash == _lastAnalyzedHash)
        {
            _analyzeIsBusy = false;
            return;
        }

        _lastAnalyzedHash = currentHash;
        
        Console.WriteLine("Processing");
        Task.Run(AnalyzePoem());
    }

    private Func<Task?> AnalyzePoem()
    {
        return async () =>
        {
            if (string.IsNullOrWhiteSpace(Poem.Text))
            {
                _analyzeIsBusy = false;
                return;
            }
            var cloned = (Poem)Poem.Clone();

            var poemToken = await _poemTokenizer.TokenizeAsync(cloned);
            if (!poemToken.AllSyllables.Any())
            {
                _analyzeIsBusy = false;
                return;
            }

            var rhythmResult = await _rhythmAnalyzer.AnalyzeAsync(poemToken);
            OnRhythmResult?.Invoke(rhythmResult);
            _analyzeIsBusy = false;
        };
    }
}