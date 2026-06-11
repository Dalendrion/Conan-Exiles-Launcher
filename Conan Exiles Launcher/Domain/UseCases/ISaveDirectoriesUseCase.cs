using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface ISaveDirectoriesUseCase
    {
        public Task SaveDirectories(SettingsData settingsData);
    }
}
