using Domain.Tokens;
using Domain.Tokens.Api;
using Domain.Tokens.Api.Concrete;
using Domain.Tokens.Concrete;
using PoemTokenization.Data;

namespace PoemTokenization.Tokenizers;

public class WordsTokenizer
{
    private readonly SyllablesTokenizer _syllablesTokenizer = new();
    private readonly List<RawToken> _rawWords = new();
    private string _inputText = string.Empty;
    private int _wordStart = -1;
    private int _absolutePositionAdjustment;

    private bool HasWordStart => _wordStart != -1;

    public IEnumerable<IWordToken> Tokenize(string text, int absolutePositionAdjustment = 0)
    {
        ArgumentNullException.ThrowIfNull(text);

        if (string.IsNullOrWhiteSpace(text))
            return Enumerable.Empty<IWordToken>();
        
        _rawWords.Clear();
        _absolutePositionAdjustment = absolutePositionAdjustment;
        _inputText = text;
        
        SplitSentence();
        return ConvertRawTokensToTokens();
    }

    private void SplitSentence()
    {
        for (var i = 0; i < _inputText.Length; i++)
        {
            if (!IsPartOfWord(i))
            {
                if (HasWordStart)
                    ExtractWord(i);
            }
            else if (!HasWordStart)
            {
                _wordStart = i;
            }
        }

        if (HasWordStart)
            ExtractWord(_inputText.Length);
    }

    private IEnumerable<IWordToken> ConvertRawTokensToTokens() =>
        _rawWords.Select(raw => 
            new WordToken(
                raw.Value, 
                _syllablesTokenizer.Tokenize(raw.Value, raw.Position + _absolutePositionAdjustment).ToList(),
                raw.Position,
                raw.Position+_absolutePositionAdjustment));

    private bool IsPartOfWord(int i) => 
        char.IsLetter(_inputText[i]);

    private void ExtractWord(int endPointer)
    {
        var word = _inputText.Substring(_wordStart, endPointer - _wordStart);
        _rawWords.Add(new(word, _wordStart));
        _wordStart = -1;
    }
}