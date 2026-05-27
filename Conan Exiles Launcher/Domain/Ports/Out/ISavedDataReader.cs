using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.Out
{
    public interface ISavedDataReader
    {
        public List<ImportResult> ReadSavedData();
    }
}
