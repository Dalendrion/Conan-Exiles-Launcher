using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Properties;

namespace Conan_Exiles_Launcher.Adapters
{
    public class SettingsAdapter : ISettingsPort
    {
        public void SaveDirectories(SettingsData settingsData)
        {
            Settings.Default.SteamPath = settingsData.SteamPath;
            Settings.Default.SavedDataPath = settingsData.SavedDataPath;
            Settings.Default.Save();
        }
    }
}
