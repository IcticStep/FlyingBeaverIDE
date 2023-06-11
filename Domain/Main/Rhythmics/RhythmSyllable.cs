namespace Domain.Main.Rhythmics;

[Serializable]
public class RhythmSyllable
{
    public RhythmSyllable(bool accentuated) => 
        Accentuated = accentuated;

    public bool Accentuated { get; }
}