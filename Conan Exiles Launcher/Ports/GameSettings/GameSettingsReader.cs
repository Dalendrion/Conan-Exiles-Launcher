using Conan_Exiles_Launcher.Core.Adapters.Files;
using Conan_Exiles_Launcher.Core.Adapters.GameSettings;
using Conan_Exiles_Launcher.Data;

namespace Conan_Exiles_Launcher.Ports.GameSettings
{
    public class GameSettingsReader : IGameSettingsReader
    {
        public GameSettingsData ReadGameSettings()
        {
            GameSettingsData gameSettings = new GameSettingsData();
            FileLineProcessor lineProcessor = new MyFileLineProcessor(gameSettings);
            FileLineReader fileLineReader = new FileLineReader(new MyFileLineProcessor(gameSettings));
            fileLineReader.ReadFile(Settings.Instance.GameIniPath);
            return gameSettings;
        }
    }

    internal class MyFileLineProcessor : FileLineProcessor
    {
        private readonly GameSettingsData _gameSettings;
        private State state = State.None;

        private enum State
        {
            None = 0,
            ReadLastServer = 1,
            ReadFavorites = 2
        }

        internal MyFileLineProcessor(GameSettingsData gameSettings)
        {
            _gameSettings = gameSettings;
        }

        public void ProcessLine(string line)
        {
            if (line.StartsWith("[SavedServers]"))
            {
                state = State.ReadLastServer;
            }
            else if (line.StartsWith("[FavoriteServers]"))
            {
                state = State.ReadFavorites;
            }
            else
            {
                ParseLine(line);
            }
        }

        private void ParseLine(string line)
        {
            switch (state)
            {
                case State.ReadLastServer:
                    ParseSavedServer(line);
                    break;
                case State.ReadFavorites:
                    ParseFavorite(line);
                    break;
            }
        }

        private void ParseSavedServer(string line)
        {
            string[] splitLine = line.Split("=");
            switch (splitLine[0])
            {
                case "LastConnected":
                    string[] ipAndPort = splitLine[1].Split(":");
                    _gameSettings.LastServer.IPAddress = ipAndPort[0];
                    _gameSettings.LastServer.Port = ipAndPort[1];
                    break;
                case "LastPassword":
                    _gameSettings.LastServer.Password = splitLine[1];
                    break;
            }
        }

        private void ParseFavorite(string line)
        {
            string[] splitLine = line.Split("=", 2);
            switch (splitLine[0])
            {
                case "ServerList":
                    ServerData faveServer = new ServerData();
                    // remove parentheses
                    string properties = splitLine[1];
                    properties = properties.Replace("(", "").Replace(")", "");
                    foreach (string property in properties.Split(","))
                    {
                        ParseFavoriteProperty(property, faveServer);
                    }
                    _gameSettings.Favorites.Add(faveServer);
                    break;
            }
        }

        private void ParseFavoriteProperty(string line, ServerData faveServer)
        {
            string[] splitLine = line.Split("=");
            switch (splitLine[0])
            {
                case "ServerName":
                    faveServer.Name = splitLine[1];
                    break;
                case "ipAddress":
                    faveServer.IPAddress = splitLine[1];
                    break;
                case "Port":
                    faveServer.Port = splitLine[1];
                    break;
                case "UID":
                    faveServer.UID = splitLine[1];
                    break;
            }
        }
    }
}