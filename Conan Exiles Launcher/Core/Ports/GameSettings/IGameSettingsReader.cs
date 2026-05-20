using Conan_Exiles_Launcher.Core.Model;

namespace Conan_Exiles_Launcher.Core.Ports.GameSettings
{
    internal interface IGameSettingsReader
    {
        GameSettingsData ReadGameSettings();
    }
}
