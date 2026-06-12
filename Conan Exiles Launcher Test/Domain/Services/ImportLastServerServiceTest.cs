using Conan_Exiles_Launcher.Adapters.Dto;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.Services;
using Moq;

namespace Conan_Exiles_Launcher_Test.Domain.Services
{
    public class ImportLastServerServiceTest
    {
        private readonly ImportLastServerService _importLastServerService;

        private readonly Mock<IGameSettingsReaderPort> _gameSettingsReaderPort;
        private readonly Mock<ISelectedModsReaderPort> _selectedModsReaderPort;
        private readonly Mock<ISavedDataPort> _savedDataPort;

        public ImportLastServerServiceTest()
        {
            _gameSettingsReaderPort = new Mock<IGameSettingsReaderPort>();
            _selectedModsReaderPort = new Mock<ISelectedModsReaderPort>();
            _savedDataPort = new Mock<ISavedDataPort>();

            _importLastServerService = new ImportLastServerService(
                _gameSettingsReaderPort.Object,
                _selectedModsReaderPort.Object,
                _savedDataPort.Object
            );
        }

        [Fact]
        public async Task Import_WithoutFavorites_WithoutSavedData()
        {
            // Arrange
            List<ModData> expectedMods = new List<ModData>()
                {
                    new ModData() {
                        FileName = "mod1.pak",
                        ID = "123456"
                    },
                    new ModData() {
                        FileName = "mod2.pak",
                        ID = "654321"
                    }
                };
            
            ImportResult expectedResult = new ImportResult(
                new ServerData()
                {
                    Name = null,
                    IPAddress = "1.2.3.4",
                    Port = "1234",
                    BattleEye = false
                },
                expectedMods
            );

            GameSettingsData gameSettingsData = new GameSettingsData();
            gameSettingsData.LastServer.IPAddress = "1.2.3.4";
            gameSettingsData.LastServer.Port = "1234";

            _selectedModsReaderPort
                .Setup(x => x.ReadSelectedMods())
                .Returns(expectedMods);

            _gameSettingsReaderPort
                .Setup(x => x.ReadGameSettings())
                .Returns(gameSettingsData);

            _savedDataPort
                .Setup(x => x.GetAllImportResults())
                .Returns(new List<ImportResult>());

            // Act
            ImportResult importResult = await _importLastServerService.ImportAsync();

            // Assert
            _gameSettingsReaderPort.Verify(x => x.ReadGameSettings(), Times.Once);
            _selectedModsReaderPort.Verify(x => x.ReadSelectedMods(), Times.Once);
            _savedDataPort.Verify(x => x.SaveImportResult(It.IsAny<ImportResult>()), Times.Once);

            Assert.Equivalent(expectedMods, importResult.Mods);
            Assert.Equivalent(expectedResult.Server, importResult.Server);
            Assert.True(importResult.Guid.HasValue);
        }
    }
}
