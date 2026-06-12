using System.Diagnostics;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Properties;

namespace Conan_Exiles_Launcher.Adapters
{
    public class GameLauncherAdapter : IGameLauncherPort
    {
        public void LaunchGame(bool battleEye)
        {
            if (battleEye)
            {
                Process.Start(Settings.Default.SteamPath + Settings.Default.SandboxBattleEyeExecutable);
            }
            else
            {
                Process.Start(Settings.Default.SteamPath + Settings.Default.SandboxExecutable);
            }
        }
    }
}
