using DataStorage;
using Microsoft.Extensions.Configuration;

namespace FlyingBeaverIDE.UI.Services.System;

public class ConfigurationProvider
{
    static ConfigurationProvider() =>
        _configuration = new ConfigurationBuilder()
            .AddUserSecrets<MainForm>()
            .Build();

    private const string LicenceKey = "SyncfusionKey";
    private const string UserNameConfigKey = "UserName";
    private const string UserPasswordConfigKey = "UserPassword";
    private const string ConnectionStringConfigKey = "ConnectionString";
    private const string LocalAccentuationsSavePath = "LocalAccentuationDictionaryPath";

    private static readonly IConfigurationRoot _configuration;

    public string? GetSyncfusionKey() => 
        _configuration[LicenceKey];

    public string? GetLocalAccentuationsSavePath =>
        AppDomain.CurrentDomain.BaseDirectory +
            _configuration[LocalAccentuationsSavePath];

    public DataBaseCredentials GetDataBaseCredentials() =>
        new(_configuration[ConnectionStringConfigKey]!,
            _configuration[UserNameConfigKey]!,
            _configuration[UserPasswordConfigKey]!);
}
