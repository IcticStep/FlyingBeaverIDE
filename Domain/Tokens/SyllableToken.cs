using Domain.Tokens.Api;

namespace Domain.Tokens;

public class SyllableToken : ISyllableToken
{
    public SyllableToken(string vowel, int position)
    {
        Vowel = vowel;
        Position = position;
    }

    public string Vowel { get; }
    public int Position { get; }
    public ISyllableToken GetWithAbsolutePosition(int relativePosition) => 
        new SyllableToken(Vowel, Position + relativePosition);

    public override string ToString() => $"{Vowel}:{{{Position}}}";

    public override bool Equals(object? obj)
    {
        if (obj is not ISyllableToken other) 
            return false;

        return Vowel == other.Vowel 
               && Position == other.Position;
    }
}