namespace PoemTokenizer;

public struct SyllableToken
{
    public SyllableToken(string vowel, int textPosition)
    {
        Vowel = vowel;
        TextPosition = textPosition;
    }

    public string Vowel { get; }
    public int TextPosition { get; }

    public override string ToString() => $"{Vowel}:{{{TextPosition}}}";
}