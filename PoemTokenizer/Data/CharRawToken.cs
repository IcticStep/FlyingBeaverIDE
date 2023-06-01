namespace PoemTokenizer.Data;

internal readonly struct CharRawToken
{
    public CharRawToken(char value, int position)
    {
        Value = value;
        Position = position;
    }

    public readonly char Value;
    public readonly int Position;

    public override string ToString() => $"{{{Value}}}:{Position}";
}