using Conan_Exiles_Launcher.Adapters;
using Conan_Exiles_Launcher.Domain.Ports;
using Conan_Exiles_Launcher.Domain.Services;
using Conan_Exiles_Launcher.Domain.UseCases;

namespace Conan_Exiles_Launcher.Controllers
{
    internal static class Program
    {
        private static ISavedDataPort SavedDataPort { get; } = new SavedDataAdapter();
        private static IInstalledModsPort InstalledModsPort { get; } = new InstalledModsAdapter();
        private static IGameSettingsReaderPort GameSettingsReader { get; } = new GameSettingsReaderAdapter();
        private static ISelectedModsReaderPort SelectedModsReader { get; } = new SelectedModsReaderAdapter();
        private static IModlistWriterPort ModlistWriter { get; } = new ModlistWriterAdapter();
        private static IGameLauncherPort GameLauncher { get; } = new GameLauncherAdapter();
        private static ISettingsPort SettingsPort { get; } = new SettingsAdapter();

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
                new ImportLastServerService(GameSettingsReader, SelectedModsReader, SavedDataPort),
                new ImportInstalledModsService(InstalledModsPort),
                new SaveDataService(SavedDataPort),
                new LoadDataService(SavedDataPort),
                new LaunchGameService(ModlistWriter, GameLauncher),
                new SaveSteamPathService(SettingsPort),
                new SaveSavedDataPathService(SettingsPort)
            ));
        }
    }
}