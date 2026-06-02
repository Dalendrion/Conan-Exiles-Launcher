using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public interface ISaveDataUseCase
    {
        public Task SaveData(List<ImportResult> data);
    }
}
