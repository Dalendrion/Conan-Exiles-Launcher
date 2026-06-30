using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface ISaveSteamPathUseCase
    {
        public Task Save(string steamPath);
    }
}
