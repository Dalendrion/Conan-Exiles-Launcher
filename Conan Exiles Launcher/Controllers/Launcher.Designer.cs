namespace Conan_Exiles_Launcher.Controllers
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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddServerButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            serverListBox = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ImportServerAndModlistButton = new Button();
            tabControl1 = new TabControl();
            serverTab = new TabPage();
            panel1 = new Panel();
            label2 = new Label();
            ServerBattleEyeCheckBox = new CheckBox();
            LaunchGameButton = new Button();
            ServerIPTextBox = new TextBox();
            ServerNameTextBox = new TextBox();
            label3 = new Label();
            modsTab = new TabPage();
            ModOrderTooltip = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnRetry = new ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            serverTab.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            ModOrderTooltip.SetToolTip(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            ModOrderTooltip.SetToolTip(splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            ModOrderTooltip.SetToolTip(splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.Controls.Add(AddServerButton, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            ModOrderTooltip.SetToolTip(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // AddServerButton
            // 
            resources.ApplyResources(AddServerButton, "AddServerButton");
            AddServerButton.BackColor = SystemColors.ButtonFace;
            AddServerButton.Name = "AddServerButton";
            ModOrderTooltip.SetToolTip(AddServerButton, resources.GetString("AddServerButton.ToolTip"));
            AddServerButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            ModOrderTooltip.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(serverListBox);
            panel2.Name = "panel2";
            ModOrderTooltip.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            // 
            // serverListBox
            // 
            resources.ApplyResources(serverListBox, "serverListBox");
            serverListBox.BackColor = Color.White;
            serverListBox.BorderStyle = BorderStyle.None;
            serverListBox.ForeColor = SystemColors.ControlText;
            serverListBox.FormattingEnabled = true;
            serverListBox.Name = "serverListBox";
            ModOrderTooltip.SetToolTip(serverListBox, resources.GetString("serverListBox.ToolTip"));
            serverListBox.SelectedIndexChanged += serverListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(ImportServerAndModlistButton, 0, 0);
            tableLayoutPanel2.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            ModOrderTooltip.SetToolTip(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // ImportServerAndModlistButton
            // 
            resources.ApplyResources(ImportServerAndModlistButton, "ImportServerAndModlistButton");
            ImportServerAndModlistButton.BackColor = SystemColors.ButtonFace;
            ImportServerAndModlistButton.Name = "ImportServerAndModlistButton";
            ModOrderTooltip.SetToolTip(ImportServerAndModlistButton, resources.GetString("ImportServerAndModlistButton.ToolTip"));
            ImportServerAndModlistButton.UseVisualStyleBackColor = false;
            ImportServerAndModlistButton.Click += ImportServerAndModlistButton_Click;
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(serverTab);
            tabControl1.Controls.Add(modsTab);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            ModOrderTooltip.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // serverTab
            // 
            resources.ApplyResources(serverTab, "serverTab");
            serverTab.BorderStyle = BorderStyle.FixedSingle;
            serverTab.Controls.Add(panel1);
            serverTab.Name = "serverTab";
            ModOrderTooltip.SetToolTip(serverTab, resources.GetString("serverTab.ToolTip"));
            serverTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ServerBattleEyeCheckBox);
            panel1.Controls.Add(LaunchGameButton);
            panel1.Controls.Add(ServerIPTextBox);
            panel1.Controls.Add(ServerNameTextBox);
            panel1.Controls.Add(label3);
            panel1.Name = "panel1";
            ModOrderTooltip.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            ModOrderTooltip.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // ServerBattleEyeCheckBox
            // 
            resources.ApplyResources(ServerBattleEyeCheckBox, "ServerBattleEyeCheckBox");
            ServerBattleEyeCheckBox.Name = "ServerBattleEyeCheckBox";
            ModOrderTooltip.SetToolTip(ServerBattleEyeCheckBox, resources.GetString("ServerBattleEyeCheckBox.ToolTip"));
            ServerBattleEyeCheckBox.UseVisualStyleBackColor = true;
            // 
            // LaunchGameButton
            // 
            resources.ApplyResources(LaunchGameButton, "LaunchGameButton");
            LaunchGameButton.BackColor = SystemColors.ButtonFace;
            LaunchGameButton.Name = "LaunchGameButton";
            ModOrderTooltip.SetToolTip(LaunchGameButton, resources.GetString("LaunchGameButton.ToolTip"));
            LaunchGameButton.UseVisualStyleBackColor = false;
            LaunchGameButton.Click += LaunchGameButton_Click;
            // 
            // ServerIPTextBox
            // 
            resources.ApplyResources(ServerIPTextBox, "ServerIPTextBox");
            ServerIPTextBox.BorderStyle = BorderStyle.FixedSingle;
            ServerIPTextBox.Name = "ServerIPTextBox";
            ModOrderTooltip.SetToolTip(ServerIPTextBox, resources.GetString("ServerIPTextBox.ToolTip"));
            // 
            // ServerNameTextBox
            // 
            resources.ApplyResources(ServerNameTextBox, "ServerNameTextBox");
            ServerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ServerNameTextBox.Name = "ServerNameTextBox";
            ModOrderTooltip.SetToolTip(ServerNameTextBox, resources.GetString("ServerNameTextBox.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            ModOrderTooltip.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // modsTab
            // 
            resources.ApplyResources(modsTab, "modsTab");
            modsTab.BorderStyle = BorderStyle.FixedSingle;
            modsTab.Name = "modsTab";
            ModOrderTooltip.SetToolTip(modsTab, resources.GetString("modsTab.ToolTip"));
            modsTab.UseVisualStyleBackColor = true;
            // 
            // ModOrderTooltip
            // 
            ModOrderTooltip.ToolTipTitle = "Mod Order";
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
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Launcher";
            SizeGripStyle = SizeGripStyle.Hide;
            ModOrderTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Shown += Launcher_Shown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            serverTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip ModOrderTooltip;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSplitButton btnRetry;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddServerButton;
        private Label label1;
        private ListBox serverListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ImportServerAndModlistButton;
        private TabControl tabControl1;
        private TabPage serverTab;
        private TabPage modsTab;
        private Button LaunchGameButton;
        private Label label2;
        private CheckBox ServerBattleEyeCheckBox;
        private TextBox ServerIPTextBox;
        private Label label3;
        private TextBox ServerNameTextBox;
        private Panel panel1;
        private Panel panel2;
    }
}
