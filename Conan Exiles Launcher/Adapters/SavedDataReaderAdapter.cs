using Conan_Exiles_Launcher.Data;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using System.Text.Json;

namespace Conan_Exiles_Launcher.Adapters
{
    public class SavedDataReaderAdapter : ISavedDataReaderPort
    {
        public List<ImportResult> ReadSavedData()
        {
            List<ImportResult> savedData;
            
            try
            {
                string rawSavedData = File.ReadAllText(Settings.Instance.SavedDataPath);
                savedData = JsonSerializer.Deserialize<List<ImportResult>>(rawSavedData) ?? new List<ImportResult>();
            }
            catch (FileNotFoundException)
            {
                savedData = new List<ImportResult>();
            }
            catch (DirectoryNotFoundException)
            {
                savedData = new List<ImportResult>();
            }

            return savedData;
        }
    }
}
