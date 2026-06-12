using Conan_Exiles_Launcher.Adapters.Dto;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class ImportLastServerService : IImportLastPlayedServerUseCase
    {
        private readonly IGameSettingsReaderPort _gameSettingsReaderPort;
        private readonly ISelectedModsReaderPort _selectedModsReaderPort;
        private readonly ISavedDataPort _savedDataPort;

        public ImportLastServerService(IGameSettingsReaderPort gameSettingsReaderPort, ISelectedModsReaderPort selectedModsReaderPort, ISavedDataPort savedDataPort)
        {
            _gameSettingsReaderPort = gameSettingsReaderPort;
            _selectedModsReaderPort = selectedModsReaderPort;
            _savedDataPort = savedDataPort;
        }

        public async Task<ImportResult> ImportAsync()
        {
            GameSettingsData gameSettings = _gameSettingsReaderPort.ReadGameSettings();
            List<ModData> selectedMods = _selectedModsReaderPort.ReadSelectedMods();
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
