using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.Out
{
    public interface IModlistWriter
    {
        void WriteModlist(List<ModData> modlistData);
    }
}
