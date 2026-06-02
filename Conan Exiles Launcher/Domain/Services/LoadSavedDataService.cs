using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    internal class LoadSavedDataService : ILoadSavedDataUseCase
    {
        private readonly ISavedDataReaderPort _savedDataReader;

        public LoadSavedDataService(ISavedDataReaderPort savedDataReader)
        {
            _savedDataReader = savedDataReader;
        }

        public async Task<List<ImportResult>> LoadAsync()
        {
            return _savedDataReader.ReadSavedData();
        }
    }
}
