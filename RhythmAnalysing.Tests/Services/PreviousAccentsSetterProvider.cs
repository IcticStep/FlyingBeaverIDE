using Microsoft.Extensions.Configuration;

namespace RhythmAnalysing.Tests.Services;

public static class PreviousAccentsSetterProvider
{
    private const string UserNameConfigKey = "UserName";
    private const string UserPasswordConfigKey = "UserPassword";
    private const string ConnectionStringConfigKey = "ConnectionString";
    
    private static readonly PreviousAccentsSetter _previousAccentsSetter;

    static PreviousAccentsSetterProvider()
    {
        var configuration = BuildAppConfig();
        _previousAccentsSetter = CreateAccentsAnalyzer(configuration);
    }
    
    public static PreviousAccentsSetter CreateAccentsAnalyzer() => 
        _previousAccentsSetter;

    private static IConfigurationRoot BuildAppConfig() =>
        new ConfigurationBuilder()
            .AddUserSecrets<SetPreviousAccentuationTests>()
            .Build();

    private static PreviousAccentsSetter CreateAccentsAnalyzer(IConfiguration configuration) =>
        new (new(
            configuration[ConnectionStringConfigKey]!,
            configuration[UserNameConfigKey]!,
            configuration[UserPasswordConfigKey]!));
}