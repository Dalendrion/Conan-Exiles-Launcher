using Conan_Exiles_Launcher.Adapters.GameSettings;
using Conan_Exiles_Launcher.Core.Model;
using Conan_Exiles_Launcher.Core.Ports.GameSettings;
using System.Diagnostics;

namespace Conan_Exiles_Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\SteamLibrary\\steamapps\\common\\Conan Exiles\\ConanSandbox\\Binaries\\Win64\\ConanSandbox-Win64-Shipping.exe", "+continuesession");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IGameSettingsReader reader = new GameSettingsReader();
            GameSettingsData gameSettings = reader.ReadGameSettings();

            // TODO: Get mod data!!!

            Debug.WriteLine(gameSettings.LastServer.ToString());
            foreach (ServerData data in gameSettings.Favorites)
            {
                Debug.WriteLine(data.ToString());
            }
        }
    }
}
