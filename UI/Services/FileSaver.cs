using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Domain;

namespace FlyingBeaverIDE.UI.Services;

public class FileSaver
{
    private const string FilesDescription = "Flying Beaver poem files";
    private const string FileExtension = "beaverpoem";
    private const string FileFilter = $"{FilesDescription}|*.{FileExtension}|All files|*.*";
    private const string DialogTitle = "Зберегти вірш";
    
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        WriteIndented = true
    };

    private string _savedPath = null!;

    public void SaveFileWithDialog(Poem data)
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (_savedPath is null)
        {
            SaveFileAsWithDialog(data);
            return;
        }

        var serializedPoem = SerializePoem(data);
        SaveDataToFile(_savedPath, serializedPoem);
    }

    private string SerializePoem(Poem poem) => JsonSerializer.Serialize(poem, _jsonOptions);

    public void SaveFileAsWithDialog(Poem data)
    {
        var saveFileDialog = GetNewFileDialog<SaveFileDialog>();
        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
        
        var serializedPoem = SerializePoem(data);
        SaveDataToFile(saveFileDialog.FileName, serializedPoem);
        _savedPath = saveFileDialog.FileName;
    }

    public string? ChooseFilePathToOpen()
    {
        var openFileDialog = GetNewFileDialog<OpenFileDialog>();
        if (openFileDialog.ShowDialog() != DialogResult.OK) 
            return default;
        return openFileDialog.FileName;
    }
    
    public Poem? LoadFileThroughDialog()
    {
        var openFileDialog = GetNewFileDialog<OpenFileDialog>();
        if (openFileDialog.ShowDialog() != DialogResult.OK) 
            return default;
        return LoadDataFromFile(openFileDialog.FileName);
    }

    public Poem? LoadDataFromFile(string fileName)
    {
        var json = File.ReadAllText(fileName);
        _savedPath = fileName;
        return JsonSerializer.Deserialize<Poem>(json);
    }

    private static void SaveDataToFile(string path, string data) => 
        File.WriteAllText(path, data);

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