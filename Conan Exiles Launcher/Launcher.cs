using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using System.Diagnostics;

namespace Conan_Exiles_Launcher
{
    public partial class Launcher : Form
    {
        private readonly ILoadSavedDataUseCase _loadSavedDataUseCase;
        private readonly IImportLastPlayedServerUseCase _importLastPlayedServerUseCase;
        private readonly ISaveDataUseCase _saveDataUseCase;
        private readonly ILaunchGameUseCase _launchGameUseCase;

        private Action retry;

        private List<ImportResult> savedData;
        private ImportResult? lastPlayedServer;

        public Launcher(ILoadSavedDataUseCase loadSavedDataUseCase,
                        IImportLastPlayedServerUseCase importLastPlayedServerUseCase,
                        ISaveDataUseCase saveDataUseCase,
                        ILaunchGameUseCase launchGameUseCase)
        {
            _loadSavedDataUseCase = loadSavedDataUseCase ?? throw new ArgumentNullException(nameof(loadSavedDataUseCase));
            _importLastPlayedServerUseCase = importLastPlayedServerUseCase ?? throw new ArgumentNullException(nameof(importLastPlayedServerUseCase));
            _saveDataUseCase = saveDataUseCase ?? throw new ArgumentNullException(nameof(saveDataUseCase));
            _launchGameUseCase = launchGameUseCase ?? throw new ArgumentNullException(nameof(launchGameUseCase));

            InitializeComponent();
        }

        private void Launcher_Shown(object sender, EventArgs e)
        {
            try
            {
                savedData = _loadSavedDataUseCase.LoadAsync().Result;

                foreach (ImportResult result in savedData)
                {
                    Debug.WriteLine($"Saved Data: {result}");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to load saved data", ex.Message);
                retry = () => Launcher_Shown(sender, e);
            }
        }

        private async void ImportServerAndModsButton_Click(object sender, EventArgs e)
        {
            ImportServerAndModlistButton.Enabled = false;

            try
            {
                lastPlayedServer = await _importLastPlayedServerUseCase.ImportAsync();
                ImportResult? matchingSavedResult = savedData.FirstOrDefault(s => ServerData.Equals(s.Server, lastPlayedServer.Server));
                if (matchingSavedResult != null)
                {
                    savedData.Remove(matchingSavedResult);
                }
                matchingSavedResult = lastPlayedServer;
                savedData.Add(lastPlayedServer);
                savedData.Sort((a, b) => string.Compare(a.Server.Name, b.Server.Name, StringComparison.Ordinal));
                SaveData();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to import game data", ex.Message, true);
                retry = () => ImportServerAndModsButton_Click(sender, e);
            }
            finally
            {
                ImportServerAndModlistButton.Enabled = true;
            }
        }

        private void btnRetry_ButtonClick(object sender, EventArgs e)
        {
            ResetErrorMessage();
            Debug.WriteLine("Retrying...");
            retry.Invoke();
        }

        private async void LaunchGameButton_Click(object sender, EventArgs e)
        {
            if (lastPlayedServer == null) {
                ShowErrorMessage("No Server Selected", null);
                return;
            }

            LaunchGameButton.Enabled = false;

            try
            {
                _launchGameUseCase.LaunchGame(savedData.Last().Server);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to launch game", ex.Message);
            }
            finally
            {
                LaunchGameButton.Enabled = true;
            }
        }

        private async void SaveData()
        {
            try
            {
                _saveDataUseCase.SaveData(savedData).Wait();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to save data", ex.Message);
            }
        }

        private void ShowErrorMessage(string message, string info, Boolean retry = false)
        {
            toolStripStatusLabel1.ForeColor = Color.DarkRed;
            toolStripStatusLabel1.Image = SystemIcons.Error.ToBitmap();
            toolStripStatusLabel1.Text = message;
            toolStripStatusLabel1.ToolTipText = info;
            btnRetry.Visible = retry;
        }

        private void ResetErrorMessage()
        {
            toolStripStatusLabel1.ForeColor = SystemColors.ControlText;
            toolStripStatusLabel1.Image = null;
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel1.ToolTipText = "";
            btnRetry.Visible = false;
        }
    }
}
