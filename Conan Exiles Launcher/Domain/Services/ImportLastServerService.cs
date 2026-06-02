using Conan_Exiles_Launcher.Adapters.Dto;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    internal class ImportLastServerService : IImportLastPlayedServerUseCase
    {
        private readonly IGameSettingsReaderPort _gameSettingsReader;
        private readonly ISelectedModsReaderPort _selectedModsReader;

        public ImportLastServerService(IGameSettingsReaderPort gameSettingsReader, ISelectedModsReaderPort selectedModsReader)
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
            ServerData? matchingFavorite = gameSettings.Favorites.FirstOrDefault(favorite => ServerData.Equals(favorite, lastServer));

            if (matchingFavorite != null)
            {
                lastServer.Name = matchingFavorite.Name;
            }

            return lastServer;
        }
    }
}
