namespace PoemTokenization.Data;

internal readonly struct RawToken
{
    public RawToken(string value, int position, bool lowerValue = true)
    {
        Value = lowerValue ? value.ToLowerInvariant() : value;
        Position = position;
    }

    public readonly string Value;
    public readonly int Position;

    public override string ToString() => $"{{{Value}}}:{Position}";
}