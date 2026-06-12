using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.Services;
using Conan_Exiles_Launcher.Domain.UseCases;
using Moq;

namespace Conan_Exiles_Launcher_Test.Domain.Services
{
    public class LaunchGameServiceTest
    {
        private readonly ILaunchGameUseCase _launchGameUseCase;

        private readonly Mock<IModlistWriterPort> _modlistWriterPort;
        private readonly Mock<IGameLauncherPort> _gameLauncherPort;

        public LaunchGameServiceTest()
        {
            _modlistWriterPort = new Mock<IModlistWriterPort>();
            _gameLauncherPort = new Mock<IGameLauncherPort>();
            _launchGameUseCase = new LaunchGameService(_modlistWriterPort.Object, _gameLauncherPort.Object);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task LaunchGame_LaunchesGame(Boolean battleEye)
        {
            // Arrange
            ServerData serverData = new ServerData()
            {
                Name = "Test Server",
                IPAddress = "1.2.3.4",
                Port = "5678",
                BattleEye = battleEye
            };
            List<ModData> modList = new List<ModData>
            {
                new ModData { FileName = "mod1.pak", ID = "0001" },
                new ModData { FileName = "mod2.pak", ID = "0002" }
            };
            ImportResult importResult = new ImportResult(new ServerData(), new List<ModData>());

            MockSequence sequence = new MockSequence();
            _modlistWriterPort.InSequence(sequence)
                .Setup(m => m.WriteModlist(
                    It.Is<List<ModData>>(mods => mods.Count == modList.Count
                                              && mods[0].FileName == modList[0].FileName
                                              && mods[0].ID == modList[0].ID
                                              && mods[1].FileName == modList[1].FileName
                                              && mods[1].ID == modList[1].ID)
                )).Verifiable();
            _gameLauncherPort.InSequence(sequence).Setup(g => g.LaunchGame(battleEye)).Verifiable();

            // Act
            await _launchGameUseCase.LaunchGame(importResult);

            // Assert
            _modlistWriterPort.Verify();
            _gameLauncherPort.Verify();
        }
    }
}
