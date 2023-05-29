using System.Diagnostics;
using FlyingBeaverIDE.Logic;

namespace FlyingBeaverIDE.UI.Services;

public class FileSaver
{
    public FileSaver(FlyingBeaver flyingBeaver) => 
        _flyingBeaver = flyingBeaver;

    private const string PathWhiteSpaceShield = "?";
    private readonly SaveDialogsViewer _saveDialogsViewer = new();
    private readonly FlyingBeaver _flyingBeaver;

    public void OpenFile()
    {
        var filePath = _saveDialogsViewer.ChooseFilePathToOpen();
        if (filePath is null) return;
        Process.Start(Application.ExecutablePath, ShieldPath(filePath));
    }
    
    public void CreateNewFile() => 
        Process.Start(Application.ExecutablePath);

    public void SaveFile()
    {
        if (_flyingBeaver.HasSavedPath)
        {
            _flyingBeaver.SavePoemToFile();
            return;                
        }

        SaveFileAs();
    }
    
    public void SaveFileAs()
    {
        var path = _saveDialogsViewer.ChooseFilePathToSave();
        if (string.IsNullOrEmpty(path))
            return;
        _flyingBeaver.SavePoemToFile(path);
    }
    
    public void TrySaveOnClose(FormClosingEventArgs formClosingEventArgs)
    {
        if (_flyingBeaver.AllChangesSaved)
            return;

        var choice = _saveDialogsViewer.AskSaveBeforeClosing();
        if (choice == DialogResult.Cancel)
        {
            formClosingEventArgs.Cancel = true;
            return;
        }

        if (choice == DialogResult.No)
            return;

        SaveFile();
        if (!_flyingBeaver.AllChangesSaved)
            formClosingEventArgs.Cancel = true;
    }

    public static string ShieldPath(string path)
        => path.Replace(" ", PathWhiteSpaceShield);
    
    public static string UnshieldPath(string path)
        => path.Replace(PathWhiteSpaceShield, " ");
}