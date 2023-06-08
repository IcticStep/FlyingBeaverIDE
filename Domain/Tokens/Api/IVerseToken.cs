namespace Domain.Tokens.Api;

public interface IVerseToken
{
    public string RawVerse { get; }
    public int Position { get; }
    public IReadOnlyList<IWordToken> Words { get; }
    public IReadOnlyList<ISyllableToken> AllSyllables { get; }

    public IReadOnlyList<ISyllableToken> GetAllSyllablesAbsolutePositioned =>
        GetAllSyllableAdjusted(Position);

    public IReadOnlyList<ISyllableToken> GetAllSyllableAdjusted(int adjusting)
    {
        var original = AllSyllables;
        return original
            .Select(syllable => syllable
                .GetWithAbsolutePosition(adjusting))
            .ToList();
    }
}