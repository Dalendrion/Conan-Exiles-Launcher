namespace Conan_Exiles_Launcher
{
    partial class Launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            ModOrderTooltip = new ToolTip(components);
            ImportServerAndModlistButton = new Button();
            SuspendLayout();
            // 
            // ModOrderTooltip
            // 
            ModOrderTooltip.ToolTipTitle = "Mod Order";
            // 
            // ImportServerAndModlistButton
            // 
            resources.ApplyResources(ImportServerAndModlistButton, "ImportServerAndModlistButton");
            ImportServerAndModlistButton.Name = "ImportServerAndModlistButton";
            ModOrderTooltip.SetToolTip(ImportServerAndModlistButton, resources.GetString("ImportServerAndModlistButton.ToolTip"));
            ImportServerAndModlistButton.UseVisualStyleBackColor = true;
            ImportServerAndModlistButton.Click += ImportServerAndModsButton_Click;
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ImportServerAndModlistButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Launcher";
            SizeGripStyle = SizeGripStyle.Hide;
            ModOrderTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Load += Launcher_Load;
            ResumeLayout(false);
        }

        #endregion
        private ToolTip ModOrderTooltip;
        private Button ImportServerAndModlistButton;
    }
}
