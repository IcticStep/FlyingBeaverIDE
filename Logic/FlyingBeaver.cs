using DataStorage;
using Domain.Main;
using FlyingBeaverIDE.Logic.API;
using FlyingBeaverIDE.Logic.Services;
using PoemTokenization.Tokenizers;

namespace FlyingBeaverIDE.Logic;

public class FlyingBeaver : IRawDataReceivedSignaller
{
    public FlyingBeaver(DataBaseCredentials dataBaseCredentials)
    {
        _saver = new Saver(this);
        SubscribeOnPoemUpdate();
    }

    private readonly Saver _saver;
    private readonly PoemTokenizer _poemTokenizer = new();

    private Poem _poem = new();

    public Poem Poem
    {
        get => (Poem)_poem.Clone();
        private set
        {
            UnsubscribeOnPoemUpdate();
            _poem = value;
            SubscribeOnPoemUpdate();
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
            OnRawDataReceived?.Invoke();
        }
    }

    public bool HasSavedPath => _saver.HasSavedPath;
    public bool AllChangesSaved => _saver.AllChangesSaved;

    public event Action? OnUpdated;
    public event Action? OnRawDataReceived;

    private void SubscribeOnPoemUpdate() =>
        _poem.OnEdit += InvokeOnUpdated;

    private void UnsubscribeOnPoemUpdate() =>
        _poem.OnEdit -= InvokeOnUpdated;

    private void InvokeOnUpdated() =>
        OnUpdated?.Invoke();

    public void LoadFromFile(string path) =>
        Poem = _saver.LoadFromFile(path) ?? Poem;

    public void SavePoemToFile(string path = default!) =>
        _saver.SavePoemToFile(_poem, path);
}