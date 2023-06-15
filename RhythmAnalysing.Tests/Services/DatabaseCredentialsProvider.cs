using DataStorage;
using Microsoft.Extensions.Configuration;
using RhythmAnalysing.Tests.Tests.Components;

namespace RhythmAnalysing.Tests.Services;

public static class DatabaseCredentialsProvider
{
    private const string UserNameConfigKey = "UserName";
    private const string UserPasswordConfigKey = "UserPassword";
    private const string ConnectionStringConfigKey = "ConnectionString";

    public static readonly DataBaseCredentials DatabaseCredentials;
    
    static DatabaseCredentialsProvider()
    {
        var configuration = BuildAppConfig();
        DatabaseCredentials = GetDataBaseCredentials(configuration);
    }
    
    private static IConfigurationRoot BuildAppConfig() =>
        new ConfigurationBuilder()
            .AddUserSecrets<SetPreviousAccentuationTests>()
            .Build();
    
    private static DataBaseCredentials GetDataBaseCredentials(IConfiguration configuration) =>
        new(
            configuration[ConnectionStringConfigKey]!,
            configuration[UserNameConfigKey]!,
            configuration[UserPasswordConfigKey]!);
}