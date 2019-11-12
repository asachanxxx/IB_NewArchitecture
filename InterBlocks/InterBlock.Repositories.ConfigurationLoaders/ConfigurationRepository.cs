using Interblocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Repositories.ConfigurationLoaders
{
    public sealed class ConfigurationRepository
    {
        private static Interblocks.IBConfigurationControl ibccSettings;

        public static string ConfigPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\SystemConfiguration.cnf");
        public static string SystemKeyPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\SystemConfiguration.key");
        public static string SysKey;

        //Log Configuration
        public static string LogSysConfigPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\StatementDataServiceLogConfiguration.cnf");
        public static string LogKeyPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\StatementDataServiceLogConfiguration.key");
        public static string LogKey;
        private ConfigurationRepository() {}
        public static void InitializeConfigurations()
        {
         
            //System Configuration
            IBKeyStore oStore = new IBKeyStore();
            SysKey = oStore.GetMasterKey(SystemKeyPath);
            SystemConfiguration.Initialize(SysKey, ConfigPath);

            ibccSettings = new IBConfigurationControl();
            ibccSettings.SetConfigurationFile(ConfigPath, SysKey);
            ibccSettings.OnSaveEvent += ibccSettings_OnSaveEvent;

        }


        public static void ibccSettings_OnSaveEvent(bool bSuccess)
        {
           
        }

        public static void SaveConfigurations()
        {
            SystemConfiguration.Save();
        }



    }
}
