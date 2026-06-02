using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.UseCases;
using System.Diagnostics;

namespace Conan_Exiles_Launcher.Controllers
{
    public partial class Launcher : Form
    {
        private readonly ILoadSavedDataUseCase _loadSavedDataUseCase;
        private readonly IImportLastPlayedServerUseCase _importLastPlayedServerUseCase;
        private readonly ISaveDataUseCase _saveDataUseCase;
        private readonly ILaunchGameUseCase _launchGameUseCase;

        private Action retry;

        private List<ImportResult?> savedData;
        private ImportResult? lastPlayedServer;
        private ImportResult? selectedServer;

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

        private async void Launcher_Shown(object sender, EventArgs e)
        {
            try
            {
                savedData = await _loadSavedDataUseCase.LoadAsync();

                serverListBox.DisplayMember = "ServerName";
                serverListBox.DataSource = savedData;

                foreach (ImportResult? i in savedData)
                {
                    Debug.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to load saved data", ex.Message);
                retry = () => Launcher_Shown(sender, e);
            }
        }

        private async void ImportServerAndModlistButton_Click(object sender, EventArgs e)
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
                List<ImportResult> filteredData = (List<ImportResult>) savedData.FindAll(x => x != null);
                filteredData.Sort((a, b) => string.Compare(a.Server.Name, b.Server.Name, StringComparison.Ordinal));
                await _saveDataUseCase.SaveData(filteredData);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to import game data", ex.Message, true);
                retry = () => ImportServerAndModlistButton_Click(sender, e);
            }
            finally
            {
                ImportServerAndModlistButton.Enabled = true;
            }
        }

        private void btnRetry_ButtonClick(object sender, EventArgs e)
        {
            ResetErrorMessage();
            retry.Invoke();
        }

        private async void LaunchGameButton_Click(object sender, EventArgs e)
        {
            if (selectedServer == null)
            {
                ShowErrorMessage("No Server Selected", "Select a server before trying to launch the game");
                return;
            }

            LaunchGameButton.Enabled = false;

            try
            {
                await _launchGameUseCase.LaunchGame(selectedServer);
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serverListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImportResult? selectedItem = (ImportResult) serverListBox.SelectedItem;

            ServerNameTextBox.Enabled = selectedItem != null;
            ServerIPTextBox.Enabled = selectedItem != null;
            ServerBattleEyeCheckBox.Enabled = selectedItem != null;
            LaunchGameButton.Enabled = selectedItem != null;

            ServerNameTextBox.Text = selectedItem?.Server.Name ?? "";
            ServerIPTextBox.Text = selectedItem?.IPAddress ?? "";
            ServerBattleEyeCheckBox.Checked = selectedItem?.Server.BattleEye ?? false;
        }
    }
}
