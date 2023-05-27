namespace Domain;

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
}