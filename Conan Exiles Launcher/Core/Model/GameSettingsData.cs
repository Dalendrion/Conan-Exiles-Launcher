namespace Conan_Exiles_Launcher.Core.Model
{
    public class GameSettingsData
    {
        private ServerData _lastServer = new ServerData();
        private List<ServerData> _favorites = new List<ServerData>();

        public ServerData LastServer { get { return _lastServer; } }

        public List<ServerData> Favorites { get { return _favorites; } }
    }
}
