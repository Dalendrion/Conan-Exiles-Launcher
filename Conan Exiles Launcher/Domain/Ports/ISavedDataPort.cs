using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports
{
    public interface ISavedDataPort
    {
        public ImportResult? GetImportResult(Guid guid);
        public void SaveImportResult(ImportResult importResult);
        public List<ImportResult> GetAllImportResults();
    }
}
