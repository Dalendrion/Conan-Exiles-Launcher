using Conan_Exiles_Launcher.Controllers.Dto;
using Conan_Exiles_Launcher.Controllers.Mappers;
using Conan_Exiles_Launcher.Domain.Exceptions;
using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Services;
using Conan_Exiles_Launcher.Domain.UseCases;
using Conan_Exiles_Launcher.Properties;
using System.ComponentModel;

namespace Conan_Exiles_Launcher.Controllers
{
    public partial class Launcher : Form
    {
        private readonly IImportLastPlayedServerUseCase _importLastPlayedServerUseCase;
        private readonly IImportInstalledModsUseCase _importInstalledModsUseCase;
        private readonly ISaveDataUseCase _saveDataUseCase;
        private readonly ILoadDataUseCase _loadDataUseCase;
        private readonly IDeleteDataUseCase _deleteDataUseCase;
        private readonly ILaunchGameUseCase _launchGameUseCase;
        private readonly ISaveSteamPathUseCase _saveSteamPathUseCase;
        private readonly ISaveSavedDataPathUseCase _saveSavedDataPathUseCase;

        private Action? retry;

        private BindingList<ImportResultDto>? savedData;
        private BindingList<ModDataDto>? modData;

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
                LaunchGameButton.Enabled = value != null;

                ServerNameTextBox.Text = value?.Server.Name ?? "";
                ServerIPTextBox.Text = value?.IPAddress ?? "";
                ServerBattleEyeCheckBox.Checked = value?.Server.BattleEye ?? false;

                //modsDualList.SetData(selectedItem?.Mods ?? new List<ModDataDto>());

