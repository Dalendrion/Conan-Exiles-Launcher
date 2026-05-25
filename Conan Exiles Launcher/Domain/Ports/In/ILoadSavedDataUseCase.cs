using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.In
{
    public interface ILoadSavedDataUseCase
    {
        public Task<List<ImportResult>> LoadAsync();
    }
}
