namespace Domain.Tokenized;

public readonly struct VerseToken
{
    public VerseToken(string rawVerse, int position, List<WordToken> words)
    {
        RawVerse = rawVerse;
        Position = position;
        _words = words;
    }
    
    public readonly string RawVerse;
    public readonly int Position;
    private readonly List<WordToken> _words;

    public IReadOnlyList<WordToken> Words => _words;
}