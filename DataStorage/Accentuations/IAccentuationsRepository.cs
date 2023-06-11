using Domain;

namespace DataStorage.Accentuations;

public interface IAccentuationsRepository
{
    public int Count();
    public bool IsEmpty();
    public Accentuation? GetAccentuationSyllable(string word);
    public IEnumerable<Accentuation> GetAll();
}