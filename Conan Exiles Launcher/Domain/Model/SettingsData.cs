namespace Conan_Exiles_Launcher.Domain.Model
{
    public record SettingsData
    {
        public string SteamPath { init; get; }
        public string SavedDataPath { init; get; }

        public SettingsData(string steamPath, string savedDataPath)
        {
            SteamPath = steamPath;
            SavedDataPath = savedDataPath;
        }
    }
}
