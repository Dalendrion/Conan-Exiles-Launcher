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
            panel7 = new Panel();
            refreshModsButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            modSelectButton = new Button();
            modDeselectButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            modMoveUp = new Button();
            modMoveDown = new Button();
            panel4 = new Panel();
            availableModsListBox = new ListBox();
            label6 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            selectedModsListBox = new ListBox();
            label7 = new Label();
            panel3 = new Panel();
            saveModsButton = new Button();
            ModOrderTooltip = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnRetry = new ToolStripSplitButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            steamToolStripMenuItem = new ToolStripMenuItem();
            serverListContextMenu = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ipAddressErrorProvider = new ErrorProvider(components);
            steamPathBrowserDialog = new FolderBrowserDialog();
            dualList1 = new DualList(components);
            modsDualList = new DualList(components);
            steamPathErrorProvider = new ErrorProvider(components);
            saveSavedDataFileDialog = new SaveFileDialog();
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
            modsTab.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            serverListContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipAddressErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)steamPathErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            steamPathErrorProvider.SetError(splitContainer1, resources.GetString("splitContainer1.Error"));
            ipAddressErrorProvider.SetError(splitContainer1, resources.GetString("splitContainer1.Error1"));
            steamPathErrorProvider.SetIconAlignment(splitContainer1, (ErrorIconAlignment)resources.GetObject("splitContainer1.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(splitContainer1, (ErrorIconAlignment)resources.GetObject("splitContainer1.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(splitContainer1, (int)resources.GetObject("splitContainer1.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(splitContainer1, (int)resources.GetObject("splitContainer1.IconPadding1"));
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            steamPathErrorProvider.SetError(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.Error"));
            ipAddressErrorProvider.SetError(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.Error1"));
            ipAddressErrorProvider.SetIconAlignment(splitContainer1.Panel1, (ErrorIconAlignment)resources.GetObject("splitContainer1.Panel1.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(splitContainer1.Panel1, (ErrorIconAlignment)resources.GetObject("splitContainer1.Panel1.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(splitContainer1.Panel1, (int)resources.GetObject("splitContainer1.Panel1.IconPadding"));
            steamPathErrorProvider.SetIconPadding(splitContainer1.Panel1, (int)resources.GetObject("splitContainer1.Panel1.IconPadding1"));
            ModOrderTooltip.SetToolTip(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            steamPathErrorProvider.SetError(splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.Error"));
            ipAddressErrorProvider.SetError(splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.Error1"));
            ipAddressErrorProvider.SetIconAlignment(splitContainer1.Panel2, (ErrorIconAlignment)resources.GetObject("splitContainer1.Panel2.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(splitContainer1.Panel2, (ErrorIconAlignment)resources.GetObject("splitContainer1.Panel2.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(splitContainer1.Panel2, (int)resources.GetObject("splitContainer1.Panel2.IconPadding"));
            steamPathErrorProvider.SetIconPadding(splitContainer1.Panel2, (int)resources.GetObject("splitContainer1.Panel2.IconPadding1"));
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
            steamPathErrorProvider.SetError(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Error1"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel1, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel1.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(tableLayoutPanel1, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel1.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel1, (int)resources.GetObject("tableLayoutPanel1.IconPadding"));
            steamPathErrorProvider.SetIconPadding(tableLayoutPanel1, (int)resources.GetObject("tableLayoutPanel1.IconPadding1"));
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            ModOrderTooltip.SetToolTip(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // AddServerButton
            // 
            resources.ApplyResources(AddServerButton, "AddServerButton");
            AddServerButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(AddServerButton, resources.GetString("AddServerButton.Error"));
            steamPathErrorProvider.SetError(AddServerButton, resources.GetString("AddServerButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(AddServerButton, (ErrorIconAlignment)resources.GetObject("AddServerButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(AddServerButton, (ErrorIconAlignment)resources.GetObject("AddServerButton.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(AddServerButton, (int)resources.GetObject("AddServerButton.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(AddServerButton, (int)resources.GetObject("AddServerButton.IconPadding1"));
            AddServerButton.Name = "AddServerButton";
            ModOrderTooltip.SetToolTip(AddServerButton, resources.GetString("AddServerButton.ToolTip"));
            AddServerButton.UseVisualStyleBackColor = false;
            AddServerButton.Click += AddServerButton_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            ipAddressErrorProvider.SetError(label1, resources.GetString("label1.Error"));
            steamPathErrorProvider.SetError(label1, resources.GetString("label1.Error1"));
            steamPathErrorProvider.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding1"));
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
            steamPathErrorProvider.SetError(panel2, resources.GetString("panel2.Error1"));
            ipAddressErrorProvider.SetIconAlignment(panel2, (ErrorIconAlignment)resources.GetObject("panel2.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(panel2, (ErrorIconAlignment)resources.GetObject("panel2.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(panel2, (int)resources.GetObject("panel2.IconPadding"));
            steamPathErrorProvider.SetIconPadding(panel2, (int)resources.GetObject("panel2.IconPadding1"));
            panel2.Name = "panel2";
            ModOrderTooltip.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            // 
            // serverListBox
            // 
            resources.ApplyResources(serverListBox, "serverListBox");
            serverListBox.BackColor = Color.White;
            serverListBox.BorderStyle = BorderStyle.None;
            steamPathErrorProvider.SetError(serverListBox, resources.GetString("serverListBox.Error"));
            ipAddressErrorProvider.SetError(serverListBox, resources.GetString("serverListBox.Error1"));
            serverListBox.ForeColor = SystemColors.ControlText;
            serverListBox.FormattingEnabled = true;
            ipAddressErrorProvider.SetIconAlignment(serverListBox, (ErrorIconAlignment)resources.GetObject("serverListBox.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(serverListBox, (ErrorIconAlignment)resources.GetObject("serverListBox.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(serverListBox, (int)resources.GetObject("serverListBox.IconPadding"));
            steamPathErrorProvider.SetIconPadding(serverListBox, (int)resources.GetObject("serverListBox.IconPadding1"));
            serverListBox.Name = "serverListBox";
            serverListBox.Sorted = true;
            ModOrderTooltip.SetToolTip(serverListBox, resources.GetString("serverListBox.ToolTip"));
            serverListBox.SelectedIndexChanged += serverListBox_SelectedIndexChanged;
            serverListBox.MouseUp += ServerListBox_OnMouseUp;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(ImportServerAndModlistButton, 0, 0);
            tableLayoutPanel2.Controls.Add(tabControl1, 0, 1);
            ipAddressErrorProvider.SetError(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.Error"));
            steamPathErrorProvider.SetError(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.Error1"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel2, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel2.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(tableLayoutPanel2, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel2.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel2, (int)resources.GetObject("tableLayoutPanel2.IconPadding"));
            steamPathErrorProvider.SetIconPadding(tableLayoutPanel2, (int)resources.GetObject("tableLayoutPanel2.IconPadding1"));
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            ModOrderTooltip.SetToolTip(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // ImportServerAndModlistButton
            // 
            resources.ApplyResources(ImportServerAndModlistButton, "ImportServerAndModlistButton");
            ImportServerAndModlistButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(ImportServerAndModlistButton, resources.GetString("ImportServerAndModlistButton.Error"));
            steamPathErrorProvider.SetError(ImportServerAndModlistButton, resources.GetString("ImportServerAndModlistButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(ImportServerAndModlistButton, (ErrorIconAlignment)resources.GetObject("ImportServerAndModlistButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(ImportServerAndModlistButton, (ErrorIconAlignment)resources.GetObject("ImportServerAndModlistButton.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(ImportServerAndModlistButton, (int)resources.GetObject("ImportServerAndModlistButton.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(ImportServerAndModlistButton, (int)resources.GetObject("ImportServerAndModlistButton.IconPadding1"));
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
            ipAddressErrorProvider.SetError(tabControl1, resources.GetString("tabControl1.Error"));
            steamPathErrorProvider.SetError(tabControl1, resources.GetString("tabControl1.Error1"));
            ipAddressErrorProvider.SetIconAlignment(tabControl1, (ErrorIconAlignment)resources.GetObject("tabControl1.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(tabControl1, (ErrorIconAlignment)resources.GetObject("tabControl1.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(tabControl1, (int)resources.GetObject("tabControl1.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(tabControl1, (int)resources.GetObject("tabControl1.IconPadding1"));
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
            steamPathErrorProvider.SetError(serverTab, resources.GetString("serverTab.Error1"));
            steamPathErrorProvider.SetIconAlignment(serverTab, (ErrorIconAlignment)resources.GetObject("serverTab.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(serverTab, (ErrorIconAlignment)resources.GetObject("serverTab.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(serverTab, (int)resources.GetObject("serverTab.IconPadding"));
            steamPathErrorProvider.SetIconPadding(serverTab, (int)resources.GetObject("serverTab.IconPadding1"));
            serverTab.Name = "serverTab";
            ModOrderTooltip.SetToolTip(serverTab, resources.GetString("serverTab.ToolTip"));
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
            steamPathErrorProvider.SetError(serverDataPanel, resources.GetString("serverDataPanel.Error"));
            ipAddressErrorProvider.SetError(serverDataPanel, resources.GetString("serverDataPanel.Error1"));
            ipAddressErrorProvider.SetIconAlignment(serverDataPanel, (ErrorIconAlignment)resources.GetObject("serverDataPanel.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(serverDataPanel, (ErrorIconAlignment)resources.GetObject("serverDataPanel.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(serverDataPanel, (int)resources.GetObject("serverDataPanel.IconPadding"));
            steamPathErrorProvider.SetIconPadding(serverDataPanel, (int)resources.GetObject("serverDataPanel.IconPadding1"));
            serverDataPanel.Name = "serverDataPanel";
            ModOrderTooltip.SetToolTip(serverDataPanel, resources.GetString("serverDataPanel.ToolTip"));
            // 
            // SaveServerButton
            // 
            resources.ApplyResources(SaveServerButton, "SaveServerButton");
            SaveServerButton.BackColor = SystemColors.ButtonFace;
            steamPathErrorProvider.SetError(SaveServerButton, resources.GetString("SaveServerButton.Error"));
            ipAddressErrorProvider.SetError(SaveServerButton, resources.GetString("SaveServerButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(SaveServerButton, (ErrorIconAlignment)resources.GetObject("SaveServerButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(SaveServerButton, (ErrorIconAlignment)resources.GetObject("SaveServerButton.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(SaveServerButton, (int)resources.GetObject("SaveServerButton.IconPadding"));
            steamPathErrorProvider.SetIconPadding(SaveServerButton, (int)resources.GetObject("SaveServerButton.IconPadding1"));
            SaveServerButton.Name = "SaveServerButton";
            ModOrderTooltip.SetToolTip(SaveServerButton, resources.GetString("SaveServerButton.ToolTip"));
            SaveServerButton.UseVisualStyleBackColor = false;
            SaveServerButton.Click += SaveServerButton_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            steamPathErrorProvider.SetError(label2, resources.GetString("label2.Error"));
            ipAddressErrorProvider.SetError(label2, resources.GetString("label2.Error1"));
            steamPathErrorProvider.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding"));
            steamPathErrorProvider.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding1"));
            label2.Name = "label2";
            ModOrderTooltip.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // ServerBattleEyeCheckBox
            // 
            resources.ApplyResources(ServerBattleEyeCheckBox, "ServerBattleEyeCheckBox");
            steamPathErrorProvider.SetError(ServerBattleEyeCheckBox, resources.GetString("ServerBattleEyeCheckBox.Error"));
            ipAddressErrorProvider.SetError(ServerBattleEyeCheckBox, resources.GetString("ServerBattleEyeCheckBox.Error1"));
            steamPathErrorProvider.SetIconAlignment(ServerBattleEyeCheckBox, (ErrorIconAlignment)resources.GetObject("ServerBattleEyeCheckBox.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(ServerBattleEyeCheckBox, (ErrorIconAlignment)resources.GetObject("ServerBattleEyeCheckBox.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(ServerBattleEyeCheckBox, (int)resources.GetObject("ServerBattleEyeCheckBox.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(ServerBattleEyeCheckBox, (int)resources.GetObject("ServerBattleEyeCheckBox.IconPadding1"));
            ServerBattleEyeCheckBox.Name = "ServerBattleEyeCheckBox";
            ModOrderTooltip.SetToolTip(ServerBattleEyeCheckBox, resources.GetString("ServerBattleEyeCheckBox.ToolTip"));
            ServerBattleEyeCheckBox.UseVisualStyleBackColor = true;
            // 
            // LaunchGameButton
            // 
            resources.ApplyResources(LaunchGameButton, "LaunchGameButton");
            LaunchGameButton.BackColor = SystemColors.ButtonFace;
            steamPathErrorProvider.SetError(LaunchGameButton, resources.GetString("LaunchGameButton.Error"));
            ipAddressErrorProvider.SetError(LaunchGameButton, resources.GetString("LaunchGameButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(LaunchGameButton, (ErrorIconAlignment)resources.GetObject("LaunchGameButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(LaunchGameButton, (ErrorIconAlignment)resources.GetObject("LaunchGameButton.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(LaunchGameButton, (int)resources.GetObject("LaunchGameButton.IconPadding"));
            steamPathErrorProvider.SetIconPadding(LaunchGameButton, (int)resources.GetObject("LaunchGameButton.IconPadding1"));
            LaunchGameButton.Name = "LaunchGameButton";
            ModOrderTooltip.SetToolTip(LaunchGameButton, resources.GetString("LaunchGameButton.ToolTip"));
            LaunchGameButton.UseVisualStyleBackColor = false;
            LaunchGameButton.Click += LaunchGameButton_Click;
            // 
            // ServerIPTextBox
            // 
            resources.ApplyResources(ServerIPTextBox, "ServerIPTextBox");
            ServerIPTextBox.BorderStyle = BorderStyle.FixedSingle;
            steamPathErrorProvider.SetError(ServerIPTextBox, resources.GetString("ServerIPTextBox.Error"));
            ipAddressErrorProvider.SetError(ServerIPTextBox, resources.GetString("ServerIPTextBox.Error1"));
            steamPathErrorProvider.SetIconAlignment(ServerIPTextBox, (ErrorIconAlignment)resources.GetObject("ServerIPTextBox.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(ServerIPTextBox, (ErrorIconAlignment)resources.GetObject("ServerIPTextBox.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(ServerIPTextBox, (int)resources.GetObject("ServerIPTextBox.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(ServerIPTextBox, (int)resources.GetObject("ServerIPTextBox.IconPadding1"));
            ServerIPTextBox.Name = "ServerIPTextBox";
            ModOrderTooltip.SetToolTip(ServerIPTextBox, resources.GetString("ServerIPTextBox.ToolTip"));
            ServerIPTextBox.TextChanged += ServerIPTextBox_TextChanged;
            // 
            // ServerNameTextBox
            // 
            resources.ApplyResources(ServerNameTextBox, "ServerNameTextBox");
            ServerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            steamPathErrorProvider.SetError(ServerNameTextBox, resources.GetString("ServerNameTextBox.Error"));
            ipAddressErrorProvider.SetError(ServerNameTextBox, resources.GetString("ServerNameTextBox.Error1"));
            steamPathErrorProvider.SetIconAlignment(ServerNameTextBox, (ErrorIconAlignment)resources.GetObject("ServerNameTextBox.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(ServerNameTextBox, (ErrorIconAlignment)resources.GetObject("ServerNameTextBox.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(ServerNameTextBox, (int)resources.GetObject("ServerNameTextBox.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(ServerNameTextBox, (int)resources.GetObject("ServerNameTextBox.IconPadding1"));
            ServerNameTextBox.Name = "ServerNameTextBox";
            ModOrderTooltip.SetToolTip(ServerNameTextBox, resources.GetString("ServerNameTextBox.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            steamPathErrorProvider.SetError(label3, resources.GetString("label3.Error"));
            ipAddressErrorProvider.SetError(label3, resources.GetString("label3.Error1"));
            steamPathErrorProvider.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding"));
            steamPathErrorProvider.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding1"));
            label3.Name = "label3";
            ModOrderTooltip.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // modsTab
            // 
            resources.ApplyResources(modsTab, "modsTab");
            modsTab.BorderStyle = BorderStyle.FixedSingle;
            modsTab.Controls.Add(panel7);
            modsTab.Controls.Add(tableLayoutPanel3);
            modsTab.Controls.Add(panel3);
            ipAddressErrorProvider.SetError(modsTab, resources.GetString("modsTab.Error"));
            steamPathErrorProvider.SetError(modsTab, resources.GetString("modsTab.Error1"));
            steamPathErrorProvider.SetIconAlignment(modsTab, (ErrorIconAlignment)resources.GetObject("modsTab.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(modsTab, (ErrorIconAlignment)resources.GetObject("modsTab.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(modsTab, (int)resources.GetObject("modsTab.IconPadding"));
            steamPathErrorProvider.SetIconPadding(modsTab, (int)resources.GetObject("modsTab.IconPadding1"));
            modsTab.Name = "modsTab";
            ModOrderTooltip.SetToolTip(modsTab, resources.GetString("modsTab.ToolTip"));
            modsTab.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.Controls.Add(refreshModsButton);
            steamPathErrorProvider.SetError(panel7, resources.GetString("panel7.Error"));
            ipAddressErrorProvider.SetError(panel7, resources.GetString("panel7.Error1"));
            ipAddressErrorProvider.SetIconAlignment(panel7, (ErrorIconAlignment)resources.GetObject("panel7.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(panel7, (ErrorIconAlignment)resources.GetObject("panel7.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(panel7, (int)resources.GetObject("panel7.IconPadding"));
            steamPathErrorProvider.SetIconPadding(panel7, (int)resources.GetObject("panel7.IconPadding1"));
            panel7.Name = "panel7";
            ModOrderTooltip.SetToolTip(panel7, resources.GetString("panel7.ToolTip"));
            // 
            // refreshModsButton
            // 
            resources.ApplyResources(refreshModsButton, "refreshModsButton");
            refreshModsButton.BackColor = SystemColors.ButtonFace;
            steamPathErrorProvider.SetError(refreshModsButton, resources.GetString("refreshModsButton.Error"));
            ipAddressErrorProvider.SetError(refreshModsButton, resources.GetString("refreshModsButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(refreshModsButton, (ErrorIconAlignment)resources.GetObject("refreshModsButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(refreshModsButton, (ErrorIconAlignment)resources.GetObject("refreshModsButton.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(refreshModsButton, (int)resources.GetObject("refreshModsButton.IconPadding"));
            steamPathErrorProvider.SetIconPadding(refreshModsButton, (int)resources.GetObject("refreshModsButton.IconPadding1"));
            refreshModsButton.Name = "refreshModsButton";
            ModOrderTooltip.SetToolTip(refreshModsButton, resources.GetString("refreshModsButton.ToolTip"));
            refreshModsButton.UseVisualStyleBackColor = false;
            refreshModsButton.Click += refreshModsButton_Click;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 3, 0);
            tableLayoutPanel3.Controls.Add(panel4, 0, 0);
            tableLayoutPanel3.Controls.Add(panel5, 2, 0);
            ipAddressErrorProvider.SetError(tableLayoutPanel3, resources.GetString("tableLayoutPanel3.Error"));
            steamPathErrorProvider.SetError(tableLayoutPanel3, resources.GetString("tableLayoutPanel3.Error1"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel3, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel3.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(tableLayoutPanel3, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel3.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel3, (int)resources.GetObject("tableLayoutPanel3.IconPadding"));
            steamPathErrorProvider.SetIconPadding(tableLayoutPanel3, (int)resources.GetObject("tableLayoutPanel3.IconPadding1"));
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            ModOrderTooltip.SetToolTip(tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(modSelectButton, 0, 1);
            tableLayoutPanel4.Controls.Add(modDeselectButton, 0, 2);
            steamPathErrorProvider.SetError(tableLayoutPanel4, resources.GetString("tableLayoutPanel4.Error"));
            ipAddressErrorProvider.SetError(tableLayoutPanel4, resources.GetString("tableLayoutPanel4.Error1"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel4, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel4.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(tableLayoutPanel4, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel4.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel4, (int)resources.GetObject("tableLayoutPanel4.IconPadding"));
            steamPathErrorProvider.SetIconPadding(tableLayoutPanel4, (int)resources.GetObject("tableLayoutPanel4.IconPadding1"));
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            ModOrderTooltip.SetToolTip(tableLayoutPanel4, resources.GetString("tableLayoutPanel4.ToolTip"));
            // 
            // modSelectButton
            // 
            resources.ApplyResources(modSelectButton, "modSelectButton");
            modSelectButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(modSelectButton, resources.GetString("modSelectButton.Error"));
            steamPathErrorProvider.SetError(modSelectButton, resources.GetString("modSelectButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(modSelectButton, (ErrorIconAlignment)resources.GetObject("modSelectButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(modSelectButton, (ErrorIconAlignment)resources.GetObject("modSelectButton.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(modSelectButton, (int)resources.GetObject("modSelectButton.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(modSelectButton, (int)resources.GetObject("modSelectButton.IconPadding1"));
            modSelectButton.Name = "modSelectButton";
            ModOrderTooltip.SetToolTip(modSelectButton, resources.GetString("modSelectButton.ToolTip"));
            modSelectButton.UseVisualStyleBackColor = false;
            // 
            // modDeselectButton
            // 
            resources.ApplyResources(modDeselectButton, "modDeselectButton");
            modDeselectButton.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(modDeselectButton, resources.GetString("modDeselectButton.Error"));
            steamPathErrorProvider.SetError(modDeselectButton, resources.GetString("modDeselectButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(modDeselectButton, (ErrorIconAlignment)resources.GetObject("modDeselectButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(modDeselectButton, (ErrorIconAlignment)resources.GetObject("modDeselectButton.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(modDeselectButton, (int)resources.GetObject("modDeselectButton.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(modDeselectButton, (int)resources.GetObject("modDeselectButton.IconPadding1"));
            modDeselectButton.Name = "modDeselectButton";
            ModOrderTooltip.SetToolTip(modDeselectButton, resources.GetString("modDeselectButton.ToolTip"));
            modDeselectButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.Controls.Add(modMoveUp, 0, 1);
            tableLayoutPanel5.Controls.Add(modMoveDown, 0, 2);
            steamPathErrorProvider.SetError(tableLayoutPanel5, resources.GetString("tableLayoutPanel5.Error"));
            ipAddressErrorProvider.SetError(tableLayoutPanel5, resources.GetString("tableLayoutPanel5.Error1"));
            ipAddressErrorProvider.SetIconAlignment(tableLayoutPanel5, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel5.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(tableLayoutPanel5, (ErrorIconAlignment)resources.GetObject("tableLayoutPanel5.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(tableLayoutPanel5, (int)resources.GetObject("tableLayoutPanel5.IconPadding"));
            steamPathErrorProvider.SetIconPadding(tableLayoutPanel5, (int)resources.GetObject("tableLayoutPanel5.IconPadding1"));
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            ModOrderTooltip.SetToolTip(tableLayoutPanel5, resources.GetString("tableLayoutPanel5.ToolTip"));
            // 
            // modMoveUp
            // 
            resources.ApplyResources(modMoveUp, "modMoveUp");
            modMoveUp.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(modMoveUp, resources.GetString("modMoveUp.Error"));
            steamPathErrorProvider.SetError(modMoveUp, resources.GetString("modMoveUp.Error1"));
            steamPathErrorProvider.SetIconAlignment(modMoveUp, (ErrorIconAlignment)resources.GetObject("modMoveUp.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(modMoveUp, (ErrorIconAlignment)resources.GetObject("modMoveUp.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(modMoveUp, (int)resources.GetObject("modMoveUp.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(modMoveUp, (int)resources.GetObject("modMoveUp.IconPadding1"));
            modMoveUp.Name = "modMoveUp";
            ModOrderTooltip.SetToolTip(modMoveUp, resources.GetString("modMoveUp.ToolTip"));
            modMoveUp.UseVisualStyleBackColor = false;
            // 
            // modMoveDown
            // 
            resources.ApplyResources(modMoveDown, "modMoveDown");
            modMoveDown.BackColor = SystemColors.ButtonFace;
            ipAddressErrorProvider.SetError(modMoveDown, resources.GetString("modMoveDown.Error"));
            steamPathErrorProvider.SetError(modMoveDown, resources.GetString("modMoveDown.Error1"));
            steamPathErrorProvider.SetIconAlignment(modMoveDown, (ErrorIconAlignment)resources.GetObject("modMoveDown.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(modMoveDown, (ErrorIconAlignment)resources.GetObject("modMoveDown.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(modMoveDown, (int)resources.GetObject("modMoveDown.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(modMoveDown, (int)resources.GetObject("modMoveDown.IconPadding1"));
            modMoveDown.Name = "modMoveDown";
            ModOrderTooltip.SetToolTip(modMoveDown, resources.GetString("modMoveDown.ToolTip"));
            modMoveDown.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(availableModsListBox);
            panel4.Controls.Add(label6);
            ipAddressErrorProvider.SetError(panel4, resources.GetString("panel4.Error"));
            steamPathErrorProvider.SetError(panel4, resources.GetString("panel4.Error1"));
            ipAddressErrorProvider.SetIconAlignment(panel4, (ErrorIconAlignment)resources.GetObject("panel4.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(panel4, (ErrorIconAlignment)resources.GetObject("panel4.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(panel4, (int)resources.GetObject("panel4.IconPadding"));
            steamPathErrorProvider.SetIconPadding(panel4, (int)resources.GetObject("panel4.IconPadding1"));
            panel4.Name = "panel4";
            ModOrderTooltip.SetToolTip(panel4, resources.GetString("panel4.ToolTip"));
            // 
            // availableModsListBox
            // 
            resources.ApplyResources(availableModsListBox, "availableModsListBox");
            availableModsListBox.DisplayMember = "FileName";
            steamPathErrorProvider.SetError(availableModsListBox, resources.GetString("availableModsListBox.Error"));
            ipAddressErrorProvider.SetError(availableModsListBox, resources.GetString("availableModsListBox.Error1"));
            availableModsListBox.FormattingEnabled = true;
            ipAddressErrorProvider.SetIconAlignment(availableModsListBox, (ErrorIconAlignment)resources.GetObject("availableModsListBox.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(availableModsListBox, (ErrorIconAlignment)resources.GetObject("availableModsListBox.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(availableModsListBox, (int)resources.GetObject("availableModsListBox.IconPadding"));
            steamPathErrorProvider.SetIconPadding(availableModsListBox, (int)resources.GetObject("availableModsListBox.IconPadding1"));
            availableModsListBox.Name = "availableModsListBox";
            availableModsListBox.Sorted = true;
            ModOrderTooltip.SetToolTip(availableModsListBox, resources.GetString("availableModsListBox.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            steamPathErrorProvider.SetError(label6, resources.GetString("label6.Error"));
            ipAddressErrorProvider.SetError(label6, resources.GetString("label6.Error1"));
            steamPathErrorProvider.SetIconAlignment(label6, (ErrorIconAlignment)resources.GetObject("label6.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(label6, (ErrorIconAlignment)resources.GetObject("label6.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(label6, (int)resources.GetObject("label6.IconPadding"));
            steamPathErrorProvider.SetIconPadding(label6, (int)resources.GetObject("label6.IconPadding1"));
            label6.Name = "label6";
            ModOrderTooltip.SetToolTip(label6, resources.GetString("label6.ToolTip"));
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.Controls.Add(panel6);
            ipAddressErrorProvider.SetError(panel5, resources.GetString("panel5.Error"));
            steamPathErrorProvider.SetError(panel5, resources.GetString("panel5.Error1"));
            ipAddressErrorProvider.SetIconAlignment(panel5, (ErrorIconAlignment)resources.GetObject("panel5.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(panel5, (ErrorIconAlignment)resources.GetObject("panel5.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(panel5, (int)resources.GetObject("panel5.IconPadding"));
            steamPathErrorProvider.SetIconPadding(panel5, (int)resources.GetObject("panel5.IconPadding1"));
            panel5.Name = "panel5";
            ModOrderTooltip.SetToolTip(panel5, resources.GetString("panel5.ToolTip"));
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.Controls.Add(selectedModsListBox);
            panel6.Controls.Add(label7);
            steamPathErrorProvider.SetError(panel6, resources.GetString("panel6.Error"));
            ipAddressErrorProvider.SetError(panel6, resources.GetString("panel6.Error1"));
            ipAddressErrorProvider.SetIconAlignment(panel6, (ErrorIconAlignment)resources.GetObject("panel6.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(panel6, (ErrorIconAlignment)resources.GetObject("panel6.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(panel6, (int)resources.GetObject("panel6.IconPadding"));
            steamPathErrorProvider.SetIconPadding(panel6, (int)resources.GetObject("panel6.IconPadding1"));
            panel6.Name = "panel6";
            ModOrderTooltip.SetToolTip(panel6, resources.GetString("panel6.ToolTip"));
            // 
            // selectedModsListBox
            // 
            resources.ApplyResources(selectedModsListBox, "selectedModsListBox");
            selectedModsListBox.DisplayMember = "FileName";
            selectedModsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            steamPathErrorProvider.SetError(selectedModsListBox, resources.GetString("selectedModsListBox.Error"));
            ipAddressErrorProvider.SetError(selectedModsListBox, resources.GetString("selectedModsListBox.Error1"));
            selectedModsListBox.FormattingEnabled = true;
            ipAddressErrorProvider.SetIconAlignment(selectedModsListBox, (ErrorIconAlignment)resources.GetObject("selectedModsListBox.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(selectedModsListBox, (ErrorIconAlignment)resources.GetObject("selectedModsListBox.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(selectedModsListBox, (int)resources.GetObject("selectedModsListBox.IconPadding"));
            steamPathErrorProvider.SetIconPadding(selectedModsListBox, (int)resources.GetObject("selectedModsListBox.IconPadding1"));
            selectedModsListBox.Name = "selectedModsListBox";
            ModOrderTooltip.SetToolTip(selectedModsListBox, resources.GetString("selectedModsListBox.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            steamPathErrorProvider.SetError(label7, resources.GetString("label7.Error"));
            ipAddressErrorProvider.SetError(label7, resources.GetString("label7.Error1"));
            steamPathErrorProvider.SetIconAlignment(label7, (ErrorIconAlignment)resources.GetObject("label7.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(label7, (ErrorIconAlignment)resources.GetObject("label7.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(label7, (int)resources.GetObject("label7.IconPadding"));
            steamPathErrorProvider.SetIconPadding(label7, (int)resources.GetObject("label7.IconPadding1"));
            label7.Name = "label7";
            ModOrderTooltip.SetToolTip(label7, resources.GetString("label7.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(saveModsButton);
            steamPathErrorProvider.SetError(panel3, resources.GetString("panel3.Error"));
            ipAddressErrorProvider.SetError(panel3, resources.GetString("panel3.Error1"));
            ipAddressErrorProvider.SetIconAlignment(panel3, (ErrorIconAlignment)resources.GetObject("panel3.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(panel3, (ErrorIconAlignment)resources.GetObject("panel3.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(panel3, (int)resources.GetObject("panel3.IconPadding"));
            steamPathErrorProvider.SetIconPadding(panel3, (int)resources.GetObject("panel3.IconPadding1"));
            panel3.Name = "panel3";
            ModOrderTooltip.SetToolTip(panel3, resources.GetString("panel3.ToolTip"));
            // 
            // saveModsButton
            // 
            resources.ApplyResources(saveModsButton, "saveModsButton");
            saveModsButton.BackColor = SystemColors.ButtonFace;
            steamPathErrorProvider.SetError(saveModsButton, resources.GetString("saveModsButton.Error"));
            ipAddressErrorProvider.SetError(saveModsButton, resources.GetString("saveModsButton.Error1"));
            steamPathErrorProvider.SetIconAlignment(saveModsButton, (ErrorIconAlignment)resources.GetObject("saveModsButton.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(saveModsButton, (ErrorIconAlignment)resources.GetObject("saveModsButton.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(saveModsButton, (int)resources.GetObject("saveModsButton.IconPadding"));
            steamPathErrorProvider.SetIconPadding(saveModsButton, (int)resources.GetObject("saveModsButton.IconPadding1"));
            saveModsButton.Name = "saveModsButton";
            ModOrderTooltip.SetToolTip(saveModsButton, resources.GetString("saveModsButton.ToolTip"));
            saveModsButton.UseVisualStyleBackColor = false;
            saveModsButton.Click += saveModsButton_Click;
            // 
            // ModOrderTooltip
            // 
            ModOrderTooltip.ToolTipTitle = "Mod Order";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.BackColor = Color.Transparent;
            steamPathErrorProvider.SetError(statusStrip1, resources.GetString("statusStrip1.Error"));
            ipAddressErrorProvider.SetError(statusStrip1, resources.GetString("statusStrip1.Error1"));
            steamPathErrorProvider.SetIconAlignment(statusStrip1, (ErrorIconAlignment)resources.GetObject("statusStrip1.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(statusStrip1, (ErrorIconAlignment)resources.GetObject("statusStrip1.IconAlignment1"));
            steamPathErrorProvider.SetIconPadding(statusStrip1, (int)resources.GetObject("statusStrip1.IconPadding"));
            ipAddressErrorProvider.SetIconPadding(statusStrip1, (int)resources.GetObject("statusStrip1.IconPadding1"));
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
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            steamPathErrorProvider.SetError(menuStrip1, resources.GetString("menuStrip1.Error"));
            ipAddressErrorProvider.SetError(menuStrip1, resources.GetString("menuStrip1.Error1"));
            ipAddressErrorProvider.SetIconAlignment(menuStrip1, (ErrorIconAlignment)resources.GetObject("menuStrip1.IconAlignment"));
            steamPathErrorProvider.SetIconAlignment(menuStrip1, (ErrorIconAlignment)resources.GetObject("menuStrip1.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(menuStrip1, (int)resources.GetObject("menuStrip1.IconPadding"));
            steamPathErrorProvider.SetIconPadding(menuStrip1, (int)resources.GetObject("menuStrip1.IconPadding1"));
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            ModOrderTooltip.SetToolTip(menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(openToolStripMenuItem, "openToolStripMenuItem");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(saveToolStripMenuItem, "saveToolStripMenuItem");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { steamToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // steamToolStripMenuItem
            // 
            resources.ApplyResources(steamToolStripMenuItem, "steamToolStripMenuItem");
            steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            steamToolStripMenuItem.Click += steamToolStripMenuItem_Click;
            // 
            // serverListContextMenu
            // 
            resources.ApplyResources(serverListContextMenu, "serverListContextMenu");
            steamPathErrorProvider.SetError(serverListContextMenu, resources.GetString("serverListContextMenu.Error"));
            ipAddressErrorProvider.SetError(serverListContextMenu, resources.GetString("serverListContextMenu.Error1"));
            steamPathErrorProvider.SetIconAlignment(serverListContextMenu, (ErrorIconAlignment)resources.GetObject("serverListContextMenu.IconAlignment"));
            ipAddressErrorProvider.SetIconAlignment(serverListContextMenu, (ErrorIconAlignment)resources.GetObject("serverListContextMenu.IconAlignment1"));
            ipAddressErrorProvider.SetIconPadding(serverListContextMenu, (int)resources.GetObject("serverListContextMenu.IconPadding"));
            steamPathErrorProvider.SetIconPadding(serverListContextMenu, (int)resources.GetObject("serverListContextMenu.IconPadding1"));
            serverListContextMenu.ImageScalingSize = new Size(20, 20);
            serverListContextMenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            serverListContextMenu.Name = "serverListContextMenu";
            ModOrderTooltip.SetToolTip(serverListContextMenu, resources.GetString("serverListContextMenu.ToolTip"));
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(deleteToolStripMenuItem, "deleteToolStripMenuItem");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
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
            // dualList1
            // 
            dualList1.AvailableItemsListBox = null;
            dualList1.DeselectButton = null;
            dualList1.DownButton = null;
            dualList1.SelectButton = null;
            dualList1.SelectedItemsListBox = null;
            dualList1.UpButton = null;
            // 
            // modsDualList
            // 
            modsDualList.AvailableItemsListBox = availableModsListBox;
            modsDualList.DeselectButton = modDeselectButton;
            modsDualList.DownButton = modMoveDown;
            modsDualList.SelectButton = modSelectButton;
            modsDualList.SelectedItemsListBox = selectedModsListBox;
            modsDualList.UpButton = modMoveUp;
            // 
            // steamPathErrorProvider
            // 
            steamPathErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            steamPathErrorProvider.ContainerControl = this;
            resources.ApplyResources(steamPathErrorProvider, "steamPathErrorProvider");
            // 
            // saveSavedDataFileDialog
            // 
            saveSavedDataFileDialog.DefaultExt = "json";
            resources.ApplyResources(saveSavedDataFileDialog, "saveSavedDataFileDialog");
            saveSavedDataFileDialog.InitialDirectory = "%HOME%";
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Launcher";
            SizeGripStyle = SizeGripStyle.Hide;
            ModOrderTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            FormClosing += Launcher_FormClosing;
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
            modsTab.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            serverListContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ipAddressErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)steamPathErrorProvider).EndInit();
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
        private FolderBrowserDialog steamPathBrowserDialog;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button saveModsButton;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button modSelectButton;
        private Button modDeselectButton;
        private Button modMoveUp;
        private Button modMoveDown;
        private Panel panel4;
        private Panel panel5;
        private ListBox availableModsListBox;
        private Label label6;
        private Panel panel6;
        private ListBox selectedModsListBox;
        private Label label7;
        private DualList dualList1;
        private DualList modsDualList;
        private Button refreshModsButton;
        private Panel panel7;
        private ErrorProvider steamPathErrorProvider;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem steamToolStripMenuItem;
        private SaveFileDialog saveSavedDataFileDialog;
        private ContextMenuStrip serverListContextMenu;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
