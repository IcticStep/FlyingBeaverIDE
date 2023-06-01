using Domain.Tokenized;
using PoemTokenizer.Data;

namespace PoemTokenizer.Tokenizers;

public class VersesTokenizer
{
    private const int MinimalNewLinesCountBetweenVerses = 2;
    private readonly WordsTokenizer _wordsTokenizer = new();
    private string _input = string.Empty;
    
    public IEnumerable<VerseToken> Tokenize(string input)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (string.IsNullOrWhiteSpace(input))
            return Enumerable.Empty<VerseToken>();

        _input = input;
        var rawTokens = GetRowTokens();
        return GetTokensFromRaw(rawTokens);
    }

    private IReadOnlyList<RawToken> GetRowTokens()
    {
        var tokens = new List<RawToken>();

        int startIndex = -1;
        int newLinesCount = 0;

        for (int i = 0; i < _input.Length; i++)
        {
            if (_input[i] == '\n')
            {
                newLinesCount++;
            }
            else
            {
                if (startIndex == -1)
                    startIndex = i;
                
                if (newLinesCount >= 2)
                {
                    string part = _input.Substring(startIndex, i - startIndex - newLinesCount);
                    tokens.Add(new RawToken(part, startIndex, lowerValue:false));
                    startIndex = i;
                }

                newLinesCount = 0;
            }
        }

        // Check if there's a remaining part after the last occurrence of two or more consecutive newlines
        if (startIndex != -1)
        {
            string part = _input.Substring(startIndex);
            tokens.Add(new RawToken(part, startIndex, lowerValue:false));
        }

        return tokens;
    }

    private IEnumerable<VerseToken> GetTokensFromRaw(IReadOnlyList<RawToken> rawTokens) =>
        rawTokens
            .Select(token => new VerseToken(
                token.Value,
                token.Position,
                _wordsTokenizer
                    .Tokenize(token.Value)
                    .ToList()));

    private IReadOnlyList<int> FindIndexesOf(string text, char symbol) => 
        text
            .Select((x, index) => new CharRawToken(x, index))
            .Where(token => token.Value == symbol)
            .Select(token => token.Position)
            .ToList();
}