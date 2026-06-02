using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class LaunchGameService : ILaunchGameUseCase
    {
        private readonly IModlistWriterPort _modlistWriter;
        private readonly IGameLauncherPort _gameLauncher;

        public LaunchGameService(IModlistWriterPort modlistWriter, IGameLauncherPort gameLauncher)
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
