using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.Out
{
    public interface ISavedDataWriter
    {
        public void WriteSavedData(List<ImportResult> data);
    }
}
