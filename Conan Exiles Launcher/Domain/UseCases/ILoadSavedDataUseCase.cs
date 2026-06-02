using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface ILoadSavedDataUseCase
    {
        public Task<List<ImportResult>> LoadAsync();
    }
}
