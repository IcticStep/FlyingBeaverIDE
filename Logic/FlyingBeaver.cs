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

namespace FlyingBeaverIDE.Logic;

public class FlyingBeaver : IDataReceiver<Poem>
{
    public FlyingBeaver(DataBaseCredentials dataBaseCredentials, string? localAccentuationsSavePath)
    {
        _poem.OnEdit += InvokeOnUpdated;
        _poemSaver = new PoemSaver(this);
        _receivingDelayer = new(this);
        _poemTokenizer = new();
        //_receivingDelayer.OnDelayedReceive += ProceedPoem;
        _accentuationsRepository = AccentuationRepositoryProvider.Create(
            dataBaseCredentials, localAccentuationsSavePath);
        _rhythmAnalyzer = new(new SchemeAutoAnalyzer(_accentuationsRepository));
    }

    private readonly PoemSaver _poemSaver;
    private readonly PoemTokenizer _poemTokenizer;
    private readonly DataReceivingDelayer<Poem> _receivingDelayer;
    private readonly RhythmAnalyzer _rhythmAnalyzer;
    private readonly IAccentuationsRepository _accentuationsRepository;

    private Poem _poem = new("", RhythmBank.Trochee2);

    public Poem Poem
    {
        get => (Poem)_poem.Clone();
        private set
        {
            _poem.OnEdit -= InvokeOnUpdated;
            _poem = value;
            _poem.OnEdit += InvokeOnUpdated;
        }
    }

    public string PoemText
    {
        get => _poem.Text;
        set
        {
            if (_poem.Text.GetHashCode() == value.GetHashCode())
                return;

            _poem.Text = value;
            OnDataReceived?.Invoke(Poem);
            ProceedPoem(_poem);
        }
    }

    public bool HasSavedPath => _poemSaver.HasSavedPath;
    public bool AllChangesSaved => _poemSaver.AllChangesSaved;

    public event Action? OnUpdated;
    public event Action<Poem>? OnDataReceived;
    public event Action<RhythmResult>? OnRhythmResult;

    public void LoadFromFile(string? path) =>
        Poem = _poemSaver.LoadFromFile(path) ?? Poem;

    public void SavePoemToFile(string? path = default!) =>
        _poemSaver.SavePoemToFile(_poem, path);

    private async void ProceedPoem(Poem poem)
    {
        if (poem is null) 
            return;
        
        var poemClone = poem.Clone() as Poem;
        var poemToken = await _poemTokenizer.TokenizeAsync(poemClone);
        var rhythmResult = await _rhythmAnalyzer.AnalyzeAsync(poemToken);
        OnRhythmResult?.Invoke(rhythmResult);
    }
    
    private void InvokeOnUpdated() =>
        OnUpdated?.Invoke();
}