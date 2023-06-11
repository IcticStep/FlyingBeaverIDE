using Domain.Main;

namespace Domain.Analysing.Tokens.Api.Concrete;

public interface IWordToken : IToken
{
    public string RawText { get; }
    public IReadOnlyList<int> PossibleAccentuations { get; }
    public IReadOnlyList<ISyllableToken> SyllableTokens { get; }
    public void SetPossibleAccentuations(Accentuation accentuationData);
}