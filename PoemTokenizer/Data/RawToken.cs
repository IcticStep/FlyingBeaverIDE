namespace PoemTokenizer.Data;

internal readonly struct RawToken
{
    public RawToken(string value, int position, bool loverValue = true)
    {
        Value = loverValue ? value.ToLowerInvariant() : value;
        Position = position;
    }

    public string Value { get; }
    public int Position { get; }

    public override string ToString() => $"{{{Value}}}:{Position}";
}