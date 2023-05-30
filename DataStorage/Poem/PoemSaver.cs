using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace DataStorage.Poem;

public class PoemSaver
{
    private readonly JsonSerializerOptions? _jsonOptions = new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        WriteIndented = true
    };
    
    public Domain.Poem? LoadFromFile(string path)
    {
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Domain.Poem>(json, _jsonOptions);
    }

    public void SaveToFile(Domain.Poem poem, string path)
    {
        var json = JsonSerializer.Serialize(poem, _jsonOptions);
        File.WriteAllText(path, json);
    }
}