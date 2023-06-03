namespace Domain.Tokens.Api;

public interface IVerseToken
{
    public string RawVerse { get; }
    public int Position { get; }
    public IReadOnlyList<IWordToken> Words { get; }
    public IReadOnlyList<ISyllableToken> AllSyllables { get; }
}