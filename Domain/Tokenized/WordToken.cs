namespace Domain.Tokenized;

public readonly struct WordToken
{
    public WordToken(string rawText, List<SyllableToken> syllableTokens, int position)
    {
        RawText = rawText;
        _syllableTokens = syllableTokens;
        Position = position;
    }

    public readonly string RawText;
    public readonly int Position;
    private readonly List<SyllableToken> _syllableTokens;
    
    public IReadOnlyList<SyllableToken> SyllableTokens => _syllableTokens;
}