using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.Ports.Out;

namespace Conan_Exiles_Launcher.Domain.UseCases
{
    internal class LoadSavedDataUseCase : ILoadSavedDataUseCase
    {
        private readonly ISavedDataReader _savedDataReader;

        public LoadSavedDataUseCase(ISavedDataReader savedDataReader)
        {
            _savedDataReader = savedDataReader;
        }

        public async Task<List<ImportResult>> LoadAsync()
        {
            return _savedDataReader.ReadSavedData();
        }
    }
}
