using Conan_Exiles_Launcher.Adapters.Out.Dto;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Domain.Adapters
{
    internal class ImportLastServerUseCase : IImportLastPlayedServerUseCase
    {
        private readonly IGameSettingsReader _gameSettingsReader;
        private readonly ISelectedModsReader _selectedModsReader;

        public ImportLastServerUseCase(IGameSettingsReader gameSettingsReader, ISelectedModsReader selectedModsReader)
        {
            _gameSettingsReader = gameSettingsReader;
            _selectedModsReader = selectedModsReader;
        }

        public async Task<ImportResult> ImportAsync()
        {
            GameSettingsData gameSettings = _gameSettingsReader.ReadGameSettings();
            List<ModData> selectedMods = _selectedModsReader.ReadSelectedMods();

            ServerData lastServer = getServerData(gameSettings);

            return new ImportResult(gameSettings.LastServer, selectedMods);
        }

        private ServerData getServerData(GameSettingsData gameSettings)
        {
            ServerData lastServer = gameSettings.LastServer;
            ServerData? matchingFavorite = gameSettings.Favorites.FirstOrDefault(favorite =>
                string.Equals(favorite.IPAddress, lastServer.IPAddress) &&
                string.Equals(favorite.Port, lastServer.Port)
            );

            if (matchingFavorite != null)
            {
                lastServer.Name = matchingFavorite.Name;
            }

            return lastServer;
        }
    }
}
