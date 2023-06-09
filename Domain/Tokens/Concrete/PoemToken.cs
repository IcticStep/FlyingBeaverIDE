using Domain.Tokens.Api.Concrete;

namespace Domain.Tokens.Concrete;

public class PoemToken
{
    public PoemToken(Poem poem, IReadOnlyList<IVerseToken> verses)
    {
        RawText = poem.Text;
        Rhythm = poem.Rhythm;
        Verses = verses;
    }

    public readonly string RawText;
    public readonly Rhythm Rhythm;
    public readonly IReadOnlyList<IVerseToken> Verses;

    public IReadOnlyList<IWordToken> AllWords =>
        Verses
            .SelectMany(verse => verse.Words)
            .ToList();

    public IReadOnlyList<ISyllableToken> AllSyllables =>
        Verses
            .SelectMany(verse => verse.AllSyllables)
            .ToList();
}