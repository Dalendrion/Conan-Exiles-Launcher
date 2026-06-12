using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.Services;
using Moq;

namespace Conan_Exiles_Launcher_Test.Domain.Services
{
    public class LoadDataServiceTest
    {
        private readonly LoadDataService _loadDataService;

        private readonly Mock<ISavedDataPort> _savedDataPort;

        public LoadDataServiceTest()
        {
            _savedDataPort = new Mock<ISavedDataPort>();
            _loadDataService = new LoadDataService(_savedDataPort.Object);
        }

        [Fact]
        public async Task LoadAsync_LoadsSavedData()
        {
            // Arrange
            List<ImportResult> expectedResults = new List<ImportResult>() {
                new ImportResult(
                    new ServerData
                    {
                        Name = "Test Server 1",
                        IPAddress = "4.3.2.1",
                        Port = "1234",
                        BattleEye = true
                    },
                    new List<ModData>()
                    {
                        new ModData { FileName = "mod1.pak", ID = "0001" },
                        new ModData { FileName = "mod2.pak", ID = "0002" }
                    }
                )
                {
                    Guid = Guid.NewGuid()
                },
                new ImportResult(
                    new ServerData
                    {
                        Name = "Test Server 2",
                        IPAddress = "5.6.7.8",
                        Port = "5678",
                        BattleEye = true
                    },
                    new List<ModData>()
                    {
                        new ModData { FileName = "mod1.pak", ID = "0001" },
                        new ModData { FileName = "mod3.pak", ID = "0003" },
                        new ModData { FileName = "mod4.pak", ID = "0004" }
                    }
                )
                {
                    Guid = Guid.NewGuid()
                }
            };

            _savedDataPort
                .Setup(x => x.GetAllImportResults())
                .Returns(expectedResults);

            // Act
            List<ImportResult> actualResults = await _loadDataService.LoadAsync();

            // Assert
            Assert.Equivalent(expectedResults, actualResults);
        }

    }
}
