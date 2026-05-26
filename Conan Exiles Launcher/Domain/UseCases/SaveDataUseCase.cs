using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    public class SaveDataUseCase : ISaveDataUseCase
    {
        private readonly ISavedDataWriter _savedDataWriter;

        public SaveDataUseCase(ISavedDataWriter savedDataWriter)
        {
            _savedDataWriter = savedDataWriter;
        }

        public async Task SaveData(List<ImportResult> data)
        {
            _savedDataWriter.WriteSavedData(data);
        }
    }
}
