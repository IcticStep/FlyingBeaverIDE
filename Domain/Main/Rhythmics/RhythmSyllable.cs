namespace Domain.Main.Rhythmics;

[Serializable]
public class RhythmSyllable
{
    public RhythmSyllable(bool accentuated) => 
        Accentuated = accentuated;

    public bool Accentuated { get; }

    public override bool Equals(object? obj)
    {
        if (obj is not RhythmSyllable other)
            return false;

        return Accentuated == other.Accentuated;
    }

    public override int GetHashCode() => 
        Accentuated.GetHashCode();
}