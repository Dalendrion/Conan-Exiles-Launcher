using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Properties;

namespace Conan_Exiles_Launcher.Adapters
{
    internal class InstalledModsAdapter : IInstalledModsPort
    {
        public List<ModData> GetInstalledMods()
        {
            string workshopContentPath = Settings.Default.SteamPath + Settings.Default.WorkshopContent;

            return Directory.GetDirectories(workshopContentPath)
                .Select(path => new DirectoryInfo(path))
                .Select(ModDataFromDirectoryPath)
                .ToList();
        }

        private ModData ModDataFromDirectoryPath(DirectoryInfo dirInfo)
        {
            FileInfo[] fileInfo = dirInfo.GetFiles();

            return new ModData()
            {
                FileName = fileInfo[0].Name,
                ID = dirInfo.Name
            };
        }
    }
}
