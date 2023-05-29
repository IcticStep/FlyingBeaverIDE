using Domain;

namespace DataAccess;

public interface IAccentuationsRepository
{
    public int Count();
    public bool IsEmpty();
    public Accentuation? GetAccentuation(string word);
}