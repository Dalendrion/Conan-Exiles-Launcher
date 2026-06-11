using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Properties;

namespace Conan_Exiles_Launcher.Adapters
{
    public class ModlistWriterAdapter : IModlistWriterPort
    {
        public void WriteModlist(List<ModData> modlistData)
        {
            
            string mods = string.Join(Environment.NewLine, modlistData.Select(m => '*' + Path.Combine([Settings.Default.SteamPath + Settings.Default.WorkshopContent, m.ID, m.FileName])));
            string modlistPath = Settings.Default.SteamPath + Settings.Default.ModlistPath;
            ValidateOrCreateDir(modlistPath, () => new Exception($"Invalid modlist path {modlistPath}."));
            File.WriteAllText(modlistPath, mods);
        }

        private void ValidateOrCreateDir(string path, Func<Exception> createException)
        {
            string? dir = Path.GetDirectoryName(path);
            if (dir == null || dir == "")
            {
                throw createException();
            }
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
