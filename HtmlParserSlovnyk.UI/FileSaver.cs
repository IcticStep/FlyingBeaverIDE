namespace HtmlParserSlovnyk.UI;

public class FileSaver
{
    private const string FilesDescription = "JSON Data File";
    private const string FileExtension = "json";
    private const string FileFilter = $"{FilesDescription}|*.{FileExtension}";

    public void SaveData(string fileName, string data)
    {
        var saveDialog = GetNewSaveDialog(fileName);
        if (saveDialog.ShowDialog() != DialogResult.OK)
            return;

        SaveDataToFile(data, saveDialog);
    }
    
    public string LoadData(string fileName)
    {
        var loadDialog = GetNewLoadDialog(fileName);
        if (loadDialog.ShowDialog() != DialogResult.OK)
            return string.Empty;
        return LoadTextFromFile(loadDialog);
    }
    
    public OpenFileDialog GetNewLoadDialog(string fileName)
    {
        var saveFileDialog = new OpenFileDialog();
        ConfigureDialog(fileName, saveFileDialog);
        return saveFileDialog;
    }

    public SaveFileDialog GetNewSaveDialog(string fileName)
    {
        var saveFileDialog = new SaveFileDialog();
        ConfigureDialog(fileName, saveFileDialog);
        return saveFileDialog;
    }
    
    public string LoadTextFromFile(FileDialog loadFileDialog)
    {
        using var reader = new StreamReader(loadFileDialog.FileName);
        return reader.ReadToEnd();
    }

    public void SaveDataToFile(string data, FileDialog saveFileDialog)
    {
        using var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
        using var writer = new StreamWriter(fileStream);
        writer.WriteLine(data);
    }

    private static void ConfigureDialog(string fileName, FileDialog saveFileDialog)
    {
        saveFileDialog.Filter = FileFilter;
        saveFileDialog.Title = fileName;
        saveFileDialog.FileName = fileName;
        saveFileDialog.DefaultExt = FileExtension;
        saveFileDialog.AddExtension = true;
    }
}