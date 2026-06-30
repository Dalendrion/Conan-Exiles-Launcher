using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Properties;

namespace Conan_Exiles_Launcher.Adapters
{
    public class SettingsAdapter : ISettingsPort
    {
        public void SaveSteamPath(string steamPath)
        {
            Settings.Default.SteamPath = steamPath;
            Settings.Default.Save();
        }


        public void SaveSavedDataPath(string savedDataPath)
        {
            Settings.Default.SavedDataPath = savedDataPath;
            Settings.Default.Save();
        }
    }
}
