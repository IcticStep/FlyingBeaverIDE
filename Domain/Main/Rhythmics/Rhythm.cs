using System.Text.Json.Serialization;

namespace Domain.Main.Rhythmics;

[Serializable]
public class Rhythm
{
    [JsonConstructor]
    public Rhythm(string name, IReadOnlyList<RhythmSyllable> scheme)
    {
        Scheme = scheme;
        Name = name;
    }

    public Rhythm(string name, params bool[] accents)
        : this(name, GetRhythmSyllables(accents))
    { }
    
    public Rhythm(string name, string accents) 
        : this(name, GetRhythmSyllables(accents))
    { }

    private IReadOnlyList<RhythmSyllable> _scheme;
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            ArgumentException.ThrowIfNullOrEmpty(value, nameof(Name));
            _name = value;
        }
    }

    public IReadOnlyList<RhythmSyllable> Scheme
    {
        get => _scheme;
        set
        {
            if (!value.Any())
                throw new ArgumentException("Неможливо зробити ритм пустим.");

            var accentuated = value.Where(x => x.Accentuated);
            if (!accentuated.Any())
                throw new ArgumentException("Ритм має складатись хоч з одного наголошеного складу.");
            
            _scheme = value;
        }
    }

    public bool[] GenerateAccentuationScheme(int length)
    {
        var result = new bool[length];
        for (var i = 0; i < length; i++)
            result[i] = SyllableShouldBeAccentuated(i);
        return result;
    }

    public bool SyllableShouldBeAccentuated(int index) =>
        Scheme[index % Scheme.Count].Accentuated;

    public override string ToString() => $"{Name}";

    public override bool Equals(object? obj)
    {
        if (obj is not Rhythm other)
            return false;

        if (Scheme.Count != other.Scheme.Count)
            return false;
        
        for (var i = 0; i < Scheme.Count; i++)
            if (!_scheme[i].Equals(other.Scheme[i]))
                return false;
        return true;
    }

    public override int GetHashCode() => 
        HashCode.Combine(Name.GetHashCode(), Scheme.GetHashCode());

    private static IReadOnlyList<RhythmSyllable> GetRhythmSyllables(bool[] accents) =>
        accents
            .Select(x => new RhythmSyllable(x))
            .ToList();

    private static IReadOnlyList<RhythmSyllable> GetRhythmSyllables(string accents) =>
        accents
            .Select(GetRhythmSyllable)
            .ToList();

    private static RhythmSyllable GetRhythmSyllable(char symbol)
    {
        if (symbol != '1' && symbol != '0')
            throw new ArgumentException("Should be string of 1 and 0 only.");
        return new(symbol == '1');
    }
}