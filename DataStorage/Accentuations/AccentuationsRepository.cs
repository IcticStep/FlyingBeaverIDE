using DataStorage.Accentuations.Api;
using Domain.Main;

namespace DataStorage.Accentuations;

public class AccentuationsRepository : IAccentuationsRepository
{
    public AccentuationsRepository(IReadOnlyAccentuationsRepository remote, IAccentuationsRepository local)
    {
        _remote = remote;
        _local = local;
    }

    private readonly IReadOnlyAccentuationsRepository _remote;
    private readonly IAccentuationsRepository _local;

    public int Count() => 
        _remote.Count() + _local.Count();

    public bool IsEmpty() => 
        _remote.IsEmpty() && _local.IsEmpty();

    public Accentuation? GetAccentuationSyllable(string word)
    {
        var remoteResult = _remote.GetAccentuationSyllable(word);
        var localResult = _local.GetAccentuationSyllable(word);
        return Accentuation.Combine(remoteResult, localResult);
    }

    public IEnumerable<Accentuation> GetAll() =>
        _remote
            .GetAll()
            .Concat(_local.GetAll());

    public void Add(Accentuation accentuation) =>
        _local.Add(accentuation);

    public void Update(Accentuation accentuation) =>
        _local.Update(accentuation);

    public void Delete(string word) => 
        _local.Delete(word);
}