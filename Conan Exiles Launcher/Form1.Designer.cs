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
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            AvailableModsList = new ListBox();
            AddModButton = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            SelectedModsList = new ListBox();
            RemoveModButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            ArrangeModPosition = new NumericUpDown();
            PlayButton = new Button();
            ModOrderTooltip = new ToolTip(components);
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ArrangeModPosition).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            ModOrderTooltip.SetToolTip(splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.BackColor = Color.Transparent;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            ModOrderTooltip.SetToolTip(splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            ModOrderTooltip.SetToolTip(splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(AddModButton, 0, 2);
            tableLayoutPanel2.Controls.Add(AvailableModsList, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            ModOrderTooltip.SetToolTip(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // AvailableModsList
            // 
            resources.ApplyResources(AvailableModsList, "AvailableModsList");
            tableLayoutPanel2.SetColumnSpan(AvailableModsList, 2);
            AvailableModsList.FormattingEnabled = true;
            AvailableModsList.Name = "AvailableModsList";
            ModOrderTooltip.SetToolTip(AvailableModsList, resources.GetString("AvailableModsList.ToolTip"));
            // 
            // AddModButton
            // 
            resources.ApplyResources(AddModButton, "AddModButton");
            AddModButton.Name = "AddModButton";
            ModOrderTooltip.SetToolTip(AddModButton, resources.GetString("AddModButton.ToolTip"));
            AddModButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            ModOrderTooltip.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(RemoveModButton, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(SelectedModsList, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            ModOrderTooltip.SetToolTip(tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Name = "label2";
            ModOrderTooltip.SetToolTip(label2, resources.GetString("label2.ToolTip"));
            // 
            // SelectedModsList
            // 
            resources.ApplyResources(SelectedModsList, "SelectedModsList");
            tableLayoutPanel1.SetColumnSpan(SelectedModsList, 2);
            SelectedModsList.FormattingEnabled = true;
            SelectedModsList.Name = "SelectedModsList";
            ModOrderTooltip.SetToolTip(SelectedModsList, resources.GetString("SelectedModsList.ToolTip"));
            // 
            // RemoveModButton
            // 
            resources.ApplyResources(RemoveModButton, "RemoveModButton");
            RemoveModButton.Name = "RemoveModButton";
            ModOrderTooltip.SetToolTip(RemoveModButton, resources.GetString("RemoveModButton.ToolTip"));
            RemoveModButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(ArrangeModPosition);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            ModOrderTooltip.SetToolTip(flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.FlatStyle = FlatStyle.Flat;
            label3.Name = "label3";
            ModOrderTooltip.SetToolTip(label3, resources.GetString("label3.ToolTip"));
            // 
            // ArrangeModPosition
            // 
            resources.ApplyResources(ArrangeModPosition, "ArrangeModPosition");
            ArrangeModPosition.Name = "ArrangeModPosition";
            ModOrderTooltip.SetToolTip(ArrangeModPosition, resources.GetString("ArrangeModPosition.ToolTip"));
            ArrangeModPosition.ValueChanged += ArrangeModPosition_ValueChanged;
            // 
            // PlayButton
            // 
            resources.ApplyResources(PlayButton, "PlayButton");
            PlayButton.Name = "PlayButton";
            ModOrderTooltip.SetToolTip(PlayButton, resources.GetString("PlayButton.ToolTip"));
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // ModOrderTooltip
            // 
            ModOrderTooltip.ToolTipTitle = "Mod Order";
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.FormattingEnabled = true;
            comboBox1.Name = "comboBox1";
            ModOrderTooltip.SetToolTip(comboBox1, resources.GetString("comboBox1.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.Name = "label4";
            ModOrderTooltip.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            label4.Click += label4_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            ModOrderTooltip.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            ModOrderTooltip.SetToolTip(button2, resources.GetString("button2.ToolTip"));
            button2.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            AcceptButton = PlayButton;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(splitContainer1);
            Controls.Add(PlayButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Launcher";
            SizeGripStyle = SizeGripStyle.Hide;
            ModOrderTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ArrangeModPosition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayButton;
        private SplitContainer splitContainer1;
        private ListBox AvailableModsList;
        private Label label1;
        private ListBox SelectedModsList;
        private Label label2;
        private NumericUpDown ArrangeModPosition;
        private Button RemoveModButton;
        private Label label3;
        private ToolTip ModOrderTooltip;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddModButton;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}
