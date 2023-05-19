namespace FlyingBeaverIDE.UI.Services;

public class FileSaver
{
    private const string FilesDescription = "Flying Beaver poem files";
    private const string FileExtension = "beaverpoem";
    private const string FileFilter = $"{FilesDescription}|*.{FileExtension}|All files|*.*";
    private const string DialogTitle = "Зберегти вірш";
    
    public void SaveFile(string data)
    {
        
    }

    public void SaveFileAs(string data)
    {
        var saveFileDialog = GetNewSaveDialog();
        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
        
        SaveDataToFile(data, saveFileDialog);
    }

    private static void SaveDataToFile(string data, FileDialog saveFileDialog)
    {
        using var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
        using var writer = new StreamWriter(fileStream);
        writer.WriteLine(data);
    }

    private SaveFileDialog GetNewSaveDialog()
    {
        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = FileFilter;
        saveFileDialog.Title = DialogTitle;
        saveFileDialog.DefaultExt = FileExtension;
        saveFileDialog.AddExtension = true;
        return saveFileDialog;
    }
}