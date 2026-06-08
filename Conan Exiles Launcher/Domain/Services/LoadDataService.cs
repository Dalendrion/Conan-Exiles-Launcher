using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class LoadDataService : ILoadDataUseCase
    {
        private readonly ISavedDataPort _savedDataPort;

        public LoadDataService(ISavedDataPort savedDataPort)
        {
            _savedDataPort = savedDataPort;
        }

        public async Task<List<ImportResult>> LoadAsync()
        {
            return _savedDataPort.GetAllImportResults();
        }
    }
}
