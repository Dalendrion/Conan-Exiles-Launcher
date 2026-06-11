using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class SaveDirectoriesService : ISaveDirectoriesUseCase
    {
        private readonly ISettingsPort _settingsPort;

        public SaveDirectoriesService(ISettingsPort settingsPort)
        {
            _settingsPort = settingsPort;
        }

        public async Task SaveDirectories(SettingsData settingsData)
        {
            _settingsPort.SaveDirectories(settingsData);
        }
    }
}
