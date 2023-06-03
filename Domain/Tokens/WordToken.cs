using Domain.Tokens.Api;

namespace Domain.Tokens;

public class WordToken : IWordToken
{
    public WordToken(string rawText, List<ISyllableToken> syllableTokens, int position)
    {
        RawText = rawText;
        _syllableTokens = syllableTokens;
        Position = position;
    }
    
    private readonly List<ISyllableToken> _syllableTokens;
    
    public string RawText { get; }
    public int Position { get; }
    
    public IReadOnlyList<ISyllableToken> SyllableTokens => _syllableTokens;
    
    public IWordToken GetWithAbsoluteSyllablesPositions() =>
        new WordToken(
            RawText, 
            SyllableTokens
                .Select(syllable => syllable.GetWithAbsolutePosition(Position))
                .ToList(), 
            Position);

    public override string ToString() => 
        $"{{{RawText}}} позиція:{Position} склади:{GetSyllableTokensAsString()}";

    public override bool Equals(object? obj)
    {
        if (obj is not IWordToken other) 
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