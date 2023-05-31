namespace Domain.Tokenized;

public readonly struct SyllableToken
{
    public SyllableToken(string vowel, int textPosition)
    {
        Vowel = vowel;
        TextPosition = textPosition;
    }

    public readonly string Vowel;
    public readonly int TextPosition;

    public override string ToString() => $"{Vowel}:{{{TextPosition}}}";
}