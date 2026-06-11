namespace Conan_Exiles_Launcher.Domain.Model
{
    public record SettingsData
    {
        public string SteamPath { get; } = "";
        public string SavedDataPath { get; } = "";

        public SettingsData(string steamPath, string savedDataPath)
        {
            SteamPath = steamPath;
            SavedDataPath = savedDataPath;
        }
    }
}
