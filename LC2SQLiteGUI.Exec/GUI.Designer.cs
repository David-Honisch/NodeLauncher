namespace LC2SQLiteGUI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.mnuStripmain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlStrpmain = new System.Windows.Forms.ToolStrip();
            this.tlStpbtnnew = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnconnect = new System.Windows.Forms.ToolStripButton();
            this.tlStrpClose = new System.Windows.Forms.ToolStripButton();
            this.tlstrpprint = new System.Windows.Forms.ToolStripButton();
            this.opnfiledlg = new System.Windows.Forms.OpenFileDialog();
            this.savefileDlg = new System.Windows.Forms.SaveFileDialog();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.lblconnected = new System.Windows.Forms.Label();
            this.lblconnect = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvExec = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.cbExec = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablecombobox = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkprimary = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.typecombo = new System.Windows.Forms.ComboBox();
            this.txtcolumnname = new System.Windows.Forms.TextBox();
            this.txttablename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rchtxtCreate = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rchtxtQuery = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rchtxtSchema = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sblblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.userPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.mnuStripmain.SuspendLayout();
            this.tlStrpmain.SuspendLayout();
            this.pnlLabel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExec)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripmain
            // 
            this.mnuStripmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStripmain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripmain.Name = "mnuStripmain";
            this.mnuStripmain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuStripmain.Size = new System.Drawing.Size(896, 24);
            this.mnuStripmain.TabIndex = 0;
            this.mnuStripmain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeDBToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "&Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::LC2SQLiteGUI.Properties.Resources.connected;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "&Open DB";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.tlstrpbtnconnect_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::LC2SQLiteGUI.Properties.Resources.printer;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.tlstrpprint_Click);
            // 
            // closeDBToolStripMenuItem
            // 
            this.closeDBToolStripMenuItem.Image = global::LC2SQLiteGUI.Properties.Resources.disconnected;
            this.closeDBToolStripMenuItem.Name = "closeDBToolStripMenuItem";
            this.closeDBToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeDBToolStripMenuItem.Text = "&Close DB";
            this.closeDBToolStripMenuItem.Click += new System.EventHandler(this.closeDBToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // topicsToolStripMenuItem
            // 
            this.topicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHelp});
            this.topicsToolStripMenuItem.Name = "topicsToolStripMenuItem";
            this.topicsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.topicsToolStripMenuItem.Text = "&Topics";
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(152, 22);
            this.toolStripHelp.Text = "Homepage";
            this.toolStripHelp.Click += new System.EventHandler(this.toolStripHelp_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tlStrpmain
            // 
            this.tlStrpmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStpbtnnew,
            this.tlstrpbtnconnect,
            this.tlStrpClose,
            this.tlstrpprint});
            this.tlStrpmain.Location = new System.Drawing.Point(0, 24);
            this.tlStrpmain.Name = "tlStrpmain";
            this.tlStrpmain.Size = new System.Drawing.Size(896, 25);
            this.tlStrpmain.TabIndex = 1;
            this.tlStrpmain.Text = "toolStrip1";
            // 
            // tlStpbtnnew
            // 
            this.tlStpbtnnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStpbtnnew.Image = global::LC2SQLiteGUI.Properties.Resources.mnu_devicemgmt;
            this.tlStpbtnnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStpbtnnew.Name = "tlStpbtnnew";
            this.tlStpbtnnew.Size = new System.Drawing.Size(23, 22);
            this.tlStpbtnnew.Text = "New DB";
            this.tlStpbtnnew.Click += new System.EventHandler(this.tlStpbtnnew_Click);
            // 
            // tlstrpbtnconnect
            // 
            this.tlstrpbtnconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpbtnconnect.Image = global::LC2SQLiteGUI.Properties.Resources.connected;
            this.tlstrpbtnconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnconnect.Name = "tlstrpbtnconnect";
            this.tlstrpbtnconnect.Size = new System.Drawing.Size(23, 22);
            this.tlstrpbtnconnect.Text = "Open DB";
            this.tlstrpbtnconnect.Click += new System.EventHandler(this.tlstrpbtnconnect_Click);
            // 
            // tlStrpClose
            // 
            this.tlStrpClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpClose.Image = global::LC2SQLiteGUI.Properties.Resources.disconnected;
            this.tlStrpClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpClose.Name = "tlStrpClose";
            this.tlStrpClose.Size = new System.Drawing.Size(23, 22);
            this.tlStrpClose.Text = "Close DB";
            this.tlStrpClose.Click += new System.EventHandler(this.closeDBToolStripMenuItem_Click);
            // 
            // tlstrpprint
            // 
            this.tlstrpprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpprint.Image = global::LC2SQLiteGUI.Properties.Resources.printer;
            this.tlstrpprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpprint.Name = "tlstrpprint";
            this.tlstrpprint.Size = new System.Drawing.Size(23, 22);
            this.tlstrpprint.Text = "Print Table";
            this.tlstrpprint.Click += new System.EventHandler(this.tlstrpprint_Click);
            // 
            // pnlLabel
            // 
            this.pnlLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLabel.Controls.Add(this.lblconnected);
            this.pnlLabel.Controls.Add(this.lblconnect);
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLabel.Location = new System.Drawing.Point(0, 49);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(896, 34);
            this.pnlLabel.TabIndex = 3;
            // 
            // lblconnected
            // 
            this.lblconnected.AutoSize = true;
            this.lblconnected.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblconnected.Location = new System.Drawing.Point(813, 10);
            this.lblconnected.Name = "lblconnected";
            this.lblconnected.Size = new System.Drawing.Size(24, 13);
            this.lblconnected.TabIndex = 1;
            this.lblconnected.Text = "NO";
            // 
            // lblconnect
            // 
            this.lblconnect.AutoSize = true;
            this.lblconnect.ForeColor = System.Drawing.Color.Black;
            this.lblconnect.Location = new System.Drawing.Point(742, 10);
            this.lblconnect.Name = "lblconnect";
            this.lblconnect.Size = new System.Drawing.Size(73, 13);
            this.lblconnect.TabIndex = 0;
            this.lblconnect.Text = "Connected:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvExec);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(888, 396);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Execute Url";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvExec
            // 
            this.dgvExec.AllowUserToAddRows = false;
            this.dgvExec.AllowUserToDeleteRows = false;
            this.dgvExec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExec.Location = new System.Drawing.Point(170, 3);
            this.dgvExec.Name = "dgvExec";
            this.dgvExec.ReadOnly = true;
            this.dgvExec.Size = new System.Drawing.Size(715, 390);
            this.dgvExec.TabIndex = 10;
            this.dgvExec.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExec_CellContentDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnQuery);
            this.panel4.Controls.Add(this.tbQuery);
            this.panel4.Controls.Add(this.cbExec);
            this.panel4.Controls.Add(this.btnStart);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 390);
            this.panel4.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(19, 114);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "Execute Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(5, 87);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(153, 21);
            this.tbQuery.TabIndex = 4;
            // 
            // cbExec
            // 
            this.cbExec.FormattingEnabled = true;
            this.cbExec.Location = new System.Drawing.Point(5, 25);
            this.cbExec.Name = "cbExec";
            this.cbExec.Size = new System.Drawing.Size(153, 21);
            this.cbExec.TabIndex = 3;
            this.cbExec.SelectedIndexChanged += new System.EventHandler(this.comboBoxExec_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(19, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Execute Url";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tables in DB:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userDataGridView);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.Location = new System.Drawing.Point(170, 3);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(715, 355);
            this.userDataGridView.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tablecombobox);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.lblAvailable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 355);
            this.panel3.TabIndex = 6;
            // 
            // tablecombobox
            // 
            this.tablecombobox.FormattingEnabled = true;
            this.tablecombobox.Location = new System.Drawing.Point(5, 25);
            this.tablecombobox.Name = "tablecombobox";
            this.tablecombobox.Size = new System.Drawing.Size(153, 21);
            this.tablecombobox.TabIndex = 3;
            this.tablecombobox.SelectedIndexChanged += new System.EventHandler(this.tablecombobox_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(19, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Table";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.Color.Black;
            this.lblAvailable.Location = new System.Drawing.Point(5, 9);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(83, 13);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Tables in DB:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 35);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRefreshdb_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(757, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkprimary);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.typecombo);
            this.tabPage2.Controls.Add(this.txtcolumnname);
            this.tabPage2.Controls.Add(this.txttablename);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rchtxtCreate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkprimary
            // 
            this.chkprimary.AutoSize = true;
            this.chkprimary.Checked = true;
            this.chkprimary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkprimary.Location = new System.Drawing.Point(453, 76);
            this.chkprimary.Name = "chkprimary";
            this.chkprimary.Size = new System.Drawing.Size(97, 17);
            this.chkprimary.TabIndex = 12;
            this.chkprimary.Text = "Primary Key";
            this.chkprimary.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(663, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(220, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create Table ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(453, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Column";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // typecombo
            // 
            this.typecombo.FormattingEnabled = true;
            this.typecombo.Location = new System.Drawing.Point(268, 117);
            this.typecombo.Name = "typecombo";
            this.typecombo.Size = new System.Drawing.Size(158, 21);
            this.typecombo.TabIndex = 6;
            // 
            // txtcolumnname
            // 
            this.txtcolumnname.Location = new System.Drawing.Point(268, 72);
            this.txtcolumnname.Name = "txtcolumnname";
            this.txtcolumnname.Size = new System.Drawing.Size(158, 21);
            this.txtcolumnname.TabIndex = 5;
            // 
            // txttablename
            // 
            this.txttablename.Location = new System.Drawing.Point(268, 28);
            this.txttablename.Name = "txttablename";
            this.txttablename.Size = new System.Drawing.Size(158, 21);
            this.txttablename.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Column Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Column Name:";
            // 
            // rchtxtCreate
            // 
            this.rchtxtCreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchtxtCreate.Location = new System.Drawing.Point(114, 245);
            this.rchtxtCreate.Name = "rchtxtCreate";
            this.rchtxtCreate.ReadOnly = true;
            this.rchtxtCreate.Size = new System.Drawing.Size(532, 106);
            this.rchtxtCreate.TabIndex = 1;
            this.rchtxtCreate.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExecute);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.rchtxtQuery);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(888, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Custom Query";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(539, 228);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(123, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute Query";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query:";
            // 
            // rchtxtQuery
            // 
            this.rchtxtQuery.Location = new System.Drawing.Point(182, 81);
            this.rchtxtQuery.Name = "rchtxtQuery";
            this.rchtxtQuery.Size = new System.Drawing.Size(480, 125);
            this.rchtxtQuery.TabIndex = 0;
            this.rchtxtQuery.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rchtxtSchema);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(888, 396);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Database Schema";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rchtxtSchema
            // 
            this.rchtxtSchema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchtxtSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtSchema.Location = new System.Drawing.Point(3, 43);
            this.rchtxtSchema.Name = "rchtxtSchema";
            this.rchtxtSchema.ReadOnly = true;
            this.rchtxtSchema.Size = new System.Drawing.Size(882, 350);
            this.rchtxtSchema.TabIndex = 2;
            this.rchtxtSchema.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 40);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(109)))), ((int)(((byte)(149)))));
            this.label6.Location = new System.Drawing.Point(5, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Database Schema";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(160, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Show Schema";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlStatus.Controls.Add(this.statusStrip1);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 505);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(896, 19);
            this.pnlStatus.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, -3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sblblstatus
            // 
            this.sblblstatus.Name = "sblblstatus";
            this.sblblstatus.Size = new System.Drawing.Size(39, 17);
            this.sblblstatus.Text = "Ready";
            // 
            // userPrintDocument
            // 
            this.userPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.userPrintDocument_PrintPage);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlLabel);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.tlStrpmain);
            this.Controls.Add(this.mnuStripmain);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStripmain;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LC2SQLite GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.mnuStripmain.ResumeLayout(false);
            this.mnuStripmain.PerformLayout();
            this.tlStrpmain.ResumeLayout(false);
            this.tlStrpmain.PerformLayout();
            this.pnlLabel.ResumeLayout(false);
            this.pnlLabel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExec)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripmain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlStrpmain;
        private System.Windows.Forms.ToolStripButton tlstrpbtnconnect;
        private System.Windows.Forms.OpenFileDialog opnfiledlg;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tlStpbtnnew;
        private System.Windows.Forms.SaveFileDialog savefileDlg;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Label lblconnect;
        private System.Windows.Forms.Label lblconnected;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchtxtQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox typecombo;
        private System.Windows.Forms.TextBox txtcolumnname;
        private System.Windows.Forms.TextBox txttablename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchtxtCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rchtxtSchema;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkprimary;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tlStrpClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tlstrpprint;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sblblstatus;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox tablecombobox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Drawing.Printing.PrintDocument userPrintDocument;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvExec;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbExec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tbQuery;
    }
}

