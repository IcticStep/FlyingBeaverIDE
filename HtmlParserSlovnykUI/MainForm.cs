using HtmlParserSlovnykUA;
using HtmlParserSlovnykUA.Parsers.LettersLinksParser;

namespace HtmlParserSlovnykUI;

public partial class MainForm : Form
{
    private const string RowsDataCountLabel = "Кількість записів: ";
    private const string FilesDescription = "JSON Data File";
    private const string FileExtension = "json";
    private const string FileFilter = $"{FilesDescription}|*.{FileExtension}";
    private readonly SlovnykUAParser _slovnykUaParser = new();
    private List<Button> _buttons;

    public MainForm()
    {
        InitializeComponent();
        _slovnykUaParser.OnUpdate += _ => UpdateView();
        _slovnykUaParser.OnFinish += _ => EnableButtons();
        InitButtonsList();
    }

    private void InitButtonsList()
    {
        _buttons = new()
        {
            LettersParseButton,
            LettersOpenButton,
            LettersSaveButton,
            SublettersParseButton,
            SublettersOpenButton,
            SublettersSaveButton,
            WordsLinksParseButton,
            WordsLinksOpenButton,
            WordsLinksSaveButton,
            WordsParseButton,
            WordsOpenButton,
            WordsLinksSaveButton
        };
    }

    private void ParseLetters(object sender, EventArgs e)
    {
        DisableButtons();
        _slovnykUaParser.StartParsingLetterLinks();
    }

    private void UpdateView()
    {
        LettersDataRows.Text = RowsDataCountLabel + _slovnykUaParser.LetterLinks.Count;
    }

    private void EnableButtons() =>
        _buttons.ForEach(button => button.Enabled = true);

    private void DisableButtons() =>
        _buttons.ForEach(button => button.Enabled = false);

    private void SaveLettersLinksData(object sender, EventArgs e)
    {
        var saveDialog = GetNewSaveDialog("LettersLinks");
        if (saveDialog.ShowDialog() != DialogResult.OK)
            return;

        SaveDataToFile(_slovnykUaParser.LetterLinksJson, saveDialog);
    }

    private void LoadLettersData(object sender, EventArgs e)
    {
        var loadDialog = GetNewLoadDialog("LettersLinks");
        if (loadDialog.ShowDialog() != DialogResult.OK)
            return;

        var loaded = LoadTextFromFile(loadDialog);
        _slovnykUaParser.LetterLinksJson = loaded;
        UpdateView();
    }

    private static string LoadTextFromFile(FileDialog loadFileDialog)
    {
        using var reader = new StreamReader(loadFileDialog.FileName);
        return reader.ReadToEnd();
    }

    private static void SaveDataToFile(string data, FileDialog saveFileDialog)
    {
        using var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
        using var writer = new StreamWriter(fileStream);
        writer.WriteLine(data);
    }

    private OpenFileDialog GetNewLoadDialog(string fileName)
    {
        var saveFileDialog = new OpenFileDialog();
        ConfigureDialog(fileName, saveFileDialog);
        return saveFileDialog;
    }

    private SaveFileDialog GetNewSaveDialog(string fileName)
    {
        var saveFileDialog = new SaveFileDialog();
        ConfigureDialog(fileName, saveFileDialog);
        return saveFileDialog;
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