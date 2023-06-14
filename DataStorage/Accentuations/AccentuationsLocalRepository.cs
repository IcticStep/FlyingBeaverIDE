using DataStorage.Accentuations.Api;
using Domain.Main;

namespace DataStorage.Accentuations;

public class AccentuationsLocalRepository : IAccentuationsRepository
{
    public AccentuationsLocalRepository(string? savingLocation)
    {
        _savingLocation = savingLocation;
        _accentuations = _saver.TryLoadFromFile(_savingLocation) ?? new();
    }

    private readonly string? _savingLocation;
    private readonly List<Accentuation> _accentuations;
    private readonly FileSaver<List<Accentuation>> _saver = new();

    public int Count() => 
        _accentuations.Count;

    public bool IsEmpty() => 
        !_accentuations.Any();

    public Accentuation? GetAccentuationSyllable(string word)
    {
        foreach (var accentuation in _accentuations)
        {
            if (WordsAreSame(accentuation.Word, word))
                return accentuation;
        }
        
        return null;
    }

    public IEnumerable<Accentuation> GetAll() => 
        _accentuations.ToList();

    public void Add(Accentuation accentuation)
    {
        _accentuations.Add(accentuation);
        Save();
    }

    public void Update(Accentuation accentuation)
    {
        if (!AccentuationExists(accentuation))
            Add(accentuation);
        
        var index = FindAccentuationIndex(accentuation);
        _accentuations[index] = accentuation;
    }


    public void Delete(string word)
    {
        var index = FindAccentuationIndex(word);
        _accentuations.RemoveAt(index);
        Save();
    }

    private void Save() => 
        _saver.SaveToFile(_accentuations, _savingLocation);

    private static bool WordsAreSame(string a, string b)
    {
        var clearedWord = RemoveApostrophe(a);
        var compareResult = string.Compare(b, clearedWord,
                   StringComparison.InvariantCultureIgnoreCase);
        return compareResult == 0;
    }

    private int FindAccentuationIndex(Accentuation accentuation) =>
        FindAccentuationIndex(accentuation.Word);

    private bool AccentuationExists(Accentuation accentuation) => 
        _accentuations.Any(x => 
            WordsAreSame(x.Word, accentuation.Word));

    private int FindAccentuationIndex(string word) =>
        _accentuations.FindIndex(x => 
            WordsAreSame(x.Word, word));

    private static string RemoveApostrophe(string word) =>
        word
            .Replace("'", "")
            .Replace("\u0027", "")
            .Replace("’","")
            .Replace("\u2019","");
}