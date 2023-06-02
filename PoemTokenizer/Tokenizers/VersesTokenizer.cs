using Domain;
using Domain.Tokenized;
using PoemTokenizer.Data;

namespace PoemTokenizer.Tokenizers;

public class VersesTokenizer
{
    private const int MinimalNewLinesCountBetweenVerses = 2;
    private readonly WordsTokenizer _wordsTokenizer = new();
    private string _input = string.Empty;
    private int _verseStartIndex = -1;
    private int _newLinesCount;
    private List<RawToken> _rawTokens = new();

    private bool HasVerseToExtract => 
        _verseStartIndex != -1;

    public IEnumerable<VerseToken> Tokenize(Poem poem) => 
        Tokenize(poem.Text);

    public IEnumerable<VerseToken> Tokenize(string input)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (string.IsNullOrWhiteSpace(input))
            return Enumerable.Empty<VerseToken>();

        _input = input;
        GetRawTokens();
        return GetTokensFromRaw();
    }

    private void GetRawTokens()
    {
        _rawTokens = new List<RawToken>();
        for (var i = 0; i < _input.Length; i++)
        {
            if (IsNewLine(i))
            {
                _newLinesCount++;
                continue;
            }

            if (!HasVerseToExtract)
                _verseStartIndex = i;
                
            if (_newLinesCount >= MinimalNewLinesCountBetweenVerses)
                ExtractVerse(i);

            _newLinesCount = 0;
        }

        if (!HasVerseToExtract)
            return;
        
        ExtractVerse(_input.Length);
    }

    private void ExtractVerse(int i)
    {
        var part = _input.Substring(_verseStartIndex, i - _verseStartIndex - _newLinesCount);
        _rawTokens.Add(new RawToken(part, _verseStartIndex, lowerValue: false));
        _verseStartIndex = i;
    }

    private bool IsNewLine(int i) => 
        _input[i] == '\n';

    private IEnumerable<VerseToken> GetTokensFromRaw() =>
        _rawTokens
            .Select(token => new VerseToken(
                token.Value,
                token.Position,
                _wordsTokenizer
                    .Tokenize(token.Value)
                    .ToList()));
}