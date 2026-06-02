using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports
{
    public interface IModlistWriterPort
    {
        void WriteModlist(List<ModData> modlistData);
    }
}
