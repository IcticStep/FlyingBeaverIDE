namespace FlyingBeaverIDE.UI.Services.UI;

public class SaveDialogsViewer
{
    private const string FilesDescription = "Flying Beaver poem files";
    private const string FileExtension = "beaverpoem";
    private const string FileFilter = $"{FilesDescription}|*.{FileExtension}|All files|*.*";
    private const string DialogTitle = "Зберегти вірш";
    private const string SaveOnCloseMessage = "Зберегти зміни?";
    private const string SaveOnCloseLabel = "Незбережені зміни";

    public string? ChooseFilePathToOpen()
        => ChoosePath<OpenFileDialog>();

    public string? ChooseFilePathToSave() 
        => ChoosePath<SaveFileDialog>();

    public DialogResult AskSaveBeforeClosing() =>
        MessageBox.Show(
            SaveOnCloseMessage,
            SaveOnCloseLabel,
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Warning);

    private string? ChoosePath<T>()
        where T : FileDialog, new()
    {
        var openFileDialog = GetNewFileDialog<T>();
        if (openFileDialog.ShowDialog() != DialogResult.OK) 
            return default;
        return openFileDialog.FileName;
    }

    private T GetNewFileDialog<T>()
        where T : FileDialog, new()
    {
        var saveFileDialog = new T();
        saveFileDialog.Filter = FileFilter;
        saveFileDialog.Title = DialogTitle;
        saveFileDialog.DefaultExt = FileExtension;
        saveFileDialog.AddExtension = true;
        return saveFileDialog;
    }
}