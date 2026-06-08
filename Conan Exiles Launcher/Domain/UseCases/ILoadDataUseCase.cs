using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface ILoadDataUseCase
    {
        public Task<List<ImportResult>> LoadAsync();
    }
}
