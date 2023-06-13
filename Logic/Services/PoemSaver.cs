using DataStorage;
using Domain.Main;
using FlyingBeaverIDE.Logic.Api;

namespace FlyingBeaverIDE.Logic.Services;

internal class PoemSaver
{
    public PoemSaver(IDataReceiver<Poem> receiver) => 
        receiver.OnDataReceived += HandleDataChanged;

    private readonly FileSaver<Poem> _fileSaver = new();
    private string? _savedPath = null!;

    public bool AllChangesSaved { get; private set; }
    public bool HasSavedPath => !string.IsNullOrWhiteSpace(_savedPath);
    
    public void SavePoemToFile(Poem poem, string? path = default!)
    {
        if (string.IsNullOrEmpty(path))
        {
            SaveToFile(poem);
            return;
        }
        
        SaveToFile(poem, path);
    }
    
    public Poem? LoadFromFile(string? path)
    {
        _savedPath = path;
        AllChangesSaved = true;
        return _fileSaver.TryLoadFromFile(path);
    }

    private void HandleDataChanged(object o) => 
        AllChangesSaved = false;

    private void SaveToFile(Poem poem, string? path = default!)
    {
        var pathWasGiven = !string.IsNullOrWhiteSpace(path);
        if(!pathWasGiven && !HasSavedPath)
            throw new InvalidOperationException("Невідомий шлях збереження файлу!");

        AllChangesSaved = true;
        
        if (!pathWasGiven)
        {
            _fileSaver.SaveToFile(poem, _savedPath);
            return;
        }
        
        _savedPath = path;
        _fileSaver.SaveToFile(poem, path);
    }
}