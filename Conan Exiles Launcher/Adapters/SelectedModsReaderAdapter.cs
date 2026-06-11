using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Adapters.Files;
using Conan_Exiles_Launcher.Properties;

namespace Conan_Exiles_Launcher.Adapters
{
    public class SelectedModsReaderAdapter : ISelectedModsReaderPort
    {
        public List<ModData> ReadSelectedMods()
        {
            List<ModData> selectedMods = new List<ModData>();
            FileLineProcessor processor = new SelectedModsFileLineProcessor(selectedMods);
            FileLineReader fileLineReader = new FileLineReader(processor);
            fileLineReader.ReadFile(Settings.Default.SteamPath + Settings.Default.ServermodlistPath);
            return selectedMods;
        }
    }

    internal class SelectedModsFileLineProcessor : FileLineProcessor
    {
        private readonly List<ModData> _selectedMods;

        public SelectedModsFileLineProcessor(List<ModData> selectedMods)
        {
            _selectedMods = selectedMods;
        }

        public void ProcessLine(string line)
        {
            if (!line.StartsWith("*"))
            {
                return;
            }

            string path = line.Replace("*", "");
            ModData modData = new ModData();
            modData.FileName = Path.GetFileName(line);
            modData.ID = Path.GetFileName(Path.GetDirectoryName(line));
            _selectedMods.Add(modData);
        }
    }
}
