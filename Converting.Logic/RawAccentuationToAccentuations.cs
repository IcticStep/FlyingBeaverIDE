using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using ConsoleHelpers.Core;
using Domain;
using HtmlParserSlovnyk.Domain;
using PoemTokenizer;

namespace Converting.Logic;

public class RawAccentuationToAccentuations : ILinearHelper
{
    private const char AccentuationSymbol = '$';
    private readonly Syllabler _syllabler = new();
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        WriteIndented = true
    };

    private List<WordParsedContent> _parsedContents = default!;
    private IEnumerable<Accentuation> _result = Array.Empty<Accentuation>();

    public string Input
    {
        set
        {
            var parsed = JsonSerializer.Deserialize<List<WordParsedContent>>(value, _jsonOptions);
            if (parsed is null || !parsed.Any())
                throw new ArgumentException("Invalid json!");
            
            _parsedContents = parsed;
        }
    }

    public string Output => JsonSerializer.Serialize(_result, _jsonOptions);

    public void Proceed() => 
        _result = _parsedContents.Select(ConvertWord);

    private Accentuation ConvertWord(WordParsedContent parsedWord)
    {
        var word = parsedWord.Word;
        var accentuations = GetAccentuatedSyllables(parsedWord.ParsedContent);
        return new(word, accentuations.ToList());
    }

    private IEnumerable<int> GetAccentuatedSyllables(string parsedWord)
    {
        var accentuationPositions = GetAccentuationPositions(parsedWord);
        return accentuationPositions
            .Select(position => GetAccentedSyllable(parsedWord, position));
    }

    private IEnumerable<int> GetAccentuationPositions(string parsedWord) =>
        parsedWord
            .Select((symbol, index) => (symbol, index))
            .Where(symbolData => symbolData.symbol == AccentuationSymbol)
            .Select(symbolData => symbolData.index);

    private int GetAccentedSyllable(string word, int accentuationIndex)
    {
        var beforeAccentuation = word.Substring(0, accentuationIndex);
        return _syllabler.CountSyllables(beforeAccentuation);
    }

}