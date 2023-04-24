using Syncfusion.Licensing;
using Microsoft.Extensions.Configuration;

namespace FlyingBeaverIDE.UI.Services;

public static class SyncfusionActivator
{
    private const string LicenceKey = "SyncfusionKey";

    public static void Activate()
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<MainForm>()
            .Build();

        var key = config[LicenceKey];
        if(string.IsNullOrEmpty(key))
            return;
        
        SyncfusionLicenseProvider.RegisterLicense(key);
    }
}