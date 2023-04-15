using System;
using System.IO;
using Syncfusion.Licensing;

namespace Flying_Beaver_IDE.Services
{
    internal static class SyncfusionActivator
    {
        private const string LicenceKey = "SyncfusionKey";

        public static void Activate()
        {
            var license = Environment.GetEnvironmentVariable(LicenceKey);
            if(license is null)
                return;
            
            SyncfusionLicenseProvider.RegisterLicense(license);
        }
    }
}