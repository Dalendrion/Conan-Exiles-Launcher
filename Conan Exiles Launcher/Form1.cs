using Conan_Exiles_Launcher.Domain.Model;
using Conan_Exiles_Launcher.Domain.Ports.In;
using Conan_Exiles_Launcher.Domain.UseCases;
using System.Diagnostics;

namespace Conan_Exiles_Launcher
{
    public partial class Launcher : Form
    {
        private readonly ILoadSavedDataUseCase _loadSavedDataUseCase;
        private readonly IImportLastPlayedServerUseCase _importLastPlayedServerUseCase;

        public Launcher(ILoadSavedDataUseCase loadSavedDataUseCase,
                        IImportLastPlayedServerUseCase importLastPlayedServerUseCase)
        {
            _loadSavedDataUseCase = loadSavedDataUseCase ?? throw new ArgumentNullException(nameof(loadSavedDataUseCase));
            _importLastPlayedServerUseCase = importLastPlayedServerUseCase ?? throw new ArgumentNullException(nameof(importLastPlayedServerUseCase));

            InitializeComponent();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            try
            {
                List<ImportResult> results = _loadSavedDataUseCase.LoadAsync().Result;

                foreach (ImportResult result in results) {
                    Debug.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load saved data: " + ex.Message, "Could not load saved data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ImportServerAndModsButton_Click(object sender, EventArgs e)
        {
            ImportServerAndModlistButton.Enabled = false;

            try
            {
                ImportResult result = await _importLastPlayedServerUseCase.ImportAsync();
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Import failed: " + ex.Message, "Could not import last played server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ImportServerAndModlistButton.Enabled = true;
            }
        }
    }
}
