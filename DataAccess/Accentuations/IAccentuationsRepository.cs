using Domain;

namespace DataAccess.Accentuations;

public interface IAccentuationsRepository
{
    public int Count();
    public bool IsEmpty();
    public Accentuation? GetAccentuation(string word);
}