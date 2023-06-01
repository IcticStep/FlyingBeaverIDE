namespace PoemTokenizer.Data;

internal readonly struct RawWordToken
{
    public RawWordToken(string value, int position)
    {
        Value = value.ToLowerInvariant();
        Position = position;
    }

    public string Value { get; }
    public int Position { get; }

    public override string ToString() => $"{{{Value}}}:{Position}";
}