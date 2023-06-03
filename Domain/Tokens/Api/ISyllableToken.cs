namespace Domain.Tokens.Api;

public interface ISyllableToken
{
    public string Vowel { get; }
    public int Position { get; }
    public ISyllableToken GetWithAbsolutePosition(int relativePosition);
}