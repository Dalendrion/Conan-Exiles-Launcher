using Conan_Exiles_Launcher.Adapters.Out;
using Conan_Exiles_Launcher.Domain.Adapters;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.Ports.Out;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher
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

            Application.Run(new Launcher(createLoadSavedDataUseCase(), createImportLastPlayedServerUseCase()));
        }

        private static ILoadSavedDataUseCase createLoadSavedDataUseCase()
        {
            ISavedDataReader savedDataReader = new SavedDataReader();
            return new LoadSavedDataUseCase(savedDataReader);
        }

        private static IImportLastPlayedServerUseCase createImportLastPlayedServerUseCase()
        {
            IGameSettingsReader gameSettingsReader = new GameSettingsReader();
            ISelectedModsReader selectedModsReader = new SelectedModsReader();
            return new ImportLastServerUseCase(gameSettingsReader, selectedModsReader);
        }
    }
}