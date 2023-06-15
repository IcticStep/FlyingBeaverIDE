using System.Timers;
using DataStorage;
using DataStorage.Accentuations;
using DataStorage.Accentuations.Api;
using Domain.Analysing.Results;
using Domain.Main;
using Domain.Main.Rhythmics;
using FlyingBeaverIDE.Logic.Api;
using FlyingBeaverIDE.Logic.Services;
using PoemTokenization.Tokenizers;
using RhymeAnalaysing;
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
        _rhymeAnalyzer = new();
        InitTimer();
    }

    private void InitTimer()
    {
        _analyzeTimer = new Timer(AnalyzeInterval);
        _analyzeTimer.AutoReset = true;
        _analyzeTimer.Elapsed += TryAnalyzePoem;
        _analyzeTimer.Elapsed += LogTimer;
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
    private readonly RhymeAnalyzer _rhymeAnalyzer;
    private readonly IAccentuationsRepository _accentuationsRepository;
    
    private Poem _poem = new("", RhythmBank.Trochee2);
    private int _analyzeInterval = 1500;
    private int _lastAnalyzedHash = string.Empty.GetHashCode();
    private bool _analyzeIsBusy;
    private Analyzer _analyzer = Analyzer.None;

    public Analyzer Analyzer
    {
        get => _analyzer;
        set
        {
            _analyzer = value;
            ForceReanalyze();
        }
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

    public int AnalyzeInterval
    {
        get => _analyzeInterval;
        set
        {
            if(value < MinAnalyzeInterval || value > MaxAnalyzeInterval)
                throw new ArgumentOutOfRangeException(nameof(AnalyzeInterval));
            _analyzeInterval = value;
            DeleteTimer();
            InitTimer();
        }
    }

    private void DeleteTimer()
    {
        _analyzeTimer.Stop();
        _analyzeTimer.Dispose();
    }

    public bool HasSavedPath => _poemSaver.HasSavedPath;

    public bool AllChangesSaved => _poemSaver.AllChangesSaved;

    public IAccentuationsRepository LocalAccentuationsDictionary => 
        AccentuationRepositoryProvider.Local!;

    private Poem Poem
    {
        get => (Poem)_poem.Clone();
        set => _poem = value;
    }

    public event Action<Poem>? OnDataReceived;
    public event Action<AnalyzeResult>? OnAnalyzeCompleted;
    public event Action<Rhythm> OnRhythmLoaded;

    public void ForceReanalyze() =>
        _lastAnalyzedHash = default;

    public void LoadFromFile(string? path)
    {
        Poem = _poemSaver.LoadFromFile(path) ?? Poem;
        OnRhythmLoaded?.Invoke(Poem.Rhythm);
    }

    public void SavePoemToFile(string? path = default!) =>
        _poemSaver.SavePoemToFile(_poem, path);
    
    private void LogTimer(object? sender, ElapsedEventArgs e) => 
        Console.WriteLine("Timer ticked.");
    
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

        switch (Analyzer)
        {
            case Analyzer.Rhythm:
                Task.Run(AnalyzePoemRhythmic());
                break;
            case Analyzer.Rhyme:
                Task.Run(AnalyzePoemRhyme());
                break;
            default:
                _analyzeIsBusy = false;
                break;
        }
    }

    private Func<Task?> AnalyzePoemRhythmic()
    {
        return async () =>
        {
            if (string.IsNullOrWhiteSpace(Poem.Text))
            {
                _analyzeIsBusy = false;
                return;
            }

            if (Poem.Rhythm is null)
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
            _analyzeIsBusy = false;
            OnAnalyzeCompleted?.Invoke(new(rhythmResult));
        };
    }
    
    private Func<Task?> AnalyzePoemRhyme()
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

            var rhythmResult = await _rhymeAnalyzer.AnalyzeAsync(poemToken);
            _analyzeIsBusy = false;
            OnAnalyzeCompleted?.Invoke(new(rhythmResult));
        };
    }
}