using Conan_Exiles_Launcher.Data;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using System.Text.Json;

namespace Conan_Exiles_Launcher.Adapters
{
    public class SavedDataWriterAdapter : ISavedDataWriterPort
    {
        public void WriteSavedData(List<ImportResult> data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                
            };
            string json = JsonSerializer.Serialize(data, options);
            string savedDataPath = Settings.Instance.SavedDataPath;
            ValidateOrCreateDir(savedDataPath, () => new Exception($"Invalid saved data path {savedDataPath}."));
            File.WriteAllText(savedDataPath, json);
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
