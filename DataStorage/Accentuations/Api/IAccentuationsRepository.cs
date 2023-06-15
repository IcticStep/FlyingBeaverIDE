using Domain.Main;

namespace DataStorage.Accentuations.Api;

public interface IAccentuationsRepository : IReadOnlyAccentuationsRepository
{
    public void Add(Accentuation accentuation);
    public void Update(Accentuation accentuation);
    public void Delete(string word);
}