using DataStorage.Poem;
using Domain.Main;
using FlyingBeaverIDE.Logic.API;

namespace FlyingBeaverIDE.Logic.Services;

internal class Saver
{
    public Saver(IRawDataReceivedSignaller dataChangeSignaller) => 
        dataChangeSignaller.OnRawDataReceived += HandleDataChanged;

    private readonly PoemSaver _poemSaver = new();
    private string _savedPath = null!;

    public bool AllChangesSaved { get; private set; }
    public bool HasSavedPath => !string.IsNullOrWhiteSpace(_savedPath);
    
    public void SavePoemToFile(Poem poem, string path = default!)
    {
        if (string.IsNullOrEmpty(path))
        {
            SaveToFile(poem);
            return;
        }
        
        SaveToFile(poem, path);
    }
    
    public Poem? LoadFromFile(string path)
    {
        _savedPath = path;
        AllChangesSaved = true;
        return _poemSaver.LoadFromFile(path);
    }

    private void HandleDataChanged() => 
        AllChangesSaved = false;

    private void SaveToFile(Poem poem, string path = default!)
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
}