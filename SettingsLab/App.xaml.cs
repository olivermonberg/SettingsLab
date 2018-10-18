using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SettingsLab
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (SettingsLab.Properties.Settings.Default.CallUpgrade)
            {
                SettingsLab.Properties.Settings.Default.Upgrade();
                SettingsLab.Properties.Settings.Default.CallUpgrade = false;
            }

        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            SettingsLab.Properties.Settings.Default.Save();
        }
    }
}
