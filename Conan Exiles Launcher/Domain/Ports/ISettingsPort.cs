using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports
{
    public interface ISettingsPort
    {
        public void SaveDirectories(SettingsData settingsData);
    }
}
