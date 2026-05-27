using Conan_Exiles_Launcher.Data;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Adapters.Out
{
    public class ModlistWriter : IModlistWriter
    {
        public void WriteModlist(List<ModData> modlistData)
        {
            
            string mods = string.Join(Environment.NewLine, modlistData.Select(m => '*' + Path.Combine([Settings.Instance.WorkshopContentPath, m.ID, m.FileName])));
            string modlistPath = Settings.Instance.ModlistPath;
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
