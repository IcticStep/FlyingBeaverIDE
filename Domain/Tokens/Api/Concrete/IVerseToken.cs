namespace Domain.Tokens.Api.Concrete;

public interface IVerseToken : IToken
{
    public string RawVerse { get; }
    public IReadOnlyList<IWordToken> Words { get; }
    public IReadOnlyList<ISyllableToken> AllSyllables { get; }
}