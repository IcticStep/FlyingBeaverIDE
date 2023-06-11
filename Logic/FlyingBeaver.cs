using Domain;
using Domain.Main;

namespace FlyingBeaverIDE.Logic;

public class FlyingBeaver
{
    public FlyingBeaver() => 
        SubscribeOnPoemUpdate();

    private readonly Saver _saver = new();
    
    private Poem _poem = new Poem();

    public event Action? OnUpdated;

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
        set => _poem.Text = value;
    }

    public bool HasSavedPath => _saver.HasSavedPath;
    public bool AllChangesSaved => _saver.AllChangesSaved;

    private void SubscribeOnPoemUpdate() => 
        _poem!.OnEdit += InvokeOnUpdated;

    private void UnsubscribeOnPoemUpdate()
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        _poem.OnEdit -= InvokeOnUpdated;
    }

    private void InvokeOnUpdated() => OnUpdated?.Invoke();

    public void LoadFromFile(string path)
    {
        Poem = _saver.LoadFromFile(path);
    }

    public void SavePoemToFile(string path = default!)
    {
        if (string.IsNullOrEmpty(path))
        {
            _saver.SaveToFile(Poem);
            return;
        }
        
        _saver.SaveToFile(Poem, path);
    }

    public void SignalUserInput()
    {
        _saver.SignalDataChanged();
    }
}