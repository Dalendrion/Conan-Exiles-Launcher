using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.Out
{
    public interface ISelectedModsReader
    {
        public List<ModData> ReadSelectedMods();
    }
}
