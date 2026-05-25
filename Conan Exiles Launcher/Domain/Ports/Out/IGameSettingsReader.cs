using Conan_Exiles_Launcher.Adapters.Out.Dto;

namespace Conan_Exiles_Launcher.Domain.Ports.Out
{
    public interface IGameSettingsReader
    {
        GameSettingsData ReadGameSettings();
    }
}
