using FlyingBeaverIDE.UI.Services.System;
using Syncfusion.Windows.Forms;

namespace FlyingBeaverIDE.UI.Services.UI;

public class BackStageMenu
{
    public BackStageMenu(FileSaver fileSaver, BackStageView backStageView)
    {
        _fileSaver = fileSaver;
        _backStageView = backStageView;
    }

    private readonly BackStageView _backStageView;
    private readonly FileSaver _fileSaver;
    
    public void CreateNewFile() => 
        HandleAction(_fileSaver.CreateNewFile);

    public void OpenFile() => 
        HandleAction(_fileSaver.OpenFile);

    public void SaveFile() => 
        HandleAction(_fileSaver.SaveFile);

    public void SaveFileAs() => 
        HandleAction(_fileSaver.SaveFileAs);

    public void ExitProgram() =>
        Application.Exit();

    private void HandleAction(Action? action)
    {
        action?.Invoke();
        _backStageView.HideBackStage();
    }
}