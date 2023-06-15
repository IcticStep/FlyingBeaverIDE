using Domain.Main;

namespace Domain.Analysing.Tokens.Api.Concrete;

public interface IWordToken : IToken
{
    public string RawText { get; }
    public IReadOnlyList<int> PossibleAccentuations { get; }
    public int? Accentuation { get; }
    public IReadOnlyList<ISyllableToken> SyllableTokens { get; }
    public void SetPossibleAccentuations(Accentuation accentuationData);
    void SetPossibleAccentuations(int accentuation);
    void SetAccentuation(int should);
    public bool Equals(object? obj);
}