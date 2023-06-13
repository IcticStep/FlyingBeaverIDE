using DataStorage;
using DataStorage.Accentuations;

namespace FlyingBeaverIDE.Logic.Services;

public class AccentuationRepositoryProvider
{
    public static AccentuationsRepository Create(DataBaseCredentials dataBaseCredentials,
        string? localRepositorySavePath)
    {
        var remoteRepository = new AccentuationsRemoteRepository(dataBaseCredentials);
        var localRepository = new AccentuationsLocalRepository(localRepositorySavePath);
        return new(remoteRepository, localRepository);
    }
}