using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Adapters.Dto
{
    public class GameSettingsData
    {
        public ServerData LastServer { get; } = new ServerData();

        public List<ServerData> Favorites { get; } = new List<ServerData>();
    }
}
