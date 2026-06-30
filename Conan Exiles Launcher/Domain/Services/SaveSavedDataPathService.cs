using Conan_Exiles_Launcher.Domain.Exceptions;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class SaveSavedDataPathService : ISaveSavedDataPathUseCase
    {
        private readonly ISettingsPort _settingsPort;

        public SaveSavedDataPathService(ISettingsPort settingsPort)
        {
            _settingsPort = settingsPort;
        }

        public async Task Save(string savedDataPath)
        {
            Validate(savedDataPath);
            _settingsPort.SaveSavedDataPath(savedDataPath);
        }

        private void Validate(string savedDataPath)
        {
            if (!savedDataPath.EndsWith(".json"))
            {
                throw new InvalidSavedDataPathException();
            }
        }
    }
}
