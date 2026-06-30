using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports
{
    public interface ISettingsPort
    {
        public void SaveSteamPath(string steamPath);
        public void SaveSavedDataPath(string savedDataPath);
    }
}
