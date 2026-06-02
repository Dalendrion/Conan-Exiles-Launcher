using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class SaveDataService : ISaveDataUseCase
    {
        private readonly ISavedDataWriterPort _savedDataWriter;

        public SaveDataService(ISavedDataWriterPort savedDataWriter)
        {
            _savedDataWriter = savedDataWriter;
        }

        public async Task SaveData(List<ImportResult> data)
        {
            _savedDataWriter.WriteSavedData(data);
        }
    }
}
