﻿using Domain.Tokenized;
using PoemTokenizer.Data;

namespace PoemTokenizer.Tokenizers;

public class Worder
{
    private readonly Syllabler _syllabler = new();
    private readonly List<RawWordToken> _rawWords = new();
    private string _inputText = string.Empty;
    private int _wordStart = -1;

    private bool HasWordStart => _wordStart != -1;

    public IEnumerable<WordToken> Tokenize(string text)
    {
        if (text is null)
            throw new ArgumentNullException(nameof(text));

        if (string.IsNullOrWhiteSpace(text))
            return Enumerable.Empty<WordToken>();

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

    private IEnumerable<WordToken> ConvertRawTokensToTokens() =>
        _rawWords.Select(raw => 
            new WordToken(
                raw.Value, 
                _syllabler.Tokenize(raw.Value).ToList(),
                raw.Position));

    private bool IsPartOfWord(int i) => 
        char.IsLetter(_inputText[i]);

    private void ExtractWord(int endPointer)
    {
        var word = _inputText.Substring(_wordStart, endPointer - _wordStart);
        _rawWords.Add(new(word, _wordStart));
        _wordStart = -1;
    }
}