namespace Domain.Tokens.Api.Concrete;

public interface IWordToken : IToken
{
    public string RawText { get; }
    public IReadOnlyList<ISyllableToken> SyllableTokens { get; }
}