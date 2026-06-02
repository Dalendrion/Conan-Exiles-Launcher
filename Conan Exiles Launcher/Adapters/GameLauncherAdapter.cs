using Conan_Exiles_Launcher.Data;
using System.Diagnostics;
using Conan_Exiles_Launcher.Domain.Ports;

namespace Conan_Exiles_Launcher.Adapters
{
    internal class GameLauncherAdapter : IGameLauncherPort
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
