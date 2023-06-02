namespace Domain.Tokens;

public class PoemToken
{
    public PoemToken(string rawText, Rhythm rhythm, IReadOnlyList<VerseToken> verses)
    {
        RawText = rawText;
        Rhythm = rhythm;
        Verses = verses;
    }

    public PoemToken(Poem poem, IReadOnlyList<VerseToken> verses)
        : this(poem.Text, poem.Rhythm, verses)
    {
        
    }

    public readonly string RawText;
    public readonly Rhythm Rhythm;
    public readonly IReadOnlyList<VerseToken> Verses;
}