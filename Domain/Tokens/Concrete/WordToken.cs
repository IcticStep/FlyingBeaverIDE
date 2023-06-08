using Domain.Tokens.Api.Concrete;

namespace Domain.Tokens.Concrete;

public class WordToken : Token, IWordToken
{
    public WordToken(string rawText, List<ISyllableToken> syllableTokens, int position, int absolutePosition = 0)
        : base(position, absolutePosition)
    {
        RawText = rawText;
        _syllableTokens = syllableTokens;
    }

    private readonly List<ISyllableToken> _syllableTokens;

    public string RawText { get; }

    protected override void AdjustChildrenAbsolutePosition(int value)
    {
        foreach (var token in SyllableTokens)
            token.AdjustAbsolutePosition(value);
    }

    public IReadOnlyList<ISyllableToken> SyllableTokens => _syllableTokens;

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