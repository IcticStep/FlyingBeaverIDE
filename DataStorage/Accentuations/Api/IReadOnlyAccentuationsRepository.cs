using Domain.Main;

namespace DataStorage.Accentuations.Api;

public interface IReadOnlyAccentuationsRepository
{
    public int Count();
    public bool IsEmpty();
    public Accentuation? GetAccentuationSyllable(string word);
    public IEnumerable<Accentuation> GetAll();
}