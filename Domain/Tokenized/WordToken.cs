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

    public override string ToString() => 
        $"{{{RawText}}} позиція:{Position} склади:{GetSyllableTokensAsString()}";

    public override bool Equals(object? obj)
    {
        if (obj is not WordToken other) 
            return false;

        if (RawText != other.RawText || Position != other.Position)
            return false;

        if (SyllableTokens.Count != other.SyllableTokens.Count)
            return false;
        
        for (var i = 0; i < SyllableTokens.Count; i++)
        {
            if (!SyllableTokens[i].Equals(other.SyllableTokens[i]))
                return false;
        }
        
        return true;
    }

    private string GetSyllableTokensAsString()
    {
        var result = string.Empty;
        foreach (var token in _syllableTokens)
            result += token;
        return result;
    }
}