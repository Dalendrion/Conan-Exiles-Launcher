using Conan_Exiles_Launcher.Controllers.Dto;
using Conan_Exiles_Launcher.Controllers.Mappers;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Services;
using Conan_Exiles_Launcher.Domain.UseCases;
using System.ComponentModel;

namespace Conan_Exiles_Launcher.Controllers
{
    public partial class Launcher : Form
    {
        private readonly IImportLastPlayedServerUseCase _importLastPlayedServerUseCase;
        private readonly ISaveDataUseCase _saveDataUseCase;
        private readonly ILoadDataUseCase _loadDataUseCase;
        private readonly ILaunchGameUseCase _launchGameUseCase;

        private Action retry;

        private BindingList<ImportResultDto> savedData;

        private ImportResultDto? selectedItem;
        private ImportResultDto? SelectedServer
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                serverDataPanel.Enabled = value != null;

                ServerNameTextBox.Text = value?.Server.Name ?? "";
                ServerIPTextBox.Text = value?.IPAddress ?? "";
                ServerBattleEyeCheckBox.Checked = value?.Server.BattleEye ?? false;
            }
        }

        public Launcher(IImportLastPlayedServerUseCase importLastPlayedServerUseCase,
                        ISaveDataUseCase saveDataUseCase,
                        ILoadDataUseCase loadDataUseCase,
                        ILaunchGameUseCase launchGameUseCase)
        {
            _importLastPlayedServerUseCase = importLastPlayedServerUseCase ?? throw new ArgumentNullException(nameof(importLastPlayedServerUseCase));
            _saveDataUseCase = saveDataUseCase ?? throw new ArgumentNullException(nameof(saveDataUseCase));
            _loadDataUseCase = loadDataUseCase ?? throw new ArgumentNullException(nameof(loadDataUseCase));
            _launchGameUseCase = launchGameUseCase ?? throw new ArgumentNullException(nameof(launchGameUseCase));

            InitializeComponent();
        }

        private async void Launcher_Shown(object sender, EventArgs e)
        {
            try
            {
                UpdateServerList();
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
                ImportResultDto lastPlayedServer = ImportResultMapper.ToDto(await _importLastPlayedServerUseCase.ImportAsync());
                UpdateServerList();

                ImportResultDto? matchingSavedResult = savedData.FirstOrDefault(s => ServerDataDto.HasSameIpAddress(s.Server, lastPlayedServer.Server));
                if (matchingSavedResult != null)
                {
                    savedData.Remove(matchingSavedResult);
                }
                SelectedServer = lastPlayedServer;
                serverListBox.SelectedItem = lastPlayedServer;

                UpdateServerList();
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
            if (SelectedServer == null)
            {
                ShowErrorMessage("No Server Selected", "Select a server before trying to launch the game");
                return;
            }

            LaunchGameButton.Enabled = false;

            try
            {
                await _launchGameUseCase.LaunchGame(ImportResultMapper.FromDto(SelectedServer));
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
            SelectedServer = (ImportResultDto)serverListBox.SelectedItem;

            
        }

        private async void SaveServerButton_Click(object sender, EventArgs e)
        {
            if (SelectedServer == null) return;
            if (savedData == null) return;

            SaveServerButton.Enabled = false;

            try
            {
                SelectedServer.Server.Name = ServerNameTextBox.Text;
                SelectedServer.IPAddress = ServerIPTextBox.Text;
                SelectedServer.Server.BattleEye = ServerBattleEyeCheckBox.Checked;
                

                ImportResult r = await _saveDataUseCase.SaveServer(ImportResultMapper.FromDto(SelectedServer));
                ImportResultDto dto = ImportResultMapper.ToDto(r);
                if (savedData.ToList().Find(i => Guid.Equals(i.Guid, dto.Guid)) == null)
                {
                    savedData.Add(dto);
                }

                UpdateServerList();
                SelectedServer = dto;
                serverListBox.SelectedItem = dto;
            }
            catch (InvalidServerDataException ex)
            {
                ipAddressErrorProvider.SetError(ServerIPTextBox, ex.Message);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Failed to save server data", ex.Message);
                return;
            }
            finally
            {
                SaveServerButton.Enabled = true;
            }
        }

        private void ServerIPTextBox_TextChanged(object sender, EventArgs e)
        {
            ipAddressErrorProvider.Clear();
        }

        private void AddServerButton_Click(object sender, EventArgs e)
        {
            serverListBox.SelectedIndex = -1;
            SelectedServer = new ImportResultDto(new ServerDataDto { Name = "New Server" }, new List<ModDataDto>());

            serverDataPanel.Enabled = true;
        }

        private async void UpdateServerList()
        {
            List<ImportResultDto> importResultsDto = (await _loadDataUseCase.LoadAsync()).Select(ImportResultMapper.ToDto).ToList();
            importResultsDto.Sort((a, b) => string.Compare(a.Server.Name, b.Server.Name, StringComparison.Ordinal));
            savedData = new BindingList<ImportResultDto>(importResultsDto);

            serverListBox.DisplayMember = "ServerName";
            serverListBox.DataSource = savedData;
            serverListBox.SelectedItem = SelectedServer;
        }
    }
}
