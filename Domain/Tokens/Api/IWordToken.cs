namespace Domain.Tokens.Api;

public interface IWordToken
{
    public string RawText { get; }
    public int Position { get; }
    public IReadOnlyList<ISyllableToken> SyllableTokens { get; }
}