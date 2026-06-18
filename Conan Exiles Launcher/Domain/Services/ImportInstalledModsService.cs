using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Domain.Services
{
    public class ImportInstalledModsService : IImportInstalledModsUseCase
    {
        private readonly IInstalledModsPort _installedModsPort;

        public ImportInstalledModsService(IInstalledModsPort installedModsPort)
        {
            _installedModsPort = installedModsPort;
        }

        public async Task<List<ModData>> GetInstalledMods()
        {
            return _installedModsPort.GetInstalledMods();
        }
    }
}
