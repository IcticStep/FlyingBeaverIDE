using DataStorage.Poem;
using Domain;
using Domain.Main;

namespace FlyingBeaverIDE.Logic;

internal class Saver
{
    private readonly PoemSaver _poemSaver = new();
    private string _savedPath = null!;
    public bool AllChangesSaved { get; private set; }
    public bool HasSavedPath => !string.IsNullOrWhiteSpace(_savedPath);
    
    public Poem? LoadFromFile(string path)
    {
        _savedPath = path;
        AllChangesSaved = true;
        return _poemSaver.LoadFromFile(path);
    }

    public void SaveToFile(Poem poem, string path = default!)
    {
        var pathWasGiven = !string.IsNullOrWhiteSpace(path);
        if(!pathWasGiven && !HasSavedPath)
            throw new InvalidOperationException("Невідомий шлях збереження файлу!");

        AllChangesSaved = true;
        
        if (!pathWasGiven)
        {
            _poemSaver.SaveToFile(poem, _savedPath);
            return;
        }
        
        _savedPath = path;
        _poemSaver.SaveToFile(poem, path);
    }

    public void SignalDataChanged() => 
        AllChangesSaved = false;
}