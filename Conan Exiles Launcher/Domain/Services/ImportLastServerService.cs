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
        private readonly ISavedDataPort _savedDataPort;

        public ImportLastServerService(IGameSettingsReaderPort gameSettingsReader, ISelectedModsReaderPort selectedModsReader, ISavedDataPort savedDataPort)
        {
            _gameSettingsReader = gameSettingsReader;
            _selectedModsReader = selectedModsReader;
            _savedDataPort = savedDataPort;
        }

        public async Task<ImportResult> ImportAsync()
        {
            GameSettingsData gameSettings = _gameSettingsReader.ReadGameSettings();
            List<ModData> selectedMods = _selectedModsReader.ReadSelectedMods();
            ServerData lastServer = GetServerData(gameSettings);
            ImportResult importResult = FindOrCreateImportResult(lastServer, selectedMods);
            _savedDataPort.SaveImportResult(importResult);
            return importResult;
        }

        private ImportResult FindOrCreateImportResult(ServerData lastServer, List<ModData> selectedMods)
        {
            List<ImportResult> list = _savedDataPort.GetAllImportResults();
            ImportResult importResult = list.FirstOrDefault(i => ServerData.HasSameIpAddress(i.Server, lastServer)); // would be nice is this weren't nullable

            if (importResult == null)
            {
                importResult = new ImportResult(lastServer, selectedMods) { Guid = Guid.NewGuid() };
            }

            importResult.Mods = selectedMods;
            return importResult;
        }

        private ServerData GetServerData(GameSettingsData gameSettings)
        {
            ServerData lastServer = gameSettings.LastServer;
            ServerData? matchingFavorite = gameSettings.Favorites.FirstOrDefault(favorite => ServerData.HasSameIpAddress(favorite, lastServer));

            if (matchingFavorite != null)
            {
                lastServer.Name = matchingFavorite.Name;
            }

            return lastServer;
        }
    }
}
