using Conan_Exiles_Launcher.Adapters.Dto;

namespace Conan_Exiles_Launcher.Domain.Ports
{
    public interface IGameSettingsReaderPort
    {
        GameSettingsData ReadGameSettings();
    }
}
