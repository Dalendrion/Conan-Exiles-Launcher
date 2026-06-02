using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports
{
    public interface ISavedDataWriterPort
    {
        public void WriteSavedData(List<ImportResult> data);
    }
}
