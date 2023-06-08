using Domain.Tokens.Api;

namespace Domain.Tokens;

public class PoemToken
{
    public PoemToken(string rawText, Rhythm rhythm, IReadOnlyList<IVerseToken> verses)
    {
        RawText = rawText;
        Rhythm = rhythm;
        Verses = verses;
    }

    public PoemToken(Poem poem, IReadOnlyList<IVerseToken> verses)
        : this(poem.Text, poem.Rhythm, verses)
    {
        
    }

    public readonly string RawText;
    public readonly Rhythm Rhythm;
    public readonly IReadOnlyList<IVerseToken> Verses;

    public IReadOnlyList<ISyllableToken> AllSyllables => Verses
        .SelectMany(verse => verse.GetAllSyllablesAbsolutePositioned)
        .ToList();
}