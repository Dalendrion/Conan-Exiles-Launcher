using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Properties;
using System.Text.Json;

namespace Conan_Exiles_Launcher.Adapters
{
    public class SavedDataAdapter : ISavedDataPort
    {
        List<ImportResult>? _savedData;

        public List<ImportResult> GetAllImportResults()
        {
            if (_savedData == null)
            {
                try
                {
                    string rawSavedData = File.ReadAllText(Settings.Default.SavedDataPath + Settings.Default.SavedDataFile);
                    _savedData = JsonSerializer.Deserialize<List<ImportResult>>(rawSavedData) ?? new List<ImportResult>();
                }
                catch (FileNotFoundException ex)
                {
                    _savedData = new List<ImportResult>();
                }
                catch (DirectoryNotFoundException ex)
                {
                    _savedData = new List<ImportResult>();
                }
            }

            return _savedData;
        }

        public ImportResult? GetImportResult(Guid guid)
        {
            List<ImportResult> savedData = GetAllImportResults();
            return savedData.FirstOrDefault(importResult => importResult.Guid == guid);
        }

        public void SaveImportResult(ImportResult importResult)
        {
            if (importResult.Guid == null)
            {
                importResult.Guid = Guid.NewGuid();
            }
            ImportResult? existingImportResult = GetImportResult(importResult.Guid.Value);
            if (existingImportResult != null)
            {
                _savedData.Remove(existingImportResult);
            }
            _savedData.Add(importResult);
            SaveAllImportResults(_savedData);
        }

        private void SaveAllImportResults(List<ImportResult> importResults)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            string json = JsonSerializer.Serialize(importResults, options);
            string savedDataPath = Settings.Default.SavedDataPath + Settings.Default.SavedDataFile;
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
