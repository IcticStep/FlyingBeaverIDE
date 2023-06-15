using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace DataStorage;

public class FileSaver<T>
{
    private readonly JsonSerializerOptions? _jsonOptions = new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        WriteIndented = true
    };
    
    public T? TryLoadFromFile(string? path)
    {
        if (!File.Exists(path))
            return default;
        
        var json = File.ReadAllText(path);
        if (string.IsNullOrWhiteSpace(json))
            return default;
        return JsonSerializer.Deserialize<T>(json, _jsonOptions);
    }

    public void SaveToFile(T data, string? path)
    {
        var json = JsonSerializer.Serialize(data, _jsonOptions);
        File.WriteAllText(path, json);
    }
}