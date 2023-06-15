namespace Domain.Analysing.Tokens.Api.Concrete;

public interface ISyllableToken : IToken
{
    public string Vowel { get; }
    public bool IsAccentuated { get; }
    public void Accentuate();
}