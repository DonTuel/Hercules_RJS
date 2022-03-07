namespace Hercules_RJS
{
    partial class RJSMain
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
                Event1.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RJSMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainReconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainSubmit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPrePostJob = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPreJobFileBrowse = new System.Windows.Forms.Button();
            this.txtPreJobFile = new System.Windows.Forms.TextBox();
            this.lblPreJobSubmit = new System.Windows.Forms.Label();
            this.txtPostJobFile = new System.Windows.Forms.TextBox();
            this.btnPostJobFileBrowse = new System.Windows.Forms.Button();
            this.lblPostJobSubmit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.rbPreJobFirstFile = new System.Windows.Forms.RadioButton();
            this.rbPreJobEveryFile = new System.Windows.Forms.RadioButton();
            this.rbPreJobInPlaceOfFile = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.rbPostJobFirstFile = new System.Windows.Forms.RadioButton();
            this.rbPostJobEveryFile = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.rbPostJobNone = new System.Windows.Forms.RadioButton();
            this.rbPostJobFile = new System.Windows.Forms.RadioButton();
            this.rbPostJobText = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.rbPreJobFile = new System.Windows.Forms.RadioButton();
            this.rbPreJobText = new System.Windows.Forms.RadioButton();
            this.rbPreJobNone = new System.Windows.Forms.RadioButton();
            this.tpJobCustomization = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomization = new Microsoft.TeamFoundation.Client.DataGridViewWithDetails();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbFoldUpperCase = new System.Windows.Forms.CheckBox();
            this.rtbCustomizationHelp = new System.Windows.Forms.RichTextBox();
            this.tpFiles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.expTreeView = new ExpTreeLib.ExpTree();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cboxExpTreeViewLocations = new System.Windows.Forms.ComboBox();
            this.lvDirectory = new System.Windows.Forms.ListView();
            this.ColumnHeaderHame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderAttributes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderModifyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpConnection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHerculesAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHerculesPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.cbDisconnectAfterSubmit = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.rbConnectAtSubmit = new System.Windows.Forms.RadioButton();
            this.rbConnectAtStartup = new System.Windows.Forms.RadioButton();
            this.rbDoNotConnect = new System.Windows.Forms.RadioButton();
            this.tpDiagnostics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbVerboseLogging = new System.Windows.Forms.CheckBox();
            this.cbProtocolLogging = new System.Windows.Forms.CheckBox();
            this.cbDumpPackets = new System.Windows.Forms.CheckBox();
            this.cbDisplayStatistics = new System.Windows.Forms.CheckBox();
            this.cbSubmitToFile = new System.Windows.Forms.CheckBox();
            this.txtSubmitToFile = new System.Windows.Forms.TextBox();
            this.btnSubmitToFileBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiagnosticMessages = new System.Windows.Forms.RichTextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmsReplacement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsReplacementHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPreJobText = new twEditControls.EditBox();
            this.txtPostJobText = new twEditControls.EditBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpPrePostJob.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tpJobCustomization.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomization)).BeginInit();
            this.tpFiles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tpConnection.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tpDiagnostics.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cmsReplacement.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainView,
            this.mnuMainTools,
            this.mnuMainHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainReconnect,
            this.toolStripMenuItem1,
            this.mnuMainExit});
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainFile.Text = "&File";
            // 
            // mnuMainReconnect
            // 
            this.mnuMainReconnect.Name = "mnuMainReconnect";
            this.mnuMainReconnect.Size = new System.Drawing.Size(130, 22);
            this.mnuMainReconnect.Text = "Reconnect";
            this.mnuMainReconnect.Click += new System.EventHandler(this.mnuMainReconnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // mnuMainExit
            // 
            this.mnuMainExit.Name = "mnuMainExit";
            this.mnuMainExit.Size = new System.Drawing.Size(130, 22);
            this.mnuMainExit.Text = "E&xit";
            this.mnuMainExit.Click += new System.EventHandler(this.mnuMainExit_Click);
            // 
            // mnuMainView
            // 
            this.mnuMainView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainLargeIcons,
            this.mnuMainSmallIcons,
            this.mnuMainList,
            this.mnuMainDetails});
            this.mnuMainView.Name = "mnuMainView";
            this.mnuMainView.Size = new System.Drawing.Size(44, 20);
            this.mnuMainView.Text = "&View";
            // 
            // mnuMainLargeIcons
            // 
            this.mnuMainLargeIcons.Name = "mnuMainLargeIcons";
            this.mnuMainLargeIcons.Size = new System.Drawing.Size(134, 22);
            this.mnuMainLargeIcons.Text = "Lar&ge Icons";
            this.mnuMainLargeIcons.Click += new System.EventHandler(this.mnuMainLargeIcons_Click);
            // 
            // mnuMainSmallIcons
            // 
            this.mnuMainSmallIcons.Name = "mnuMainSmallIcons";
            this.mnuMainSmallIcons.Size = new System.Drawing.Size(134, 22);
            this.mnuMainSmallIcons.Text = "S&mall Icons";
            this.mnuMainSmallIcons.Click += new System.EventHandler(this.mnuMainSmallIcons_Click);
            // 
            // mnuMainList
            // 
            this.mnuMainList.Name = "mnuMainList";
            this.mnuMainList.Size = new System.Drawing.Size(134, 22);
            this.mnuMainList.Text = "&List";
            this.mnuMainList.Click += new System.EventHandler(this.mnuMainList_Click);
            // 
            // mnuMainDetails
            // 
            this.mnuMainDetails.Name = "mnuMainDetails";
            this.mnuMainDetails.Size = new System.Drawing.Size(134, 22);
            this.mnuMainDetails.Text = "&Details";
            this.mnuMainDetails.Click += new System.EventHandler(this.mnuMainDetails_Click);
            // 
            // mnuMainTools
            // 
            this.mnuMainTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainSubmit});
            this.mnuMainTools.Name = "mnuMainTools";
            this.mnuMainTools.Size = new System.Drawing.Size(46, 20);
            this.mnuMainTools.Text = "Tools";
            // 
            // mnuMainSubmit
            // 
            this.mnuMainSubmit.Name = "mnuMainSubmit";
            this.mnuMainSubmit.Size = new System.Drawing.Size(112, 22);
            this.mnuMainSubmit.Text = "Submit";
            this.mnuMainSubmit.Click += new System.EventHandler(this.mnuMainSubmit_Click);
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainAbout});
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuMainHelp.Text = "Help";
            // 
            // mnuMainAbout
            // 
            this.mnuMainAbout.Name = "mnuMainAbout";
            this.mnuMainAbout.Size = new System.Drawing.Size(185, 22);
            this.mnuMainAbout.Text = "About Hercules RJS...";
            this.mnuMainAbout.Click += new System.EventHandler(this.mnuMainAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPrePostJob);
            this.tabControl1.Controls.Add(this.tpJobCustomization);
            this.tabControl1.Controls.Add(this.tpFiles);
            this.tabControl1.Controls.Add(this.tpConnection);
            this.tabControl1.Controls.Add(this.tpDiagnostics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel12.SetRowSpan(this.tabControl1, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 451);
            this.tabControl1.TabIndex = 3;
            // 
            // tpPrePostJob
            // 
            this.tpPrePostJob.Controls.Add(this.tableLayoutPanel4);
            this.tpPrePostJob.Location = new System.Drawing.Point(4, 22);
            this.tpPrePostJob.Name = "tpPrePostJob";
            this.tpPrePostJob.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrePostJob.Size = new System.Drawing.Size(857, 425);
            this.tpPrePostJob.TabIndex = 1;
            this.tpPrePostJob.Text = "Pre-Job/Post-Job";
            this.tpPrePostJob.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel4.Controls.Add(this.btnPreJobFileBrowse, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtPreJobFile, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblPreJobSubmit, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtPostJobFile, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnPostJobFileBrowse, 6, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblPostJobSubmit, 4, 5);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPreJobText, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtPostJobText, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 5, 5);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(851, 419);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnPreJobFileBrowse
            // 
            this.btnPreJobFileBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreJobFileBrowse.Enabled = false;
            this.btnPreJobFileBrowse.Location = new System.Drawing.Point(343, 45);
            this.btnPreJobFileBrowse.Margin = new System.Windows.Forms.Padding(1);
            this.btnPreJobFileBrowse.Name = "btnPreJobFileBrowse";
            this.btnPreJobFileBrowse.Size = new System.Drawing.Size(76, 20);
            this.btnPreJobFileBrowse.TabIndex = 2;
            this.btnPreJobFileBrowse.Text = "Browse";
            this.btnPreJobFileBrowse.UseVisualStyleBackColor = true;
            this.btnPreJobFileBrowse.Click += new System.EventHandler(this.btnPreJobFileBrowse_Click);
            // 
            // txtPreJobFile
            // 
            this.txtPreJobFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreJobFile.Enabled = false;
            this.txtPreJobFile.Location = new System.Drawing.Point(115, 47);
            this.txtPreJobFile.Name = "txtPreJobFile";
            this.txtPreJobFile.Size = new System.Drawing.Size(224, 20);
            this.txtPreJobFile.TabIndex = 3;
            this.txtPreJobFile.TextChanged += new System.EventHandler(this.txtPreJobFile_TextChanged);
            // 
            // lblPreJobSubmit
            // 
            this.lblPreJobSubmit.AutoSize = true;
            this.lblPreJobSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreJobSubmit.Enabled = false;
            this.lblPreJobSubmit.Location = new System.Drawing.Point(3, 353);
            this.lblPreJobSubmit.Name = "lblPreJobSubmit";
            this.lblPreJobSubmit.Size = new System.Drawing.Size(106, 22);
            this.lblPreJobSubmit.TabIndex = 8;
            this.lblPreJobSubmit.Text = "Submit above job:";
            this.lblPreJobSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPostJobFile
            // 
            this.txtPostJobFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostJobFile.Enabled = false;
            this.txtPostJobFile.Location = new System.Drawing.Point(545, 47);
            this.txtPostJobFile.Name = "txtPostJobFile";
            this.txtPostJobFile.Size = new System.Drawing.Size(224, 20);
            this.txtPostJobFile.TabIndex = 10;
            this.txtPostJobFile.TextChanged += new System.EventHandler(this.txtPostJobFile_TextChanged);
            // 
            // btnPostJobFileBrowse
            // 
            this.btnPostJobFileBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPostJobFileBrowse.Enabled = false;
            this.btnPostJobFileBrowse.Location = new System.Drawing.Point(773, 45);
            this.btnPostJobFileBrowse.Margin = new System.Windows.Forms.Padding(1);
            this.btnPostJobFileBrowse.Name = "btnPostJobFileBrowse";
            this.btnPostJobFileBrowse.Size = new System.Drawing.Size(77, 20);
            this.btnPostJobFileBrowse.TabIndex = 11;
            this.btnPostJobFileBrowse.Text = "Browse";
            this.btnPostJobFileBrowse.UseVisualStyleBackColor = true;
            this.btnPostJobFileBrowse.Click += new System.EventHandler(this.btnPostJobFileBrowse_Click);
            // 
            // lblPostJobSubmit
            // 
            this.lblPostJobSubmit.AutoSize = true;
            this.lblPostJobSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostJobSubmit.Enabled = false;
            this.lblPostJobSubmit.Location = new System.Drawing.Point(433, 353);
            this.lblPostJobSubmit.Name = "lblPostJobSubmit";
            this.lblPostJobSubmit.Size = new System.Drawing.Size(106, 22);
            this.lblPostJobSubmit.TabIndex = 14;
            this.lblPostJobSubmit.Text = "Submit above text:";
            this.lblPostJobSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pre-Job Submit Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Post-Job Submit Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(423, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel4.SetRowSpan(this.groupBox1, 8);
            this.groupBox1.Size = new System.Drawing.Size(4, 419);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.rbPreJobFirstFile, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.rbPreJobEveryFile, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.rbPreJobInPlaceOfFile, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(112, 353);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel7, 3);
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(230, 66);
            this.tableLayoutPanel7.TabIndex = 25;
            // 
            // rbPreJobFirstFile
            // 
            this.rbPreJobFirstFile.AutoSize = true;
            this.rbPreJobFirstFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPreJobFirstFile.Location = new System.Drawing.Point(3, 3);
            this.rbPreJobFirstFile.Name = "rbPreJobFirstFile";
            this.rbPreJobFirstFile.Size = new System.Drawing.Size(224, 16);
            this.rbPreJobFirstFile.TabIndex = 22;
            this.rbPreJobFirstFile.TabStop = true;
            this.rbPreJobFirstFile.Text = "Before first selected file";
            this.rbPreJobFirstFile.UseVisualStyleBackColor = true;
            this.rbPreJobFirstFile.CheckedChanged += new System.EventHandler(this.rbPreJobFirst_CheckedChanged);
            // 
            // rbPreJobEveryFile
            // 
            this.rbPreJobEveryFile.AutoSize = true;
            this.rbPreJobEveryFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPreJobEveryFile.Location = new System.Drawing.Point(3, 25);
            this.rbPreJobEveryFile.Name = "rbPreJobEveryFile";
            this.rbPreJobEveryFile.Size = new System.Drawing.Size(224, 16);
            this.rbPreJobEveryFile.TabIndex = 23;
            this.rbPreJobEveryFile.TabStop = true;
            this.rbPreJobEveryFile.Text = "Before every selected file";
            this.rbPreJobEveryFile.UseVisualStyleBackColor = true;
            this.rbPreJobEveryFile.CheckedChanged += new System.EventHandler(this.rbPreJobEvery_CheckedChanged);
            // 
            // rbPreJobInPlaceOfFile
            // 
            this.rbPreJobInPlaceOfFile.AutoSize = true;
            this.rbPreJobInPlaceOfFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPreJobInPlaceOfFile.Location = new System.Drawing.Point(3, 47);
            this.rbPreJobInPlaceOfFile.Name = "rbPreJobInPlaceOfFile";
            this.rbPreJobInPlaceOfFile.Size = new System.Drawing.Size(224, 16);
            this.rbPreJobInPlaceOfFile.TabIndex = 24;
            this.rbPreJobInPlaceOfFile.TabStop = true;
            this.rbPreJobInPlaceOfFile.Text = "In place of any selected files";
            this.rbPreJobInPlaceOfFile.UseVisualStyleBackColor = true;
            this.rbPreJobInPlaceOfFile.CheckedChanged += new System.EventHandler(this.rbPreJobInPlaceOfFile_CheckedChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.rbPostJobFirstFile, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.rbPostJobEveryFile, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(542, 353);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel8, 3);
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(230, 66);
            this.tableLayoutPanel8.TabIndex = 27;
            // 
            // rbPostJobFirstFile
            // 
            this.rbPostJobFirstFile.AutoSize = true;
            this.rbPostJobFirstFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPostJobFirstFile.Location = new System.Drawing.Point(3, 3);
            this.rbPostJobFirstFile.Name = "rbPostJobFirstFile";
            this.rbPostJobFirstFile.Size = new System.Drawing.Size(224, 16);
            this.rbPostJobFirstFile.TabIndex = 24;
            this.rbPostJobFirstFile.TabStop = true;
            this.rbPostJobFirstFile.Text = "After first selected file";
            this.rbPostJobFirstFile.UseVisualStyleBackColor = true;
            this.rbPostJobFirstFile.CheckedChanged += new System.EventHandler(this.rbPostJobFirst_CheckedChanged);
            // 
            // rbPostJobEveryFile
            // 
            this.rbPostJobEveryFile.AutoSize = true;
            this.rbPostJobEveryFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPostJobEveryFile.Location = new System.Drawing.Point(3, 25);
            this.rbPostJobEveryFile.Name = "rbPostJobEveryFile";
            this.rbPostJobEveryFile.Size = new System.Drawing.Size(224, 16);
            this.rbPostJobEveryFile.TabIndex = 26;
            this.rbPostJobEveryFile.TabStop = true;
            this.rbPostJobEveryFile.Text = "After every selected file";
            this.rbPostJobEveryFile.UseVisualStyleBackColor = true;
            this.rbPostJobEveryFile.CheckedChanged += new System.EventHandler(this.rbPostJobEvery_CheckedChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.rbPostJobNone, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.rbPostJobFile, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.rbPostJobText, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(430, 22);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel9, 3);
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(112, 66);
            this.tableLayoutPanel9.TabIndex = 28;
            // 
            // rbPostJobNone
            // 
            this.rbPostJobNone.AutoSize = true;
            this.rbPostJobNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPostJobNone.Location = new System.Drawing.Point(3, 3);
            this.rbPostJobNone.Name = "rbPostJobNone";
            this.rbPostJobNone.Size = new System.Drawing.Size(106, 16);
            this.rbPostJobNone.TabIndex = 0;
            this.rbPostJobNone.Text = "None";
            this.rbPostJobNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPostJobNone.UseVisualStyleBackColor = true;
            this.rbPostJobNone.CheckedChanged += new System.EventHandler(this.rbPostJobNone_CheckedChanged);
            // 
            // rbPostJobFile
            // 
            this.rbPostJobFile.AutoSize = true;
            this.rbPostJobFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPostJobFile.Location = new System.Drawing.Point(3, 25);
            this.rbPostJobFile.Name = "rbPostJobFile";
            this.rbPostJobFile.Size = new System.Drawing.Size(106, 16);
            this.rbPostJobFile.TabIndex = 1;
            this.rbPostJobFile.Text = "Job file:";
            this.rbPostJobFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPostJobFile.UseVisualStyleBackColor = true;
            this.rbPostJobFile.CheckedChanged += new System.EventHandler(this.rbPostJobFile_CheckedChanged);
            // 
            // rbPostJobText
            // 
            this.rbPostJobText.AutoSize = true;
            this.rbPostJobText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPostJobText.Location = new System.Drawing.Point(3, 47);
            this.rbPostJobText.Name = "rbPostJobText";
            this.rbPostJobText.Size = new System.Drawing.Size(106, 16);
            this.rbPostJobText.TabIndex = 2;
            this.rbPostJobText.Text = "Job text:";
            this.rbPostJobText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPostJobText.UseVisualStyleBackColor = true;
            this.rbPostJobText.CheckedChanged += new System.EventHandler(this.rbPostJobText_CheckedChanged);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.rbPreJobFile, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.rbPreJobText, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.rbPreJobNone, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel10, 3);
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(112, 66);
            this.tableLayoutPanel10.TabIndex = 29;
            // 
            // rbPreJobFile
            // 
            this.rbPreJobFile.AutoSize = true;
            this.rbPreJobFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPreJobFile.Location = new System.Drawing.Point(3, 25);
            this.rbPreJobFile.Name = "rbPreJobFile";
            this.rbPreJobFile.Size = new System.Drawing.Size(106, 16);
            this.rbPreJobFile.TabIndex = 0;
            this.rbPreJobFile.Text = "Job file:";
            this.rbPreJobFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPreJobFile.UseVisualStyleBackColor = true;
            this.rbPreJobFile.CheckedChanged += new System.EventHandler(this.rbPreJobFile_CheckedChanged);
            // 
            // rbPreJobText
            // 
            this.rbPreJobText.AutoSize = true;
            this.rbPreJobText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPreJobText.Location = new System.Drawing.Point(3, 47);
            this.rbPreJobText.Name = "rbPreJobText";
            this.rbPreJobText.Size = new System.Drawing.Size(106, 16);
            this.rbPreJobText.TabIndex = 1;
            this.rbPreJobText.Text = "Job text:";
            this.rbPreJobText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPreJobText.UseVisualStyleBackColor = true;
            this.rbPreJobText.CheckedChanged += new System.EventHandler(this.rbPreJobText_CheckedChanged);
            // 
            // rbPreJobNone
            // 
            this.rbPreJobNone.AutoSize = true;
            this.rbPreJobNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbPreJobNone.Location = new System.Drawing.Point(3, 3);
            this.rbPreJobNone.Name = "rbPreJobNone";
            this.rbPreJobNone.Size = new System.Drawing.Size(106, 16);
            this.rbPreJobNone.TabIndex = 2;
            this.rbPreJobNone.Text = "None";
            this.rbPreJobNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPreJobNone.UseVisualStyleBackColor = true;
            this.rbPreJobNone.CheckedChanged += new System.EventHandler(this.rbPreJobNone_CheckedChanged);
            // 
            // tpJobCustomization
            // 
            this.tpJobCustomization.Controls.Add(this.tableLayoutPanel5);
            this.tpJobCustomization.Location = new System.Drawing.Point(4, 22);
            this.tpJobCustomization.Name = "tpJobCustomization";
            this.tpJobCustomization.Size = new System.Drawing.Size(857, 425);
            this.tpJobCustomization.TabIndex = 4;
            this.tpJobCustomization.Text = "Job Customization";
            this.tpJobCustomization.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 9;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.dgvCustomization, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.ckbFoldUpperCase, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.rtbCustomizationHelp, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(857, 425);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // dgvCustomization
            // 
            this.dgvCustomization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomization.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomization.DetailsBackColor = System.Drawing.SystemColors.Window;
            this.dgvCustomization.DetailsCollapsedImage = null;
            this.dgvCustomization.DetailsExpandedImage = null;
            this.dgvCustomization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomization.InitialExpandDetails = true;
            this.dgvCustomization.Location = new System.Drawing.Point(143, 27);
            this.dgvCustomization.Name = "dgvCustomization";
            this.tableLayoutPanel5.SetRowSpan(this.dgvCustomization, 8);
            this.dgvCustomization.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomization.Size = new System.Drawing.Size(454, 371);
            this.dgvCustomization.TabIndex = 3;
            this.dgvCustomization.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomization_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Field Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 205;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Replacement";
            this.Column2.Name = "Column2";
            this.Column2.Width = 205;
            // 
            // ckbFoldUpperCase
            // 
            this.ckbFoldUpperCase.AutoSize = true;
            this.ckbFoldUpperCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbFoldUpperCase.Location = new System.Drawing.Point(3, 27);
            this.ckbFoldUpperCase.Name = "ckbFoldUpperCase";
            this.ckbFoldUpperCase.Size = new System.Drawing.Size(114, 18);
            this.ckbFoldUpperCase.TabIndex = 4;
            this.ckbFoldUpperCase.Text = "Fold Upper Case";
            this.ckbFoldUpperCase.UseVisualStyleBackColor = true;
            // 
            // rtbCustomizationHelp
            // 
            this.rtbCustomizationHelp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tableLayoutPanel5.SetColumnSpan(this.rtbCustomizationHelp, 5);
            this.rtbCustomizationHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCustomizationHelp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCustomizationHelp.Location = new System.Drawing.Point(603, 27);
            this.rtbCustomizationHelp.Name = "rtbCustomizationHelp";
            this.rtbCustomizationHelp.ReadOnly = true;
            this.tableLayoutPanel5.SetRowSpan(this.rtbCustomizationHelp, 8);
            this.rtbCustomizationHelp.Size = new System.Drawing.Size(231, 371);
            this.rtbCustomizationHelp.TabIndex = 5;
            this.rtbCustomizationHelp.Text = "";
            // 
            // tpFiles
            // 
            this.tpFiles.Controls.Add(this.tableLayoutPanel1);
            this.tpFiles.Location = new System.Drawing.Point(4, 22);
            this.tpFiles.Name = "tpFiles";
            this.tpFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiles.Size = new System.Drawing.Size(857, 425);
            this.tpFiles.TabIndex = 0;
            this.tpFiles.Text = "Files";
            this.tpFiles.UseVisualStyleBackColor = true;
            this.tpFiles.Click += new System.EventHandler(this.tpFiles_Click);
            this.tpFiles.Enter += new System.EventHandler(this.tpFiles_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.expTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.tableLayoutPanel1.SetRowSpan(this.splitContainer1, 3);
            this.splitContainer1.Size = new System.Drawing.Size(845, 413);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // expTreeView
            // 
            this.expTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.expTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expTreeView.Location = new System.Drawing.Point(0, 0);
            this.expTreeView.Name = "expTreeView";
            this.expTreeView.ShowRootLines = false;
            this.expTreeView.Size = new System.Drawing.Size(260, 413);
            this.expTreeView.StartUpDirectory = ExpTreeLib.ExpTree.StartDir.MyComputer;
            this.expTreeView.TabIndex = 0;
            this.expTreeView.ExpTreeNodeSelected += new ExpTreeLib.ExpTree.ExpTreeNodeSelectedEventHandler(this.expTreeView_ExpTreeNodeSelected);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.cboxExpTreeViewLocations, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lvDirectory, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(579, 413);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cboxExpTreeViewLocations
            // 
            this.cboxExpTreeViewLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxExpTreeViewLocations.Enabled = false;
            this.cboxExpTreeViewLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExpTreeViewLocations.FormattingEnabled = true;
            this.cboxExpTreeViewLocations.Location = new System.Drawing.Point(3, 3);
            this.cboxExpTreeViewLocations.Name = "cboxExpTreeViewLocations";
            this.cboxExpTreeViewLocations.Size = new System.Drawing.Size(573, 23);
            this.cboxExpTreeViewLocations.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboxExpTreeViewLocations, "Previous locations");
            this.cboxExpTreeViewLocations.SelectedIndexChanged += new System.EventHandler(this.cboxExpTreeViewLocations_SelectedIndexChanged);
            // 
            // lvDirectory
            // 
            this.lvDirectory.AllowDrop = true;
            this.lvDirectory.CheckBoxes = true;
            this.lvDirectory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeaderHame,
            this.ColumnHeaderAttributes,
            this.ColumnHeaderSize,
            this.ColumnHeaderType,
            this.ColumnHeaderModifyDate});
            this.lvDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDirectory.FullRowSelect = true;
            this.lvDirectory.HideSelection = false;
            this.lvDirectory.Location = new System.Drawing.Point(3, 33);
            this.lvDirectory.MultiSelect = false;
            this.lvDirectory.Name = "lvDirectory";
            this.lvDirectory.Size = new System.Drawing.Size(573, 377);
            this.lvDirectory.TabIndex = 0;
            this.lvDirectory.UseCompatibleStateImageBehavior = false;
            this.lvDirectory.View = System.Windows.Forms.View.Details;
            this.lvDirectory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvDirectory_ItemCheck);
            this.lvDirectory.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvDirectory_ItemDrag);
            this.lvDirectory.SelectedIndexChanged += new System.EventHandler(this.lvDirectory_SelectedIndexChanged);
            this.lvDirectory.Click += new System.EventHandler(this.lvDirectory_Click);
            this.lvDirectory.DoubleClick += new System.EventHandler(this.lvDirectory_DoubleClick);
            // 
            // ColumnHeaderHame
            // 
            this.ColumnHeaderHame.Text = "Name";
            this.ColumnHeaderHame.Width = 180;
            // 
            // ColumnHeaderAttributes
            // 
            this.ColumnHeaderAttributes.Text = "Attributes";
            this.ColumnHeaderAttributes.Width = 72;
            // 
            // ColumnHeaderSize
            // 
            this.ColumnHeaderSize.Text = "Size";
            this.ColumnHeaderSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeaderSize.Width = 80;
            // 
            // ColumnHeaderType
            // 
            this.ColumnHeaderType.Text = "Type";
            this.ColumnHeaderType.Width = 100;
            // 
            // ColumnHeaderModifyDate
            // 
            this.ColumnHeaderModifyDate.Text = "Modified";
            this.ColumnHeaderModifyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeaderModifyDate.Width = 80;
            // 
            // tpConnection
            // 
            this.tpConnection.Controls.Add(this.tableLayoutPanel6);
            this.tpConnection.Location = new System.Drawing.Point(4, 22);
            this.tpConnection.Name = "tpConnection";
            this.tpConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tpConnection.Size = new System.Drawing.Size(857, 425);
            this.tpConnection.TabIndex = 2;
            this.tpConnection.Text = "Connection";
            this.tpConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 10;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtHerculesAddress, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.txtHerculesPort, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnConnect, 4, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnDisconnect, 5, 3);
            this.tableLayoutPanel6.Controls.Add(this.cbDisconnectAfterSubmit, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(851, 419);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hercules address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHerculesAddress
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.txtHerculesAddress, 3);
            this.txtHerculesAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHerculesAddress.Location = new System.Drawing.Point(131, 75);
            this.txtHerculesAddress.Name = "txtHerculesAddress";
            this.txtHerculesAddress.Size = new System.Drawing.Size(186, 20);
            this.txtHerculesAddress.TabIndex = 3;
            this.txtHerculesAddress.TextChanged += new System.EventHandler(this.txtHerculesAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHerculesPort
            // 
            this.txtHerculesPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHerculesPort.Location = new System.Drawing.Point(131, 99);
            this.txtHerculesPort.Name = "txtHerculesPort";
            this.txtHerculesPort.Size = new System.Drawing.Size(58, 20);
            this.txtHerculesPort.TabIndex = 5;
            this.txtHerculesPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(321, 73);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(70, 22);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(393, 73);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(1);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(70, 22);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // cbDisconnectAfterSubmit
            // 
            this.cbDisconnectAfterSubmit.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.cbDisconnectAfterSubmit, 3);
            this.cbDisconnectAfterSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDisconnectAfterSubmit.Enabled = false;
            this.cbDisconnectAfterSubmit.Location = new System.Drawing.Point(131, 51);
            this.cbDisconnectAfterSubmit.Name = "cbDisconnectAfterSubmit";
            this.cbDisconnectAfterSubmit.Size = new System.Drawing.Size(186, 18);
            this.cbDisconnectAfterSubmit.TabIndex = 8;
            this.cbDisconnectAfterSubmit.Text = "Disconnect after submit";
            this.cbDisconnectAfterSubmit.UseVisualStyleBackColor = true;
            this.cbDisconnectAfterSubmit.CheckedChanged += new System.EventHandler(this.cbDisconnectAfterSubmit_CheckedChanged);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.rbConnectAtSubmit, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.rbConnectAtStartup, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.rbDoNotConnect, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel6.SetRowSpan(this.tableLayoutPanel11, 3);
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(128, 72);
            this.tableLayoutPanel11.TabIndex = 10;
            // 
            // rbConnectAtSubmit
            // 
            this.rbConnectAtSubmit.AutoSize = true;
            this.rbConnectAtSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbConnectAtSubmit.Location = new System.Drawing.Point(3, 51);
            this.rbConnectAtSubmit.Name = "rbConnectAtSubmit";
            this.rbConnectAtSubmit.Size = new System.Drawing.Size(122, 18);
            this.rbConnectAtSubmit.TabIndex = 1;
            this.rbConnectAtSubmit.Text = "Connect at submit";
            this.rbConnectAtSubmit.UseVisualStyleBackColor = true;
            this.rbConnectAtSubmit.CheckedChanged += new System.EventHandler(this.rbConnectAtSubmit_CheckedChanged);
            // 
            // rbConnectAtStartup
            // 
            this.rbConnectAtStartup.AutoSize = true;
            this.rbConnectAtStartup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbConnectAtStartup.Location = new System.Drawing.Point(3, 27);
            this.rbConnectAtStartup.Name = "rbConnectAtStartup";
            this.rbConnectAtStartup.Size = new System.Drawing.Size(122, 18);
            this.rbConnectAtStartup.TabIndex = 0;
            this.rbConnectAtStartup.Text = "Connect at startup";
            this.rbConnectAtStartup.UseVisualStyleBackColor = true;
            this.rbConnectAtStartup.CheckedChanged += new System.EventHandler(this.rbConnectAtStartup_CheckedChanged);
            // 
            // rbDoNotConnect
            // 
            this.rbDoNotConnect.AutoSize = true;
            this.rbDoNotConnect.Checked = true;
            this.rbDoNotConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDoNotConnect.Location = new System.Drawing.Point(3, 3);
            this.rbDoNotConnect.Name = "rbDoNotConnect";
            this.rbDoNotConnect.Size = new System.Drawing.Size(122, 18);
            this.rbDoNotConnect.TabIndex = 9;
            this.rbDoNotConnect.TabStop = true;
            this.rbDoNotConnect.Text = "Do not connect";
            this.rbDoNotConnect.UseVisualStyleBackColor = true;
            this.rbDoNotConnect.CheckedChanged += new System.EventHandler(this.rbDoNotConnect_CheckedChanged);
            // 
            // tpDiagnostics
            // 
            this.tpDiagnostics.Controls.Add(this.tableLayoutPanel2);
            this.tpDiagnostics.Location = new System.Drawing.Point(4, 22);
            this.tpDiagnostics.Name = "tpDiagnostics";
            this.tpDiagnostics.Size = new System.Drawing.Size(857, 425);
            this.tpDiagnostics.TabIndex = 3;
            this.tpDiagnostics.Text = "Diagnostics";
            this.tpDiagnostics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.Controls.Add(this.cbVerboseLogging, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbProtocolLogging, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbDumpPackets, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbDisplayStatistics, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cbSubmitToFile, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtSubmitToFile, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmitToFileBrowse, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtDiagnosticMessages, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(857, 425);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cbVerboseLogging
            // 
            this.cbVerboseLogging.AutoSize = true;
            this.cbVerboseLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbVerboseLogging.Location = new System.Drawing.Point(3, 27);
            this.cbVerboseLogging.Name = "cbVerboseLogging";
            this.cbVerboseLogging.Size = new System.Drawing.Size(122, 18);
            this.cbVerboseLogging.TabIndex = 0;
            this.cbVerboseLogging.Text = "Verbose logging";
            this.cbVerboseLogging.UseVisualStyleBackColor = true;
            this.cbVerboseLogging.CheckedChanged += new System.EventHandler(this.cbVerboseLogging_CheckedChanged);
            // 
            // cbProtocolLogging
            // 
            this.cbProtocolLogging.AutoSize = true;
            this.cbProtocolLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProtocolLogging.Location = new System.Drawing.Point(3, 51);
            this.cbProtocolLogging.Name = "cbProtocolLogging";
            this.cbProtocolLogging.Size = new System.Drawing.Size(122, 18);
            this.cbProtocolLogging.TabIndex = 1;
            this.cbProtocolLogging.Text = "Protocol logging";
            this.cbProtocolLogging.UseVisualStyleBackColor = true;
            this.cbProtocolLogging.CheckedChanged += new System.EventHandler(this.cbProtocolLogging_CheckedChanged);
            // 
            // cbDumpPackets
            // 
            this.cbDumpPackets.AutoSize = true;
            this.cbDumpPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDumpPackets.Location = new System.Drawing.Point(3, 75);
            this.cbDumpPackets.Name = "cbDumpPackets";
            this.cbDumpPackets.Size = new System.Drawing.Size(122, 18);
            this.cbDumpPackets.TabIndex = 2;
            this.cbDumpPackets.Text = "Dump packets";
            this.cbDumpPackets.UseVisualStyleBackColor = true;
            this.cbDumpPackets.CheckedChanged += new System.EventHandler(this.cbDumpPackets_CheckedChanged);
            // 
            // cbDisplayStatistics
            // 
            this.cbDisplayStatistics.AutoSize = true;
            this.cbDisplayStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDisplayStatistics.Location = new System.Drawing.Point(3, 99);
            this.cbDisplayStatistics.Name = "cbDisplayStatistics";
            this.cbDisplayStatistics.Size = new System.Drawing.Size(122, 18);
            this.cbDisplayStatistics.TabIndex = 3;
            this.cbDisplayStatistics.Text = "Display statistics";
            this.cbDisplayStatistics.UseVisualStyleBackColor = true;
            this.cbDisplayStatistics.CheckedChanged += new System.EventHandler(this.cbDisplayStatistics_CheckedChanged);
            // 
            // cbSubmitToFile
            // 
            this.cbSubmitToFile.AutoSize = true;
            this.cbSubmitToFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSubmitToFile.Location = new System.Drawing.Point(3, 123);
            this.cbSubmitToFile.Name = "cbSubmitToFile";
            this.cbSubmitToFile.Size = new System.Drawing.Size(122, 18);
            this.cbSubmitToFile.TabIndex = 4;
            this.cbSubmitToFile.Text = "Submit to file";
            this.cbSubmitToFile.UseVisualStyleBackColor = true;
            this.cbSubmitToFile.CheckedChanged += new System.EventHandler(this.cbSubmitToFile_CheckedChanged);
            // 
            // txtSubmitToFile
            // 
            this.txtSubmitToFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubmitToFile.Enabled = false;
            this.txtSubmitToFile.Location = new System.Drawing.Point(131, 123);
            this.txtSubmitToFile.Name = "txtSubmitToFile";
            this.txtSubmitToFile.Size = new System.Drawing.Size(211, 20);
            this.txtSubmitToFile.TabIndex = 5;
            this.txtSubmitToFile.TextChanged += new System.EventHandler(this.txtSubmitToFile_TextChanged);
            // 
            // btnSubmitToFileBrowse
            // 
            this.btnSubmitToFileBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmitToFileBrowse.Enabled = false;
            this.btnSubmitToFileBrowse.Location = new System.Drawing.Point(346, 121);
            this.btnSubmitToFileBrowse.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubmitToFileBrowse.Name = "btnSubmitToFileBrowse";
            this.btnSubmitToFileBrowse.Size = new System.Drawing.Size(76, 22);
            this.btnSubmitToFileBrowse.TabIndex = 6;
            this.btnSubmitToFileBrowse.Text = "Browse";
            this.btnSubmitToFileBrowse.UseVisualStyleBackColor = true;
            this.btnSubmitToFileBrowse.Click += new System.EventHandler(this.btnSubmitToFileBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Diagnostic messages:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiagnosticMessages
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtDiagnosticMessages, 2);
            this.txtDiagnosticMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiagnosticMessages.Location = new System.Drawing.Point(131, 147);
            this.txtDiagnosticMessages.Name = "txtDiagnosticMessages";
            this.tableLayoutPanel2.SetRowSpan(this.txtDiagnosticMessages, 2);
            this.txtDiagnosticMessages.Size = new System.Drawing.Size(289, 265);
            this.txtDiagnosticMessages.TabIndex = 8;
            this.txtDiagnosticMessages.Text = "";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(874, 31);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(72, 22);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(874, 59);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 22);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmsReplacement
            // 
            this.cmsReplacement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsReplacementHelp});
            this.cmsReplacement.Name = "cmsDragDrop";
            this.cmsReplacement.Size = new System.Drawing.Size(109, 26);
            // 
            // cmsReplacementHelp
            // 
            this.cmsReplacementHelp.Name = "cmsReplacementHelp";
            this.cmsReplacementHelp.Size = new System.Drawing.Size(108, 22);
            this.cmsReplacementHelp.Text = "Help...";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "J:\\SourceCode\\HelpStudio\\HerculesRJS\\_tmphhp\\herculesrjs.chm";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel12.Controls.Add(this.btnSubmit, 1, 2);
            this.tableLayoutPanel12.Controls.Add(this.btnPreview, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 4;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(949, 457);
            this.tableLayoutPanel12.TabIndex = 4;
            // 
            // txtPreJobText
            // 
            this.txtPreJobText.AllowDrop = true;
            this.txtPreJobText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel4.SetColumnSpan(this.txtPreJobText, 2);
            this.txtPreJobText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreJobText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreJobText.LineNumberPanelBackColor = System.Drawing.SystemColors.Control;
            this.txtPreJobText.LineNumberPanelForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPreJobText.LineNumberPanelVisible = false;
            this.txtPreJobText.LineNumberPanelWidth = 58;
            this.txtPreJobText.Lines = new string[0];
            this.txtPreJobText.Location = new System.Drawing.Point(115, 69);
            this.txtPreJobText.Name = "txtPreJobText";
            this.txtPreJobText.QualificationLength = 0;
            this.txtPreJobText.QualificationStart = 0;
            this.txtPreJobText.ReadOnly = false;
            this.tableLayoutPanel4.SetRowSpan(this.txtPreJobText, 2);
            this.txtPreJobText.SelectedText = "";
            this.txtPreJobText.Size = new System.Drawing.Size(302, 281);
            this.txtPreJobText.TabIndex = 20;
            // 
            // txtPostJobText
            // 
            this.txtPostJobText.AllowDrop = true;
            this.txtPostJobText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel4.SetColumnSpan(this.txtPostJobText, 2);
            this.txtPostJobText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostJobText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostJobText.LineNumberPanelBackColor = System.Drawing.SystemColors.Control;
            this.txtPostJobText.LineNumberPanelForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPostJobText.LineNumberPanelVisible = false;
            this.txtPostJobText.LineNumberPanelWidth = 58;
            this.txtPostJobText.Lines = new string[0];
            this.txtPostJobText.Location = new System.Drawing.Point(545, 69);
            this.txtPostJobText.Name = "txtPostJobText";
            this.txtPostJobText.QualificationLength = 0;
            this.txtPostJobText.QualificationStart = 0;
            this.txtPostJobText.ReadOnly = false;
            this.tableLayoutPanel4.SetRowSpan(this.txtPostJobText, 2);
            this.txtPostJobText.SelectedText = "";
            this.txtPostJobText.Size = new System.Drawing.Size(303, 281);
            this.txtPostJobText.TabIndex = 21;
            // 
            // RJSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 503);
            this.Controls.Add(this.tableLayoutPanel12);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(965, 542);
            this.Name = "RJSMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hercules RJS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RJSMain_FormClosing);
            this.Load += new System.EventHandler(this.RJSMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpPrePostJob.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tpJobCustomization.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomization)).EndInit();
            this.tpFiles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tpConnection.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tpDiagnostics.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.cmsReplacement.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ExpTreeLib.ExpTree expTreeView;
        private System.Windows.Forms.TabPage tpPrePostJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage tpConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainReconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuMainExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainView;
        private System.Windows.Forms.ToolStripMenuItem mnuMainLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuMainSmallIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuMainList;
        private System.Windows.Forms.ToolStripMenuItem mnuMainDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuMainTools;
        private System.Windows.Forms.ToolStripMenuItem mnuMainSubmit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainAbout;
        private System.Windows.Forms.ContextMenuStrip cmsReplacement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cboxExpTreeViewLocations;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ListView lvDirectory;
        private System.Windows.Forms.ColumnHeader ColumnHeaderHame;
        private System.Windows.Forms.ColumnHeader ColumnHeaderAttributes;
        private System.Windows.Forms.ColumnHeader ColumnHeaderSize;
        private System.Windows.Forms.ColumnHeader ColumnHeaderType;
        private System.Windows.Forms.ColumnHeader ColumnHeaderModifyDate;
        private System.Windows.Forms.Button btnPreJobFileBrowse;
        private System.Windows.Forms.TextBox txtPreJobFile;
        private System.Windows.Forms.Label lblPreJobSubmit;
        private System.Windows.Forms.TextBox txtPostJobFile;
        private System.Windows.Forms.Button btnPostJobFileBrowse;
        private System.Windows.Forms.Label lblPostJobSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbConnectAtStartup;
        private System.Windows.Forms.RadioButton rbConnectAtSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHerculesAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHerculesPort;
        private System.Windows.Forms.TabPage tpDiagnostics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.CheckBox cbDisconnectAfterSubmit;
        private System.Windows.Forms.CheckBox cbVerboseLogging;
        private System.Windows.Forms.CheckBox cbProtocolLogging;
        private System.Windows.Forms.CheckBox cbDumpPackets;
        private System.Windows.Forms.CheckBox cbDisplayStatistics;
        private System.Windows.Forms.CheckBox cbSubmitToFile;
        private System.Windows.Forms.TextBox txtSubmitToFile;
        private System.Windows.Forms.Button btnSubmitToFileBrowse;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSubmit;
        private twEditControls.EditBox txtPreJobText;
        private twEditControls.EditBox txtPostJobText;
        private System.Windows.Forms.TabPage tpJobCustomization;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStripMenuItem cmsReplacementHelp;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private Microsoft.TeamFoundation.Client.DataGridViewWithDetails dgvCustomization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDiagnosticMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox ckbFoldUpperCase;
        private System.Windows.Forms.RadioButton rbPreJobFirstFile;
        private System.Windows.Forms.RadioButton rbPreJobEveryFile;
        private System.Windows.Forms.RadioButton rbPostJobFirstFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.RadioButton rbPostJobEveryFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.RadioButton rbPostJobNone;
        private System.Windows.Forms.RadioButton rbPostJobFile;
        private System.Windows.Forms.RadioButton rbPostJobText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.RadioButton rbPreJobFile;
        private System.Windows.Forms.RadioButton rbPreJobText;
        private System.Windows.Forms.RadioButton rbPreJobNone;
        private System.Windows.Forms.RichTextBox rtbCustomizationHelp;
        private System.Windows.Forms.RadioButton rbDoNotConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.RadioButton rbPreJobInPlaceOfFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
    }
}

