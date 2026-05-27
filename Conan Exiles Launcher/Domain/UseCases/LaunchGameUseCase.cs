using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public class LaunchGameUseCase : ILaunchGameUseCase
    {
        private readonly IModlistWriter _modlistWriter;
        private readonly IGameLauncher _gameLauncher;

        public LaunchGameUseCase(IModlistWriter modlistWriter, IGameLauncher gameLauncher)
        {
            _modlistWriter = modlistWriter;
            _gameLauncher = gameLauncher;
        }

        public async Task LaunchGame(ImportResult importResult)
        {
            _modlistWriter.WriteModlist(importResult.Mods);
            _gameLauncher.LaunchGame(importResult.Server.BattleEye);
        }
    }
}
