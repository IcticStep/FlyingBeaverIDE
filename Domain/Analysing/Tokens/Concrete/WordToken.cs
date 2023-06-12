using Domain.Analysing.Tokens.Api.Concrete;
using Domain.Main;

namespace Domain.Analysing.Tokens.Concrete;

public class WordToken : Token, IWordToken
{
    public WordToken(string rawText, List<ISyllableToken> syllableTokens, int position, int absolutePosition = 0)
        : base(position, absolutePosition)
    {
        RawText = rawText;
        _syllableTokens = syllableTokens;
    }

    private readonly List<ISyllableToken> _syllableTokens;
    private readonly List<int> _possibleAccentuations = new();

    public string RawText { get; }
    public IReadOnlyList<int> PossibleAccentuations => _possibleAccentuations;
    public int? Accentuation { get; private set; }
    public IReadOnlyList<ISyllableToken> SyllableTokens => _syllableTokens;
    
    public void SetPossibleAccentuations(Accentuation accentuationData)
    {
        foreach (var accentuation in accentuationData.Accentuations)
            SetPossibleAccentuations(accentuation);
    }

    public void SetPossibleAccentuations(int accentuation)
    {
        if(accentuation < 0 || accentuation > SyllableTokens.Count)
            throw new ArgumentOutOfRangeException();
        _possibleAccentuations.Add(accentuation);
    }

    public void SetAccentuation(int index)
    {
        if (Accentuation is not null)
            throw new InvalidOperationException("Не можна встановити наголос другий раз.");
        Accentuation = index;
        _syllableTokens[index].Accentuate();
    }

    public override string ToString() =>
        $"{{{RawText}}} позиція:{Position} склади:{GetSyllableTokensAsString()}";

    public override bool Equals(object? obj)
    {
        if (obj is not IWordToken other)
            return false;

        if (RawText != other.RawText || Position != other.Position)
            return false;

        if (SyllableTokens.Count != other.SyllableTokens.Count)
            return false;

        for (var i = 0; i < SyllableTokens.Count; i++)
        {
            if (!SyllableTokens[i].Equals(other.SyllableTokens[i]))
                return false;
        }

        return true;
    }

    private string GetSyllableTokensAsString()
    {
        var result = string.Empty;
        foreach (var token in _syllableTokens)
            result += token;
        return result;
    }
}