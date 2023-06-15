using Domain.Analysing.Tokens.Api.Concrete;

namespace Domain.Analysing.Tokens.Concrete;

public class VerseToken : Token, IVerseToken
{
    public VerseToken(string rawVerse, List<IWordToken> words, int position, int absolutePosition = 0)
    : base(position, absolutePosition)
    {
        RawVerse = rawVerse;
        _words = words;
    }
    
    public string RawVerse { get; }
    private readonly List<IWordToken> _words;

    public IReadOnlyList<IWordToken> Words => _words;

    public IReadOnlyList<ISyllableToken> AllSyllables =>
        Words
            .SelectMany(word => word.SyllableTokens)
            .ToList();

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