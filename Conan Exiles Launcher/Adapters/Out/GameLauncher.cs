using Conan_Exiles_Launcher.Data;
using System.Diagnostics;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Adapters.Out
{
    internal class GameLauncher : IGameLauncher
    {
        public void LaunchGame(bool battleEye)
        {
            if (battleEye)
            {
                Process.Start(Settings.Instance.BattleEyeExecutablePath);
            }
            else
            {
                Process.Start(Settings.Instance.SandboxExecutablePath);
            }
        }
    }
}
