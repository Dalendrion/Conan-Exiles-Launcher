using Conan_Exiles_Launcher.Data;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.Out;
using System.Text.Json;

namespace Conan_Exiles_Launcher.Adapters.Out
{
    public class SavedDataWriter : ISavedDataWriter
    {
        public void WriteSavedData(List<ImportResult> data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                
            };
            string json = JsonSerializer.Serialize(data, options);
            string savedDataPath = Settings.Instance.SavedDataPath;
            string? dir = Path.GetDirectoryName(savedDataPath);
            if (dir == null || dir == "") {
                throw new Exception($"Invalid saved data path {savedDataPath}.");
            }
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.WriteAllText(savedDataPath, json);
        }
    }
}
