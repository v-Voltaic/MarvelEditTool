namespace MarvelEditTool
{
    partial class TableEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.animBox = new System.Windows.Forms.ListBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.extendButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.entryTabControl = new System.Windows.Forms.TabControl();
            this.structureTabPage = new System.Windows.Forms.TabPage();
            this.structureUnavailableLabel = new System.Windows.Forms.Label();
            this.structureLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.subEntryLabel = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.subEntryLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.subEntryListBox = new System.Windows.Forms.ListBox();
            this.subEntryButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subEntryUpButton = new System.Windows.Forms.Button();
            this.subEntryDownButton = new System.Windows.Forms.Button();
            this.commandLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.commandButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commandMoveUpButton = new System.Windows.Forms.Button();
            this.commandMoveDownButton = new System.Windows.Forms.Button();
            this.commandDetailLabel = new System.Windows.Forms.Label();
            this.commandDetailTextBox = new System.Windows.Forms.TextBox();
            this.rawDataTabPage = new System.Windows.Forms.TabPage();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.entryTabControl.SuspendLayout();
            this.structureTabPage.SuspendLayout();
            this.structureLayoutPanel.SuspendLayout();
            this.subEntryLayoutPanel.SuspendLayout();
            this.subEntryButtonPanel.SuspendLayout();
            this.commandLayoutPanel.SuspendLayout();
            this.commandButtonPanel.SuspendLayout();
            this.rawDataTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.analyzeButton);
            this.splitContainer1.Panel1.Controls.Add(this.filenameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.saveButton);
            this.splitContainer1.Panel1.Controls.Add(this.openButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(843, 568);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 0;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(462, 4);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(93, 17);
            this.filenameLabel.TabIndex = 2;
            this.filenameLabel.Text = "no file loaded";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(140, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 31);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "&Save (Ctrl+S)";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.Location = new System.Drawing.Point(4, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(129, 31);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "&Open (Ctrl+O)";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.animBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(843, 526);
            this.splitContainer2.SplitterDistance = 424;
            this.splitContainer2.TabIndex = 0;
            // 
            // animBox
            // 
            this.animBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animBox.Enabled = false;
            this.animBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animBox.FormattingEnabled = true;
            this.animBox.ItemHeight = 23;
            this.animBox.Location = new System.Drawing.Point(0, 0);
            this.animBox.Name = "animBox";
            this.animBox.ScrollAlwaysVisible = true;
            this.animBox.Size = new System.Drawing.Size(424, 526);
            this.animBox.TabIndex = 0;
            this.animBox.SelectedIndexChanged += new System.EventHandler(this.animBox_SelectedIndexChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            //
            this.splitContainer3.Panel2.Controls.Add(this.entryTabControl);
            this.splitContainer3.Size = new System.Drawing.Size(415, 526);
            this.splitContainer3.SplitterDistance = 179;
            this.splitContainer3.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.importButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.extendButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sizeLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 179);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.AutoSize = true;
            this.importButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importButton.Enabled = false;
            this.importButton.Location = new System.Drawing.Point(3, 31);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(409, 27);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "&Import (Ctrl+R)";
            this.importButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.AutoSize = true;
            this.exportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportButton.Enabled = false;
            this.exportButton.Location = new System.Drawing.Point(3, 64);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(409, 27);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "&Export (Ctrl+E)";
            this.exportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // extendButton
            // 
            this.extendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extendButton.AutoSize = true;
            this.extendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.extendButton.Enabled = false;
            this.extendButton.Location = new System.Drawing.Point(3, 97);
            this.extendButton.Name = "extendButton";
            this.extendButton.Size = new System.Drawing.Size(409, 27);
            this.extendButton.TabIndex = 3;
            this.extendButton.Text = "+ Ex&tend List  (Ctrl+T)";
            this.extendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.extendButton.UseVisualStyleBackColor = true;
            this.extendButton.Click += new System.EventHandler(this.extendButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(3, 127);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(44, 17);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "ready";
            //
            // entryTabControl
            //
            this.entryTabControl.Controls.Add(this.structureTabPage);
            this.entryTabControl.Controls.Add(this.rawDataTabPage);
            this.entryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryTabControl.Location = new System.Drawing.Point(0, 0);
            this.entryTabControl.Name = "entryTabControl";
            this.entryTabControl.SelectedIndex = 0;
            this.entryTabControl.Size = new System.Drawing.Size(415, 343);
            this.entryTabControl.TabIndex = 0;
            //
            // structureTabPage
            //
            this.structureTabPage.Controls.Add(this.structureLayoutPanel);
            this.structureTabPage.Controls.Add(this.structureUnavailableLabel);
            this.structureTabPage.Location = new System.Drawing.Point(4, 25);
            this.structureTabPage.Name = "structureTabPage";
            this.structureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.structureTabPage.Size = new System.Drawing.Size(407, 314);
            this.structureTabPage.TabIndex = 0;
            this.structureTabPage.Text = "Structure";
            this.structureTabPage.UseVisualStyleBackColor = true;
            //
            // structureUnavailableLabel
            //
            this.structureUnavailableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structureUnavailableLabel.Location = new System.Drawing.Point(3, 3);
            this.structureUnavailableLabel.Name = "structureUnavailableLabel";
            this.structureUnavailableLabel.Size = new System.Drawing.Size(401, 308);
            this.structureUnavailableLabel.TabIndex = 1;
            this.structureUnavailableLabel.Text = "Structured view is only available for AnmChr entries.";
            this.structureUnavailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.structureUnavailableLabel.Visible = false;
            //
            // structureLayoutPanel
            //
            this.structureLayoutPanel.ColumnCount = 2;
            this.structureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.structureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.structureLayoutPanel.Controls.Add(this.subEntryLabel, 0, 0);
            this.structureLayoutPanel.Controls.Add(this.commandLabel, 1, 0);
            this.structureLayoutPanel.Controls.Add(this.subEntryLayoutPanel, 0, 1);
            this.structureLayoutPanel.Controls.Add(this.commandLayoutPanel, 1, 1);
            this.structureLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structureLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.structureLayoutPanel.Name = "structureLayoutPanel";
            this.structureLayoutPanel.RowCount = 2;
            this.structureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.structureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.structureLayoutPanel.Size = new System.Drawing.Size(401, 308);
            this.structureLayoutPanel.TabIndex = 0;
            //
            // subEntryLabel
            //
            this.subEntryLabel.AutoSize = true;
            this.subEntryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subEntryLabel.Location = new System.Drawing.Point(3, 0);
            this.subEntryLabel.Name = "subEntryLabel";
            this.subEntryLabel.Size = new System.Drawing.Size(154, 18);
            this.subEntryLabel.TabIndex = 0;
            this.subEntryLabel.Text = "Command blocks";
            this.subEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // commandLabel
            //
            this.commandLabel.AutoSize = true;
            this.commandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandLabel.Location = new System.Drawing.Point(163, 0);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(235, 18);
            this.commandLabel.TabIndex = 1;
            this.commandLabel.Text = "Commands";
            this.commandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // subEntryLayoutPanel
            //
            this.subEntryLayoutPanel.ColumnCount = 1;
            this.subEntryLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subEntryLayoutPanel.Controls.Add(this.subEntryListBox, 0, 0);
            this.subEntryLayoutPanel.Controls.Add(this.subEntryButtonPanel, 0, 1);
            this.subEntryLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subEntryLayoutPanel.Location = new System.Drawing.Point(3, 21);
            this.subEntryLayoutPanel.Name = "subEntryLayoutPanel";
            this.subEntryLayoutPanel.RowCount = 2;
            this.subEntryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subEntryLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.subEntryLayoutPanel.Size = new System.Drawing.Size(154, 284);
            this.subEntryLayoutPanel.TabIndex = 2;
            //
            // subEntryListBox
            //
            this.subEntryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subEntryListBox.Enabled = false;
            this.subEntryListBox.FormattingEnabled = true;
            this.subEntryListBox.IntegralHeight = false;
            this.subEntryListBox.ItemHeight = 16;
            this.subEntryListBox.Location = new System.Drawing.Point(3, 3);
            this.subEntryListBox.Name = "subEntryListBox";
            this.subEntryListBox.Size = new System.Drawing.Size(148, 246);
            this.subEntryListBox.TabIndex = 0;
            this.subEntryListBox.SelectedIndexChanged += new System.EventHandler(this.subEntryListBox_SelectedIndexChanged);
            //
            // subEntryButtonPanel
            //
            this.subEntryButtonPanel.AutoSize = true;
            this.subEntryButtonPanel.Controls.Add(this.subEntryUpButton);
            this.subEntryButtonPanel.Controls.Add(this.subEntryDownButton);
            this.subEntryButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subEntryButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.subEntryButtonPanel.Location = new System.Drawing.Point(3, 255);
            this.subEntryButtonPanel.Name = "subEntryButtonPanel";
            this.subEntryButtonPanel.Size = new System.Drawing.Size(148, 26);
            this.subEntryButtonPanel.TabIndex = 1;
            //
            // subEntryUpButton
            //
            this.subEntryUpButton.AutoSize = true;
            this.subEntryUpButton.Enabled = false;
            this.subEntryUpButton.Location = new System.Drawing.Point(3, 3);
            this.subEntryUpButton.Name = "subEntryUpButton";
            this.subEntryUpButton.Size = new System.Drawing.Size(70, 23);
            this.subEntryUpButton.TabIndex = 0;
            this.subEntryUpButton.Text = "Move Up";
            this.subEntryUpButton.UseVisualStyleBackColor = true;
            this.subEntryUpButton.Click += new System.EventHandler(this.subEntryUpButton_Click);
            //
            // subEntryDownButton
            //
            this.subEntryDownButton.AutoSize = true;
            this.subEntryDownButton.Enabled = false;
            this.subEntryDownButton.Location = new System.Drawing.Point(79, 3);
            this.subEntryDownButton.Name = "subEntryDownButton";
            this.subEntryDownButton.Size = new System.Drawing.Size(66, 23);
            this.subEntryDownButton.TabIndex = 1;
            this.subEntryDownButton.Text = "Move Down";
            this.subEntryDownButton.UseVisualStyleBackColor = true;
            this.subEntryDownButton.Click += new System.EventHandler(this.subEntryDownButton_Click);
            //
            // commandLayoutPanel
            //
            this.commandLayoutPanel.ColumnCount = 1;
            this.commandLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commandLayoutPanel.Controls.Add(this.commandListBox, 0, 0);
            this.commandLayoutPanel.Controls.Add(this.commandButtonPanel, 0, 1);
            this.commandLayoutPanel.Controls.Add(this.commandDetailLabel, 0, 2);
            this.commandLayoutPanel.Controls.Add(this.commandDetailTextBox, 0, 3);
            this.commandLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLayoutPanel.Location = new System.Drawing.Point(163, 21);
            this.commandLayoutPanel.Name = "commandLayoutPanel";
            this.commandLayoutPanel.RowCount = 4;
            this.commandLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.commandLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.commandLayoutPanel.Size = new System.Drawing.Size(235, 284);
            this.commandLayoutPanel.TabIndex = 3;
            //
            // commandListBox
            //
            this.commandListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandListBox.Enabled = false;
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.IntegralHeight = false;
            this.commandListBox.ItemHeight = 16;
            this.commandListBox.Location = new System.Drawing.Point(3, 3);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(229, 138);
            this.commandListBox.TabIndex = 0;
            this.commandListBox.SelectedIndexChanged += new System.EventHandler(this.commandListBox_SelectedIndexChanged);
            //
            // commandButtonPanel
            //
            this.commandButtonPanel.AutoSize = true;
            this.commandButtonPanel.Controls.Add(this.commandMoveUpButton);
            this.commandButtonPanel.Controls.Add(this.commandMoveDownButton);
            this.commandButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.commandButtonPanel.Location = new System.Drawing.Point(3, 147);
            this.commandButtonPanel.Name = "commandButtonPanel";
            this.commandButtonPanel.Size = new System.Drawing.Size(229, 29);
            this.commandButtonPanel.TabIndex = 1;
            //
            // commandMoveUpButton
            //
            this.commandMoveUpButton.AutoSize = true;
            this.commandMoveUpButton.Enabled = false;
            this.commandMoveUpButton.Location = new System.Drawing.Point(3, 3);
            this.commandMoveUpButton.Name = "commandMoveUpButton";
            this.commandMoveUpButton.Size = new System.Drawing.Size(90, 23);
            this.commandMoveUpButton.TabIndex = 0;
            this.commandMoveUpButton.Text = "Move Up";
            this.commandMoveUpButton.UseVisualStyleBackColor = true;
            this.commandMoveUpButton.Click += new System.EventHandler(this.commandMoveUpButton_Click);
            //
            // commandMoveDownButton
            //
            this.commandMoveDownButton.AutoSize = true;
            this.commandMoveDownButton.Enabled = false;
            this.commandMoveDownButton.Location = new System.Drawing.Point(99, 3);
            this.commandMoveDownButton.Name = "commandMoveDownButton";
            this.commandMoveDownButton.Size = new System.Drawing.Size(96, 23);
            this.commandMoveDownButton.TabIndex = 1;
            this.commandMoveDownButton.Text = "Move Down";
            this.commandMoveDownButton.UseVisualStyleBackColor = true;
            this.commandMoveDownButton.Click += new System.EventHandler(this.commandMoveDownButton_Click);
            //
            // commandDetailLabel
            //
            this.commandDetailLabel.AutoSize = true;
            this.commandDetailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandDetailLabel.Location = new System.Drawing.Point(3, 179);
            this.commandDetailLabel.Name = "commandDetailLabel";
            this.commandDetailLabel.Size = new System.Drawing.Size(229, 17);
            this.commandDetailLabel.TabIndex = 2;
            this.commandDetailLabel.Text = "Command details";
            //
            // commandDetailTextBox
            //
            this.commandDetailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandDetailTextBox.Location = new System.Drawing.Point(3, 199);
            this.commandDetailTextBox.Multiline = true;
            this.commandDetailTextBox.Name = "commandDetailTextBox";
            this.commandDetailTextBox.ReadOnly = true;
            this.commandDetailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandDetailTextBox.Size = new System.Drawing.Size(229, 82);
            this.commandDetailTextBox.TabIndex = 3;
            //
            // rawDataTabPage
            //
            this.rawDataTabPage.Controls.Add(this.dataTextBox);
            this.rawDataTabPage.Location = new System.Drawing.Point(4, 25);
            this.rawDataTabPage.Name = "rawDataTabPage";
            this.rawDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rawDataTabPage.Size = new System.Drawing.Size(407, 314);
            this.rawDataTabPage.TabIndex = 1;
            this.rawDataTabPage.Text = "Raw Data";
            this.rawDataTabPage.UseVisualStyleBackColor = true;
            //
            // dataTextBox
            //
            this.dataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.Location = new System.Drawing.Point(3, 3);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(401, 308);
            this.dataTextBox.TabIndex = 0;
            this.dataTextBox.WordWrap = false;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Location = new System.Drawing.Point(301, 3);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(155, 31);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "&Analyze (check logs)";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // TableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 568);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TableEditor";
            this.Text = "TableEditor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.entryTabControl.ResumeLayout(false);
            this.structureTabPage.ResumeLayout(false);
            this.structureLayoutPanel.ResumeLayout(false);
            this.structureLayoutPanel.PerformLayout();
            this.subEntryLayoutPanel.ResumeLayout(false);
            this.subEntryLayoutPanel.PerformLayout();
            this.subEntryButtonPanel.ResumeLayout(false);
            this.subEntryButtonPanel.PerformLayout();
            this.commandLayoutPanel.ResumeLayout(false);
            this.commandLayoutPanel.PerformLayout();
            this.commandButtonPanel.ResumeLayout(false);
            this.commandButtonPanel.PerformLayout();
            this.rawDataTabPage.ResumeLayout(false);
            this.rawDataTabPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox animBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button extendButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl entryTabControl;
        private System.Windows.Forms.TabPage structureTabPage;
        private System.Windows.Forms.TabPage rawDataTabPage;
        private System.Windows.Forms.TableLayoutPanel structureLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel subEntryLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel commandLayoutPanel;
        private System.Windows.Forms.ListBox subEntryListBox;
        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.FlowLayoutPanel subEntryButtonPanel;
        private System.Windows.Forms.FlowLayoutPanel commandButtonPanel;
        private System.Windows.Forms.Button subEntryUpButton;
        private System.Windows.Forms.Button subEntryDownButton;
        private System.Windows.Forms.Button commandMoveUpButton;
        private System.Windows.Forms.Button commandMoveDownButton;
        private System.Windows.Forms.Label subEntryLabel;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Label commandDetailLabel;
        private System.Windows.Forms.TextBox commandDetailTextBox;
        private System.Windows.Forms.Label structureUnavailableLabel;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Button analyzeButton;
    }
}

