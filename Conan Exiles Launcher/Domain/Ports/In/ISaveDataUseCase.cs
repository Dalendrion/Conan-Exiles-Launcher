using Conan_Exiles_Launcher.Domain.Model;

namespace Conan_Exiles_Launcher.Domain.Ports.In
{
    public interface ISaveDataUseCase
    {
        public Task SaveData(List<ImportResult> data);
    }
}
