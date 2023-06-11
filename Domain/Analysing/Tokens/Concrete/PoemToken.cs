using Domain.Analysing.Tokens.Api.Concrete;
using Domain.Main;
using Domain.Main.Rhythmics;

namespace Domain.Analysing.Tokens.Concrete;

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