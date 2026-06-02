using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Data;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Adapters.Dto;
using Conan_Exiles_Launcher.Adapters.Dto.Files;

namespace Conan_Exiles_Launcher.Adapters
{
    public class GameSettingsReaderAdapter : IGameSettingsReaderPort
    {
        public GameSettingsData ReadGameSettings()
        {
            GameSettingsData gameSettings = new GameSettingsData();
            FileLineProcessor lineProcessor = new GameIniFileLineProcessor(gameSettings);
            FileLineReader fileLineReader = new FileLineReader(lineProcessor);
            fileLineReader.ReadFile(Settings.Instance.GameIniPath);
            return gameSettings;
        }
    }

    internal class GameIniFileLineProcessor : FileLineProcessor
    {
        private readonly GameSettingsData _gameSettings;
        private State state = State.None;

        private enum State
        {
            None = 0,
            ReadLastServer = 1,
            ReadFavorites = 2
        }

        internal GameIniFileLineProcessor(GameSettingsData gameSettings)
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
            string key = splitLine[0];
            string value = splitLine[1];
            value = value.Trim('"');
            switch (key)
            {
                case "ServerName":
                    faveServer.Name = value;
                    break;
                case "ipAddress":
                    faveServer.IPAddress = value;
                    break;
                case "Port":
                    faveServer.Port = value;
                    break;
            }
        }
    }
}