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

        private void ArrangeModPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                return;
            }

            e.Handled = true;
        }

        private void ArrangeModPosition_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
