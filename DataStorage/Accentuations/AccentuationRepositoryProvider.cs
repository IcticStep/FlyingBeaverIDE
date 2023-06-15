using DataStorage.Accentuations.Api;

namespace DataStorage.Accentuations;

public static class AccentuationRepositoryProvider
{
    private static IReadOnlyAccentuationsRepository? _remote;
    private static IAccentuationsRepository? _local;

    public static IReadOnlyAccentuationsRepository? Remote => _remote;
    public static IAccentuationsRepository? Local => _local;

    public static AccentuationsRepository Create(DataBaseCredentials dataBaseCredentials,
        string? localRepositorySavePath)
    {
        _remote ??= new AccentuationsRemoteRepository(dataBaseCredentials);
        _local ??= new AccentuationsLocalRepository(localRepositorySavePath);
        
        return new(_remote, _local);
    }
}