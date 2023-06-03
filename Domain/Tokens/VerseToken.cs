using Domain.Tokens.Api;

namespace Domain.Tokens;

public class VerseToken : IVerseToken
{
    public VerseToken(string rawVerse, int position, List<IWordToken> words)
    {
        RawVerse = rawVerse;
        Position = position;
        _words = words;
    }
    
    public string RawVerse { get; }
    public int Position { get; }
    private readonly List<IWordToken> _words;

    public IReadOnlyList<IWordToken> Words => _words;

    public override bool Equals(object? obj)
    {
        if (obj is not IVerseToken other) 
            return false;

        if (RawVerse != other.RawVerse || Position != other.Position)
            return false;
        
        if (Words.Count != other.Words.Count)
            return false;
        
        for (var i = 0; i < Words.Count; i++)
        {
            if (!Words[i].Equals(other.Words[i]))
                return false;
        }

        return true;
    }
}