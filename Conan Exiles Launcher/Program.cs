using Conan_Exiles_Launcher.Adapters;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.Services;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Controllers
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Launcher(
                createLoadSavedDataService(),
                createImportLastPlayedServerService(),
                createSaveDataService(),
                createLaunchGameService()
            ));
        }

        private static ILoadSavedDataUseCase createLoadSavedDataService()
        {
            ISavedDataReaderPort savedDataReader = new SavedDataReaderAdapter();
            return new LoadSavedDataService(savedDataReader);
        }

        private static IImportLastPlayedServerUseCase createImportLastPlayedServerService()
        {
            IGameSettingsReaderPort gameSettingsReader = new GameSettingsReaderAdapter();
            ISelectedModsReaderPort selectedModsReader = new SelectedModsReaderAdapter();
            return new ImportLastServerService(gameSettingsReader, selectedModsReader);
        }

        private static ISaveDataUseCase createSaveDataService()
        {
            ISavedDataWriterPort savedDataWriter = new SavedDataWriterAdapter();
            return new SaveDataService(savedDataWriter);
        }

        private static ILaunchGameUseCase createLaunchGameService()
        {
            IModlistWriterPort modlistWriter = new ModlistWriterAdapter();
            IGameLauncherPort gameLauncher = new GameLauncherAdapter();
            return new LaunchGameService(modlistWriter, gameLauncher);
        }
    }
}