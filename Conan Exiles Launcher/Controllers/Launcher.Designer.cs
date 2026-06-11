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
            serverDataPanel = new Panel();
            SaveServerButton = new Button();
            label2 = new Label();
            ServerBattleEyeCheckBox = new CheckBox();
            LaunchGameButton = new Button();
            ServerIPTextBox = new TextBox();
            ServerNameTextBox = new TextBox();
            label3 = new Label();
            modsTab = new TabPage();
            settingsTab = new TabPage();
            panel1 = new Panel();
            saveDataBrowseButton = new Button();
            steamPathBrowseButton = new Button();
            button1 = new Button();
            label4 = new Label();
            savedDataPathTextBox = new TextBox();
            steamPathTextBox = new TextBox();
            label5 = new Label();
            ModOrderTooltip = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnRetry = new ToolStripSplitButton();
            ipAddressErrorProvider = new ErrorProvider(components);
            steamPathBrowserDialog = new FolderBrowserDialog();
            savedDataBrowserDialog = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            serverTab.SuspendLayout();
            serverDataPanel.SuspendLayout();
            settingsTab.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipAddressErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            ipAddressErrorProvider.SetError(splitContainer1, resources.GetString("splitContainer1.Error"));
            ipAddressErrorProvider.SetIconAlignment(splitContainer1, (ErrorIconAlignment)resources.GetObject("splitContainer1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(splitContainer1, (int)resources.GetObject("splitContainer1.IconPadding"));
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            ipAddressErrorProvider.SetError(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.Error"));
            ipAddressErrorProvider.SetIconAlignment(splitContainer1.Panel1, (ErrorIconAlignment)resources.GetObject("splitContainer1.Panel1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(splitContainer1.Panel1, (int)resources.GetObject("splitContainer1.Panel1.IconPadding"));
            ModOrderTooltip.SetToolTip(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            ipAddressErrorProvider.SetError(splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.Error"));
            ipAddressErrorProvider.SetIconAlignment(splitContainer1.Panel2, (ErrorIconAlignment)resources.GetObject("splitContainer1.Panel2.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(splitContainer1.Panel2, (int)resources.GetObject("splitContainer1.Panel2.IconPadding"));
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
            ipAddressErrorProvider.SetError(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Error"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel1, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel1, (int)resources.GetObject("tableLayoutPanel1.IconPadding"));
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            ModOrderTooltip.SetToolTip(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // AddServerButton
            // 
            resources.ApplyResources(AddServerButton, "AddServerButton");
            AddServerButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(AddServerButton, resources.GetString("AddServerButton.Error"));
            ipAddressErrorProvider.SetIconAlignment(AddServerButton, (ErrorIconAlignment)resources.GetObject("AddServerButton.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(AddServerButton, (int)resources.GetObject("AddServerButton.IconPadding"));
            AddServerButton.Name = "AddServerButton";
            ModOrderTooltip.SetToolTip(AddServerButton, resources.GetString("AddServerButton.ToolTip"));
            AddServerButton.UseVisualStyleBackColor = false;
            AddServerButton.Click += AddServerButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            ipAddressErrorProvider.SetError(label1, resources.GetString("label1.Error"));
            ipAddressErrorProvider.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
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
            ipAddressErrorProvider.SetError(panel2, resources.GetString("panel2.Error"));
            ipAddressErrorProvider.SetIconAlignment(panel2, (ErrorIconAlignment)resources.GetObject("panel2.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(panel2, (int)resources.GetObject("panel2.IconPadding"));
            panel2.Name = "panel2";
            ModOrderTooltip.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            // 
            // serverListBox
            // 
            resources.ApplyResources(serverListBox, "serverListBox");
            serverListBox.BackColor = Color.White;
            serverListBox.BorderStyle = BorderStyle.None;
            ipAddressErrorProvider.SetError(serverListBox, resources.GetString("serverListBox.Error"));
            serverListBox.ForeColor = SystemColors.ControlText;
            serverListBox.FormattingEnabled = true;
            ipAddressErrorProvider.SetIconAlignment(serverListBox, (ErrorIconAlignment)resources.GetObject("serverListBox.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(serverListBox, (int)resources.GetObject("serverListBox.IconPadding"));
            serverListBox.Name = "serverListBox";
            ModOrderTooltip.SetToolTip(serverListBox, resources.GetString("serverListBox.ToolTip"));
            serverListBox.SelectedIndexChanged += serverListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(ImportServerAndModlistButton, 0, 0);
            tableLayoutPanel2.Controls.Add(tabControl1, 0, 1);
            ipAddressErrorProvider.SetError(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.Error"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel2, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel2.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel2, (int)resources.GetObject("tableLayoutPanel2.IconPadding"));
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            ModOrderTooltip.SetToolTip(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // ImportServerAndModlistButton
            // 
            resources.ApplyResources(ImportServerAndModlistButton, "ImportServerAndModlistButton");
            ImportServerAndModlistButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(ImportServerAndModlistButton, resources.GetString("ImportServerAndModlistButton.Error"));
            ipAddressErrorProvider.SetIconAlignment(ImportServerAndModlistButton, (ErrorIconAlignment)resources.GetObject("ImportServerAndModlistButton.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(ImportServerAndModlistButton, (int)resources.GetObject("ImportServerAndModlistButton.IconPadding"));
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
            tabControl1.Controls.Add(settingsTab);
            ipAddressErrorProvider.SetError(tabControl1, resources.GetString("tabControl1.Error"));
            ipAddressErrorProvider.SetIconAlignment(tabControl1, (ErrorIconAlignment)resources.GetObject("tabControl1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(tabControl1, (int)resources.GetObject("tabControl1.IconPadding"));
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            ModOrderTooltip.SetToolTip(tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // serverTab
            // 
            resources.ApplyResources(serverTab, "serverTab");
            serverTab.BorderStyle = BorderStyle.FixedSingle;
            serverTab.Controls.Add(serverDataPanel);
            ipAddressErrorProvider.SetError(serverTab, resources.GetString("serverTab.Error"));
            ipAddressErrorProvider.SetIconAlignment(serverTab, (ErrorIconAlignment)resources.GetObject("serverTab.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(serverTab, (int)resources.GetObject("serverTab.IconPadding"));
            serverTab.Name = "serverTab";
            ModOrderTooltip.SetToolTip(serverTab, resources.GetString("serverTab.ToolTip"));
            serverTab.UseVisualStyleBackColor = true;
            // 
            // serverDataPanel
            // 
            resources.ApplyResources(serverDataPanel, "serverDataPanel");
            serverDataPanel.Controls.Add(SaveServerButton);
            serverDataPanel.Controls.Add(label2);
            serverDataPanel.Controls.Add(ServerBattleEyeCheckBox);
            serverDataPanel.Controls.Add(LaunchGameButton);
            serverDataPanel.Controls.Add(ServerIPTextBox);
            serverDataPanel.Controls.Add(ServerNameTextBox);
            serverDataPanel.Controls.Add(label3);
            ipAddressErrorProvider.SetError(serverDataPanel, resources.GetString("serverDataPanel.Error"));
            ipAddressErrorProvider.SetIconAlignment(serverDataPanel, (ErrorIconAlignment)resources.GetObject("serverDataPanel.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(serverDataPanel, (int)resources.GetObject("serverDataPanel.IconPadding"));
            serverDataPanel.Name = "serverDataPanel";
            ModOrderTooltip.SetToolTip(serverDataPanel, resources.GetString("serverDataPanel.ToolTip"));
            // 
            // SaveServerButton
            // 
            resources.ApplyResources(SaveServerButton, "SaveServerButton");
            SaveServerButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(SaveServerButton, resources.GetString("SaveServerButton.Error"));
            ipAddressErrorProvider.SetIconAlignment(SaveServerButton, (ErrorIconAlignment)resources.GetObject("SaveServerButton.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(SaveServerButton, (int)resources.GetObject("SaveServerButton.IconPadding"));
            SaveServerButton.Name = "SaveServerButton";
            ModOrderTooltip.SetToolTip(SaveServerButton, resources.GetString("SaveServerButton.ToolTip"));
            SaveServerButton.UseVisualStyleBackColor = false;
            SaveServerButton.Click += SaveServerButton_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            ipAddressErrorProvider.SetError(label2, resources.GetString("label2.Error"));
            ipAddressErrorProvider.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding"));
            label2.Name = "label2";
            ModOrderTooltip.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // ServerBattleEyeCheckBox
            // 
            resources.ApplyResources(ServerBattleEyeCheckBox, "ServerBattleEyeCheckBox");
            ipAddressErrorProvider.SetError(ServerBattleEyeCheckBox, resources.GetString("ServerBattleEyeCheckBox.Error"));
            ipAddressErrorProvider.SetIconAlignment(ServerBattleEyeCheckBox, (ErrorIconAlignment)resources.GetObject("ServerBattleEyeCheckBox.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(ServerBattleEyeCheckBox, (int)resources.GetObject("ServerBattleEyeCheckBox.IconPadding"));
            ServerBattleEyeCheckBox.Name = "ServerBattleEyeCheckBox";
            ModOrderTooltip.SetToolTip(ServerBattleEyeCheckBox, resources.GetString("ServerBattleEyeCheckBox.ToolTip"));
            ServerBattleEyeCheckBox.UseVisualStyleBackColor = true;
            // 
            // LaunchGameButton
            // 
            resources.ApplyResources(LaunchGameButton, "LaunchGameButton");
            LaunchGameButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(LaunchGameButton, resources.GetString("LaunchGameButton.Error"));
            ipAddressErrorProvider.SetIconAlignment(LaunchGameButton, (ErrorIconAlignment)resources.GetObject("LaunchGameButton.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(LaunchGameButton, (int)resources.GetObject("LaunchGameButton.IconPadding"));
            LaunchGameButton.Name = "LaunchGameButton";
            ModOrderTooltip.SetToolTip(LaunchGameButton, resources.GetString("LaunchGameButton.ToolTip"));
            LaunchGameButton.UseVisualStyleBackColor = false;
            LaunchGameButton.Click += LaunchGameButton_Click;
            // 
            // ServerIPTextBox
            // 
            resources.ApplyResources(ServerIPTextBox, "ServerIPTextBox");
            ServerIPTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipAddressErrorProvider.SetError(ServerIPTextBox, resources.GetString("ServerIPTextBox.Error"));
            ipAddressErrorProvider.SetIconAlignment(ServerIPTextBox, (ErrorIconAlignment)resources.GetObject("ServerIPTextBox.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(ServerIPTextBox, (int)resources.GetObject("ServerIPTextBox.IconPadding"));
            ServerIPTextBox.Name = "ServerIPTextBox";
            ModOrderTooltip.SetToolTip(ServerIPTextBox, resources.GetString("ServerIPTextBox.ToolTip"));
            ServerIPTextBox.TextChanged += ServerIPTextBox_TextChanged;
            // 
            // ServerNameTextBox
            // 
            resources.ApplyResources(ServerNameTextBox, "ServerNameTextBox");
            ServerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipAddressErrorProvider.SetError(ServerNameTextBox, resources.GetString("ServerNameTextBox.Error"));
            ipAddressErrorProvider.SetIconAlignment(ServerNameTextBox, (ErrorIconAlignment)resources.GetObject("ServerNameTextBox.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(ServerNameTextBox, (int)resources.GetObject("ServerNameTextBox.IconPadding"));
            ServerNameTextBox.Name = "ServerNameTextBox";
            ModOrderTooltip.SetToolTip(ServerNameTextBox, resources.GetString("ServerNameTextBox.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            ipAddressErrorProvider.SetError(label3, resources.GetString("label3.Error"));
            ipAddressErrorProvider.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding"));
            label3.Name = "label3";
            ModOrderTooltip.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // modsTab
            // 
            resources.ApplyResources(modsTab, "modsTab");
            modsTab.BorderStyle = BorderStyle.FixedSingle;
            ipAddressErrorProvider.SetError(modsTab, resources.GetString("modsTab.Error"));
            ipAddressErrorProvider.SetIconAlignment(modsTab, (ErrorIconAlignment)resources.GetObject("modsTab.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(modsTab, (int)resources.GetObject("modsTab.IconPadding"));
            modsTab.Name = "modsTab";
            ModOrderTooltip.SetToolTip(modsTab, resources.GetString("modsTab.ToolTip"));
            modsTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            resources.ApplyResources(settingsTab, "settingsTab");
            settingsTab.BorderStyle = BorderStyle.FixedSingle;
            settingsTab.Controls.Add(panel1);
            ipAddressErrorProvider.SetError(settingsTab, resources.GetString("settingsTab.Error"));
            ipAddressErrorProvider.SetIconAlignment(settingsTab, (ErrorIconAlignment)resources.GetObject("settingsTab.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(settingsTab, (int)resources.GetObject("settingsTab.IconPadding"));
            settingsTab.Name = "settingsTab";
            ModOrderTooltip.SetToolTip(settingsTab, resources.GetString("settingsTab.ToolTip"));
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(saveDataBrowseButton);
            panel1.Controls.Add(steamPathBrowseButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(savedDataPathTextBox);
            panel1.Controls.Add(steamPathTextBox);
            panel1.Controls.Add(label5);
            ipAddressErrorProvider.SetError(panel1, resources.GetString("panel1.Error"));
            ipAddressErrorProvider.SetIconAlignment(panel1, (ErrorIconAlignment)resources.GetObject("panel1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(panel1, (int)resources.GetObject("panel1.IconPadding"));
            panel1.Name = "panel1";
            ModOrderTooltip.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // saveDataBrowseButton
            // 
            resources.ApplyResources(saveDataBrowseButton, "saveDataBrowseButton");
            saveDataBrowseButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(saveDataBrowseButton, resources.GetString("saveDataBrowseButton.Error"));
            ipAddressErrorProvider.SetIconAlignment(saveDataBrowseButton, (ErrorIconAlignment)resources.GetObject("saveDataBrowseButton.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(saveDataBrowseButton, (int)resources.GetObject("saveDataBrowseButton.IconPadding"));
            saveDataBrowseButton.Name = "saveDataBrowseButton";
            ModOrderTooltip.SetToolTip(saveDataBrowseButton, resources.GetString("saveDataBrowseButton.ToolTip"));
            saveDataBrowseButton.UseVisualStyleBackColor = false;
            saveDataBrowseButton.Click += saveDataBrowseButton_Click;
            // 
            // steamPathBrowseButton
            // 
            resources.ApplyResources(steamPathBrowseButton, "steamPathBrowseButton");
            steamPathBrowseButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(steamPathBrowseButton, resources.GetString("steamPathBrowseButton.Error"));
            ipAddressErrorProvider.SetIconAlignment(steamPathBrowseButton, (ErrorIconAlignment)resources.GetObject("steamPathBrowseButton.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(steamPathBrowseButton, (int)resources.GetObject("steamPathBrowseButton.IconPadding"));
            steamPathBrowseButton.Name = "steamPathBrowseButton";
            ModOrderTooltip.SetToolTip(steamPathBrowseButton, resources.GetString("steamPathBrowseButton.ToolTip"));
            steamPathBrowseButton.UseVisualStyleBackColor = false;
            steamPathBrowseButton.Click += steamPathBrowseButton_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(button1, resources.GetString("button1.Error"));
            ipAddressErrorProvider.SetIconAlignment(button1, (ErrorIconAlignment)resources.GetObject("button1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(button1, (int)resources.GetObject("button1.IconPadding"));
            button1.Name = "button1";
            ModOrderTooltip.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            ipAddressErrorProvider.SetError(label4, resources.GetString("label4.Error"));
            ipAddressErrorProvider.SetIconAlignment(label4, (ErrorIconAlignment)resources.GetObject("label4.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(label4, (int)resources.GetObject("label4.IconPadding"));
            label4.Name = "label4";
            ModOrderTooltip.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // savedDataPathTextBox
            // 
            resources.ApplyResources(savedDataPathTextBox, "savedDataPathTextBox");
            savedDataPathTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipAddressErrorProvider.SetError(savedDataPathTextBox, resources.GetString("savedDataPathTextBox.Error"));
            ipAddressErrorProvider.SetIconAlignment(savedDataPathTextBox, (ErrorIconAlignment)resources.GetObject("savedDataPathTextBox.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(savedDataPathTextBox, (int)resources.GetObject("savedDataPathTextBox.IconPadding"));
            savedDataPathTextBox.Name = "savedDataPathTextBox";
            ModOrderTooltip.SetToolTip(savedDataPathTextBox, resources.GetString("savedDataPathTextBox.ToolTip"));
            // 
            // steamPathTextBox
            // 
            resources.ApplyResources(steamPathTextBox, "steamPathTextBox");
            steamPathTextBox.BorderStyle = BorderStyle.FixedSingle;
            ipAddressErrorProvider.SetError(steamPathTextBox, resources.GetString("steamPathTextBox.Error"));
            ipAddressErrorProvider.SetIconAlignment(steamPathTextBox, (ErrorIconAlignment)resources.GetObject("steamPathTextBox.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(steamPathTextBox, (int)resources.GetObject("steamPathTextBox.IconPadding"));
            steamPathTextBox.Name = "steamPathTextBox";
            ModOrderTooltip.SetToolTip(steamPathTextBox, resources.GetString("steamPathTextBox.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            ipAddressErrorProvider.SetError(label5, resources.GetString("label5.Error"));
            ipAddressErrorProvider.SetIconAlignment(label5, (ErrorIconAlignment)resources.GetObject("label5.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(label5, (int)resources.GetObject("label5.IconPadding"));
            label5.Name = "label5";
            ModOrderTooltip.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // ModOrderTooltip
            // 
            ModOrderTooltip.ToolTipTitle = "Mod Order";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.BackColor = Color.Transparent;
            ipAddressErrorProvider.SetError(statusStrip1, resources.GetString("statusStrip1.Error"));
            ipAddressErrorProvider.SetIconAlignment(statusStrip1, (ErrorIconAlignment)resources.GetObject("statusStrip1.IconAlignment"));
            ipAddressErrorProvider.SetIconPadding(statusStrip1, (int)resources.GetObject("statusStrip1.IconPadding"));
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
            // ipAddressErrorProvider
            // 
            ipAddressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ipAddressErrorProvider.ContainerControl = this;
            resources.ApplyResources(ipAddressErrorProvider, "ipAddressErrorProvider");
            // 
            // steamPathBrowserDialog
            // 
            resources.ApplyResources(steamPathBrowserDialog, "steamPathBrowserDialog");
            steamPathBrowserDialog.InitialDirectory = "%HOME%";
            // 
            // savedDataBrowserDialog
            // 
            resources.ApplyResources(savedDataBrowserDialog, "savedDataBrowserDialog");
            savedDataBrowserDialog.InitialDirectory = "%HOME%";
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
            serverDataPanel.ResumeLayout(false);
            serverDataPanel.PerformLayout();
            settingsTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipAddressErrorProvider).EndInit();
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
        private Panel serverDataPanel;
        private Panel panel2;
        private Button SaveServerButton;
        private ErrorProvider ipAddressErrorProvider;
        private TabPage settingsTab;
        private Panel panel1;
        private Button button1;
        private Label label4;
        private TextBox savedDataPathTextBox;
        private TextBox steamPathTextBox;
        private Label label5;
        private Button saveDataBrowseButton;
        private Button steamPathBrowseButton;
        private FolderBrowserDialog steamPathBrowserDialog;
        private FolderBrowserDialog savedDataBrowserDialog;
    }
}
