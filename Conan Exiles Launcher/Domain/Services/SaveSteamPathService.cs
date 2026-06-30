using Conan_Exiles_Launcher.Domain.Exceptions;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class SaveSteamPathService : ISaveSteamPathUseCase
    {
        private readonly ISettingsPort _settingsPort;

        public SaveSteamPathService(ISettingsPort settingsPort)
        {
            _settingsPort = settingsPort;
        }

        public async Task Save(string steamPath)
        {
            Validate(steamPath);
            _settingsPort.SaveSteamPath(steamPath);
        }

        public void Validate(string steamPath)
        {
            if (!steamPath.EndsWith("SteamLibrary"))
            {
                throw new InvalidSteamPathException();
            }
        }
    }
}
