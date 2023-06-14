namespace Domain.Main;

[Serializable]
public class Accentuation
{
    public Accentuation(string word, List<int> accentuations)
    {
        Word = word;
        Accentuations = accentuations;
    }

    public string Word { get; set; }
    public List<int> Accentuations { get; set; }

    public static Accentuation? Combine(Accentuation? a, Accentuation? b)
    {
        switch (a)
        {
            case null when b is null:
                return null;
            case null:
                return b;
            case not null when b is null:
                return a;
        }

        if(a.Word != b.Word)
            throw new InvalidOperationException();
        
        var combinedAccentuations = a.Accentuations.Concat(b.Accentuations).ToList();
        return new(a.Word, combinedAccentuations);
    }
}