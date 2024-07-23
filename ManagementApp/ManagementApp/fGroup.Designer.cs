namespace ManagementApp
{
    partial class fGroup
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbMBasic = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbWWW = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxHidden = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt2FA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnameAC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassAC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagGroup = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptReload = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbLoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownThread = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.richtxGroup = new System.Windows.Forms.RichTextBox();
            this.cbbDevice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menustripGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.láyThôngTinAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemNhânViênQuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidden)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagGroup)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThread)).BeginInit();
            this.menustripGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptReload);
            this.panel2.Controls.Add(this.rbMBasic);
            this.panel2.Controls.Add(this.rbM);
            this.panel2.Controls.Add(this.rbWWW);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.datagGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 418);
            this.panel2.TabIndex = 3;
            // 
            // rbMBasic
            // 
            this.rbMBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbMBasic.AutoSize = true;
            this.rbMBasic.Location = new System.Drawing.Point(70, 391);
            this.rbMBasic.Name = "rbMBasic";
            this.rbMBasic.Size = new System.Drawing.Size(58, 17);
            this.rbMBasic.TabIndex = 4;
            this.rbMBasic.Text = "mbasic";
            this.rbMBasic.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(134, 391);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(33, 17);
            this.rbM.TabIndex = 3;
            this.rbM.Text = "m";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbWWW
            // 
            this.rbWWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbWWW.AutoSize = true;
            this.rbWWW.Checked = true;
            this.rbWWW.Location = new System.Drawing.Point(16, 391);
            this.rbWWW.Name = "rbWWW";
            this.rbWWW.Size = new System.Drawing.Size(49, 17);
            this.rbWWW.TabIndex = 2;
            this.rbWWW.TabStop = true;
            this.rbWWW.Text = "www";
            this.rbWWW.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pictureBoxHidden);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(633, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 415);
            this.panel3.TabIndex = 1;
            this.panel3.Visible = false;
            // 
            // pictureBoxHidden
            // 
            this.pictureBoxHidden.Image = global::ManagementApp.Properties.Resources.account_login_48;
            this.pictureBoxHidden.Location = new System.Drawing.Point(1, 170);
            this.pictureBoxHidden.Name = "pictureBoxHidden";
            this.pictureBoxHidden.Size = new System.Drawing.Size(15, 29);
            this.pictureBoxHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHidden.TabIndex = 2;
            this.pictureBoxHidden.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(209, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtpassMail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt2FA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnameAC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpassAC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa thông tin";
            // 
            // txtpassMail
            // 
            this.txtpassMail.Location = new System.Drawing.Point(70, 126);
            this.txtpassMail.Name = "txtpassMail";
            this.txtpassMail.Size = new System.Drawing.Size(220, 20);
            this.txtpassMail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Topic";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Language";
            // 
            // txt2FA
            // 
            this.txt2FA.Location = new System.Drawing.Point(70, 74);
            this.txt2FA.Name = "txt2FA";
            this.txt2FA.Size = new System.Drawing.Size(220, 20);
            this.txt2FA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            // 
            // txtnameAC
            // 
            this.txtnameAC.Location = new System.Drawing.Point(70, 48);
            this.txtnameAC.Name = "txtnameAC";
            this.txtnameAC.Size = new System.Drawing.Size(220, 20);
            this.txtnameAC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mem Count";
            // 
            // txtpassAC
            // 
            this.txtpassAC.Location = new System.Drawing.Point(70, 22);
            this.txtpassAC.Name = "txtpassAC";
            this.txtpassAC.Size = new System.Drawing.Size(220, 20);
            this.txtpassAC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // datagGroup
            // 
            this.datagGroup.AllowUserToOrderColumns = true;
            this.datagGroup.AllowUserToResizeRows = false;
            this.datagGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagGroup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idG,
            this.nameG,
            this.MemCount,
            this.countryG,
            this.languageG,
            this.Topic});
            this.datagGroup.Location = new System.Drawing.Point(3, 3);
            this.datagGroup.Name = "datagGroup";
            this.datagGroup.RowHeadersVisible = false;
            this.datagGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagGroup.Size = new System.Drawing.Size(949, 382);
            this.datagGroup.TabIndex = 0;
            this.datagGroup.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagGroup_CellFormatting);
            this.datagGroup.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagGroup_ColumnHeaderMouseClick);
            this.datagGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datagGroup_MouseDown);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(733, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(842, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 30);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(733, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách Group (Nhập ID Group)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbbLoc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numericUpDownThread);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.richtxGroup);
            this.panel1.Controls.Add(this.cbbDevice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 132);
            this.panel1.TabIndex = 2;
            // 
            // ptReload
            // 
            this.ptReload.Image = global::ManagementApp.Properties.Resources.pngegg;
            this.ptReload.Location = new System.Drawing.Point(37, 5);
            this.ptReload.Name = "ptReload";
            this.ptReload.Size = new System.Drawing.Size(18, 18);
            this.ptReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptReload.TabIndex = 23;
            this.ptReload.TabStop = false;
            this.ptReload.Click += new System.EventHandler(this.ptReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(380, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(38, 18);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(241, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 20);
            this.txtSearch.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Search:";
            // 
            // cbbLoc
            // 
            this.cbbLoc.FormattingEnabled = true;
            this.cbbLoc.Location = new System.Drawing.Point(49, 105);
            this.cbbLoc.Name = "cbbLoc";
            this.cbbLoc.Size = new System.Drawing.Size(121, 21);
            this.cbbLoc.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Lọc:";
            // 
            // numericUpDownThread
            // 
            this.numericUpDownThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownThread.Location = new System.Drawing.Point(893, 78);
            this.numericUpDownThread.Name = "numericUpDownThread";
            this.numericUpDownThread.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownThread.TabIndex = 17;
            this.numericUpDownThread.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(843, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thread:";
            // 
            // richtxGroup
            // 
            this.richtxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxGroup.Location = new System.Drawing.Point(16, 21);
            this.richtxGroup.Name = "richtxGroup";
            this.richtxGroup.Size = new System.Drawing.Size(471, 79);
            this.richtxGroup.TabIndex = 15;
            this.richtxGroup.Text = "";
            // 
            // cbbDevice
            // 
            this.cbbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbbDevice.FormattingEnabled = true;
            this.cbbDevice.Location = new System.Drawing.Point(510, 26);
            this.cbbDevice.Name = "cbbDevice";
            this.cbbDevice.Size = new System.Drawing.Size(196, 26);
            this.cbbDevice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(507, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Account";
            // 
            // menustripGroup
            // 
            this.menustripGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.láyThôngTinAccountToolStripMenuItem,
            this.chỉnhSửaThôngTinToolStripMenuItem,
            this.xemNhânViênQuảnLýToolStripMenuItem});
            this.menustripGroup.Name = "menustripAC";
            this.menustripGroup.Size = new System.Drawing.Size(199, 70);
            // 
            // láyThôngTinAccountToolStripMenuItem
            // 
            this.láyThôngTinAccountToolStripMenuItem.Name = "láyThôngTinAccountToolStripMenuItem";
            this.láyThôngTinAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.láyThôngTinAccountToolStripMenuItem.Text = "Lấy thông tin Page";
            // 
            // chỉnhSửaThôngTinToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinToolStripMenuItem.Name = "chỉnhSửaThôngTinToolStripMenuItem";
            this.chỉnhSửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.chỉnhSửaThôngTinToolStripMenuItem.Text = "Chỉnh sửa thông tin";
            // 
            // xemNhânViênQuảnLýToolStripMenuItem
            // 
            this.xemNhânViênQuảnLýToolStripMenuItem.Name = "xemNhânViênQuảnLýToolStripMenuItem";
            this.xemNhânViênQuảnLýToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.xemNhânViênQuảnLýToolStripMenuItem.Text = "Xem thông tin Account";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 53;
            // 
            // idG
            // 
            this.idG.DataPropertyName = "idG";
            this.idG.HeaderText = "GID";
            this.idG.Name = "idG";
            this.idG.Width = 51;
            // 
            // nameG
            // 
            this.nameG.DataPropertyName = "nameG";
            this.nameG.HeaderText = "Name";
            this.nameG.Name = "nameG";
            this.nameG.Width = 60;
            // 
            // MemCount
            // 
            this.MemCount.DataPropertyName = "MemCount";
            this.MemCount.HeaderText = "Mem Count";
            this.MemCount.Name = "MemCount";
            this.MemCount.Width = 86;
            // 
            // countryG
            // 
            this.countryG.DataPropertyName = "countryG";
            this.countryG.HeaderText = "Country";
            this.countryG.Name = "countryG";
            this.countryG.Width = 68;
            // 
            // languageG
            // 
            this.languageG.DataPropertyName = "languageG";
            this.languageG.HeaderText = "Language";
            this.languageG.Name = "languageG";
            this.languageG.Width = 80;
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic";
            this.Topic.HeaderText = "Topic";
            this.Topic.Name = "Topic";
            this.Topic.Width = 59;
            // 
            // fGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(955, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fGroup";
            this.Text = "fGroup";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHidden)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagGroup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThread)).EndInit();
            this.menustripGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView datagGroup;
        private System.Windows.Forms.ComboBox cbbDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtxGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtpassMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt2FA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnameAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxHidden;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip menustripGroup;
        private System.Windows.Forms.ToolStripMenuItem láyThôngTinAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbMBasic;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbWWW;
        private System.Windows.Forms.NumericUpDown numericUpDownThread;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbLoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem xemNhânViênQuảnLýToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idG;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryG;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
    }
}