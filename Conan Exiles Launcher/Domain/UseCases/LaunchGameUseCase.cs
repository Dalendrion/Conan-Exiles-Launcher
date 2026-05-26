using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public class LaunchGameUseCase : ILaunchGameUseCase
    {
        private readonly IGameLauncher _gameLauncher;

        public LaunchGameUseCase(IGameLauncher gameLauncher)
        {
            _gameLauncher = gameLauncher;
        }

        public async void LaunchGame(ServerData serverData)
        {
            _gameLauncher.LaunchGame(serverData.BattleEye);
        }
    }
}