                modData.Clear();
                foreach (ModDataDto mod in selectedItem?.Mods ?? new List<ModDataDto>())
                {
                    modData.Add(mod);
                }
            }
        }

        public Launcher(IImportLastPlayedServerUseCase importLastPlayedServerUseCase,
                        IImportInstalledModsUseCase importInstalledModsUseCase,
                        ISaveDataUseCase saveDataUseCase,
                        ILoadDataUseCase loadDataUseCase,
                        IDeleteDataUseCase deleteDataUseCase,
                        ILaunchGameUseCase launchGameUseCase,
                        ISaveSteamPathUseCase saveSteamPathUseCase,
                        ISaveSavedDataPathUseCase saveSavedDataPathUseCase)
        {
            _importLastPlayedServerUseCase = importLastPlayedServerUseCase ?? throw new ArgumentNullException(nameof(importLastPlayedServerUseCase));
            _importInstalledModsUseCase = importInstalledModsUseCase ?? throw new ArgumentNullException(nameof(importInstalledModsUseCase));
            _saveDataUseCase = saveDataUseCase ?? throw new ArgumentNullException(nameof(saveDataUseCase));
            _loadDataUseCase = loadDataUseCase ?? throw new ArgumentNullException(nameof(loadDataUseCase));
            _deleteDataUseCase = deleteDataUseCase ?? throw new ArgumentNullException(nameof(deleteDataUseCase));
            _launchGameUseCase = launchGameUseCase ?? throw new ArgumentNullException(nameof(launchGameUseCase));
            _saveSteamPathUseCase = saveSteamPathUseCase ?? throw new ArgumentNullException(nameof(saveSteamPathUseCase));
            _saveSavedDataPathUseCase = saveSavedDataPathUseCase ?? throw new ArgumentNullException(nameof(_saveSavedDataPathUseCase));

            InitializeComponent();
        }

        private async void Launcher_Shown(object sender, EventArgs e)
        {
            try
            {
                if (Settings.Default.SteamPath.IsWhiteSpace())
                {
                    await ShowSteamPathBrowserDialog();
                }

                if (Settings.Default.SavedDataPath.IsWhiteSpace())
                {
                    await ShowSavedDataPathBrowserDialog();
                }

                modData = new BindingList<ModDataDto>();
                selectedModsListBox.DataSource = modData;
                await FetchSavedData();

                await ImportMods();

                serverListBox.DisplayMember = "ServerName";
                serverListBox.DataSource = savedData;
                serverListBox.SelectedItem = SelectedServer;

            }
            catch (InvalidPathException ex)
            {
                ShowErrorMessage("Please set your paths.", ex.Message);
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
                await FetchSavedData();

                ImportResultDto? matchingSavedResult = savedData.FirstOrDefault(s => ServerDataDto.HasSameIpAddress(s.Server, lastPlayedServer.Server));
                if (matchingSavedResult != null)
                {
                    savedData.Remove(matchingSavedResult);
                }
                savedData.Add(lastPlayedServer);
                SelectedServer = lastPlayedServer;
                serverListBox.SelectedItem = lastPlayedServer;
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
            SelectedServer = (ImportResultDto?)serverListBox.SelectedItem;
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
                if (!savedData.Contains(dto))
                {
                    savedData.Add(dto);
                }

                FetchSavedData();

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

        private async Task FetchSavedData()
        {
            if (savedData == null)
            {
                savedData = new BindingList<ImportResultDto>();
            }
            else
            {
                savedData.Clear();
            }

            try
            {
                List<ImportResult> importResults = await _loadDataUseCase.LoadAsync();
                importResults
                    .Select(ImportResultMapper.ToDto)
                    .ToList()
                    .ForEach(savedData.Add);
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Could not fetch saved data.", ex.Message);
            }
        }

        private async void refreshModsButton_Click(object sender, EventArgs e)
        {
            await ImportMods();
        }

        private async Task ImportMods()
        {
            List<ModDataDto> mods = (await _importInstalledModsUseCase.GetInstalledMods())
                .Select(ModDataMapper.ToDto)
                .ToList();
            modsDualList.SetData(mods);
        }

        private async void saveModsButton_Click(object sender, EventArgs e)
        {
            SelectedServer.Mods.Clear();
            foreach (var item in selectedModsListBox.Items)
            {
                SelectedServer.Mods.Add((ModDataDto)item);
            }
            ImportResult r = await _saveDataUseCase.SaveServer(ImportResultMapper.FromDto(SelectedServer));
        }

        private async void steamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (await Throws<InvalidSteamPathException>(ShowSteamPathBrowserDialog))
            {
                MessageBox.Show("Please select your SteamLibrary folder.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (await Throws<InvalidSavedDataPathException>(ShowSavedDataPathBrowserDialog))
            {
                MessageBox.Show("Please select a json file.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await FetchSavedData();
            await ImportMods();
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await SaveAllServers();
        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSavedDataFileDialog.FileName = Settings.Default.SavedDataPath;
            saveSavedDataFileDialog.InitialDirectory = Directory.GetParent(Settings.Default.SavedDataPath).FullName;
            DialogResult dialogResult = saveSavedDataFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                await _saveSavedDataPathUseCase.Save(saveSavedDataFileDialog.FileName);
                await SaveAllServers();
            }
            else
            {
                MessageBox.Show("Data was not saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void ServerListBox_OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = serverListBox.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    serverListBox.SelectedIndex = index;
                }
                serverListContextMenu.Show(Cursor.Position);
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guid? guid = SelectedServer?.Guid;
            if (guid == null)
            {
                return;
            }
            
            if (MessageBox.Show("Are you sure you want to delete this server?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    await _deleteDataUseCase.DeleteDataAsync(guid.Value);
                    savedData.Remove(SelectedServer);
                }
                catch (ServerDoesNotExistException)
                {
                    // ignore. It's gone, it's fine.
                }
            }
        }

        private async Task SaveAllServers()
        {
            foreach (ImportResultDto dto in savedData)
            {
                await _saveDataUseCase.SaveServer(ImportResultMapper.FromDto(dto));
            }
        }

        private async Task ShowSteamPathBrowserDialog()
        {
            steamPathBrowserDialog.SelectedPath = Settings.Default.SteamPath;
            try
            {
                steamPathBrowserDialog.InitialDirectory = Directory.GetParent(Settings.Default.SteamPath).FullName;
            }
            catch (Exception)
            {
                /* No correct path was set. We're going to set that now. */
            }

            DialogResult dialogResult = steamPathBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                await _saveSteamPathUseCase.Save(steamPathBrowserDialog.SelectedPath);
            }
            else
            {
                MessageBox.Show("Steam Path was not changed.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task ShowSavedDataPathBrowserDialog()
        {
            savedDataBrowserDialog.FileName = Settings.Default.SavedDataPath;
            try
            {
                savedDataBrowserDialog.InitialDirectory = Directory.GetParent(Settings.Default.SavedDataPath).FullName;
            }
            catch (Exception)
            {
                /* No correct path was set. We're going to set that now. */
            }

            DialogResult dialogResult = savedDataBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                await _saveSavedDataPathUseCase.Save(savedDataBrowserDialog.FileName);
            }
            else
            {
                MessageBox.Show("Path was not changed.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static async Task<bool> Throws<T>(Func<Task> task) where T : Exception
        {
            try
            {
                await task();
                return false;
            }
            catch (T)
            {
                return true;
            }
        }
    }
}
