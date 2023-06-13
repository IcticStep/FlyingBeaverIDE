using Syncfusion.Licensing;

namespace FlyingBeaverIDE.UI.Services;

public class SyncfusionActivator
{
    private readonly ConfigurationProvider _configurationProvider = new();
    
    public void Activate()
    {
        var key = _configurationProvider.GetSyncfusionKey();
        if(string.IsNullOrEmpty(key))
            return;
        
        SyncfusionLicenseProvider.RegisterLicense(key);
    }
}