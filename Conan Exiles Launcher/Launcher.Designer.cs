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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnRetry = new ToolStripSplitButton();
            LaunchGameButton = new Button();
            statusStrip1.SuspendLayout();
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
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, btnRetry });
            statusStrip1.Name = "statusStrip1";
            statusStrip1.ShowItemToolTips = true;
            statusStrip1.SizingGrip = false;
            ModOrderTooltip.SetToolTip(statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // btnRetry
            // 
            resources.ApplyResources(btnRetry, "btnRetry");
            btnRetry.BackColor = SystemColors.ActiveCaption;
            btnRetry.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRetry.DropDownButtonWidth = 0;
            btnRetry.Margin = new Padding(2, 3, 2, 3);
            btnRetry.Name = "btnRetry";
            btnRetry.ButtonClick += btnRetry_ButtonClick;
            // 
            // LaunchGameButton
            // 
            resources.ApplyResources(LaunchGameButton, "LaunchGameButton");
            LaunchGameButton.Name = "LaunchGameButton";
            ModOrderTooltip.SetToolTip(LaunchGameButton, resources.GetString("LaunchGameButton.ToolTip"));
            LaunchGameButton.UseVisualStyleBackColor = true;
            LaunchGameButton.Click += LaunchGameButton_Click;
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(LaunchGameButton);
            Controls.Add(statusStrip1);
            Controls.Add(ImportServerAndModlistButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Launcher";
            SizeGripStyle = SizeGripStyle.Hide;
            ModOrderTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Shown += Launcher_Shown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip ModOrderTooltip;
        private Button ImportServerAndModlistButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton btnRetry;
        private Button LaunchGameButton;
    }
}
