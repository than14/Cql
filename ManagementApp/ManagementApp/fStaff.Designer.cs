namespace ManagementApp
{
    partial class fStaff
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
            this.datagStaff = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.panelResetPass = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.txtResetPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datagAccount = new System.Windows.Forms.DataGridView();
            this.datagDevice = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbST = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.datagStaff)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelinfo.SuspendLayout();
            this.panelResetPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagStaff
            // 
            this.datagStaff.AllowUserToAddRows = false;
            this.datagStaff.AllowUserToDeleteRows = false;
            this.datagStaff.AllowUserToOrderColumns = true;
            this.datagStaff.AllowUserToResizeRows = false;
            this.datagStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idSA,
            this.UserSA,
            this.NameSA,
            this.idRole,
            this.NoteSA});
            this.datagStaff.Location = new System.Drawing.Point(12, 6);
            this.datagStaff.MultiSelect = false;
            this.datagStaff.Name = "datagStaff";
            this.datagStaff.ReadOnly = true;
            this.datagStaff.RowHeadersVisible = false;
            this.datagStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagStaff.Size = new System.Drawing.Size(550, 430);
            this.datagStaff.TabIndex = 0;
            this.datagStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagStaff_CellClick);
            this.datagStaff.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagStaff_CellFormatting);
            this.datagStaff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datagStaff_MouseDown);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // idSA
            // 
            this.idSA.DataPropertyName = "idSA";
            this.idSA.HeaderText = "Mã Nhân Viên";
            this.idSA.Name = "idSA";
            this.idSA.ReadOnly = true;
            // 
            // UserSA
            // 
            this.UserSA.DataPropertyName = "UserSA";
            this.UserSA.HeaderText = "Tài Khoản";
            this.UserSA.Name = "UserSA";
            this.UserSA.ReadOnly = true;
            this.UserSA.Width = 81;
            // 
            // NameSA
            // 
            this.NameSA.DataPropertyName = "NameSA";
            this.NameSA.HeaderText = "Tên";
            this.NameSA.Name = "NameSA";
            this.NameSA.ReadOnly = true;
            this.NameSA.Width = 51;
            // 
            // idRole
            // 
            this.idRole.DataPropertyName = "NamRole";
            this.idRole.HeaderText = "Phân Quyền";
            this.idRole.Name = "idRole";
            this.idRole.ReadOnly = true;
            this.idRole.Width = 91;
            // 
            // NoteSA
            // 
            this.NoteSA.DataPropertyName = "NoteSA";
            this.NoteSA.HeaderText = "Note";
            this.NoteSA.Name = "NoteSA";
            this.NoteSA.ReadOnly = true;
            this.NoteSA.Width = 55;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelResetPass);
            this.panel2.Controls.Add(this.panelinfo);
            this.panel2.Controls.Add(this.datagStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 440);
            this.panel2.TabIndex = 3;
            // 
            // panelinfo
            // 
            this.panelinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelinfo.Controls.Add(this.datagAccount);
            this.panelinfo.Controls.Add(this.datagDevice);
            this.panelinfo.Controls.Add(this.label7);
            this.panelinfo.Controls.Add(this.label6);
            this.panelinfo.Location = new System.Drawing.Point(568, 3);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(380, 437);
            this.panelinfo.TabIndex = 1;
            this.panelinfo.Visible = false;
            // 
            // panelResetPass
            // 
            this.panelResetPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResetPass.BackColor = System.Drawing.Color.Azure;
            this.panelResetPass.Controls.Add(this.pictureBox1);
            this.panelResetPass.Controls.Add(this.label9);
            this.panelResetPass.Controls.Add(this.btnResetPass);
            this.panelResetPass.Controls.Add(this.txtResetPass);
            this.panelResetPass.Controls.Add(this.label8);
            this.panelResetPass.Location = new System.Drawing.Point(560, 2);
            this.panelResetPass.Name = "panelResetPass";
            this.panelResetPass.Size = new System.Drawing.Size(387, 462);
            this.panelResetPass.TabIndex = 2;
            this.panelResetPass.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManagementApp.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnResetPass.Location = new System.Drawing.Point(145, 98);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(114, 27);
            this.btnResetPass.TabIndex = 2;
            this.btnResetPass.Text = "Xác nhận";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // txtResetPass
            // 
            this.txtResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtResetPass.Location = new System.Drawing.Point(142, 52);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.Size = new System.Drawing.Size(214, 23);
            this.txtResetPass.TabIndex = 1;
            this.txtResetPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(24, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhập mật khâu: ";
            // 
            // datagAccount
            // 
            this.datagAccount.AllowUserToResizeRows = false;
            this.datagAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datagAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagAccount.BackgroundColor = System.Drawing.Color.Azure;
            this.datagAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagAccount.Location = new System.Drawing.Point(185, 23);
            this.datagAccount.Name = "datagAccount";
            this.datagAccount.RowHeadersVisible = false;
            this.datagAccount.Size = new System.Drawing.Size(183, 402);
            this.datagAccount.TabIndex = 3;
            // 
            // datagDevice
            // 
            this.datagDevice.AllowUserToResizeRows = false;
            this.datagDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.datagDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagDevice.BackgroundColor = System.Drawing.Color.Azure;
            this.datagDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagDevice.Location = new System.Drawing.Point(6, 23);
            this.datagDevice.Name = "datagDevice";
            this.datagDevice.RowHeadersVisible = false;
            this.datagDevice.Size = new System.Drawing.Size(146, 402);
            this.datagDevice.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Account:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thiết bị:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(770, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(770, 38);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(129, 30);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Aqua;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(591, 76);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(591, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtname.Location = new System.Drawing.Point(115, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(298, 26);
            this.txtname.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpass.Location = new System.Drawing.Point(115, 70);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(298, 26);
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtuser.Location = new System.Drawing.Point(115, 7);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(298, 26);
            this.txtuser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(456, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ROLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbST);
            this.panel1.Controls.Add(this.rdbAdmin);
            this.panel1.Controls.Add(this.txtnote);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 110);
            this.panel1.TabIndex = 2;
            // 
            // rdbST
            // 
            this.rdbST.AutoSize = true;
            this.rdbST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbST.Location = new System.Drawing.Point(461, 81);
            this.rdbST.Name = "rdbST";
            this.rdbST.Size = new System.Drawing.Size(77, 20);
            this.rdbST.TabIndex = 16;
            this.rdbST.TabStop = true;
            this.rdbST.Text = "STAFF";
            this.rdbST.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.Location = new System.Drawing.Point(461, 62);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(78, 20);
            this.rdbAdmin.TabIndex = 15;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "ADMIN";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtnote
            // 
            this.txtnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnote.Location = new System.Drawing.Point(515, 7);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(384, 26);
            this.txtnote.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(457, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "NOTE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(948, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fStaff";
            this.Text = "fStaff";
            ((System.ComponentModel.ISupportInitialize)(this.datagStaff)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            this.panelResetPass.ResumeLayout(false);
            this.panelResetPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datagStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteSA;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.DataGridView datagAccount;
        private System.Windows.Forms.DataGridView datagDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbST;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.Panel panelResetPass;
        private System.Windows.Forms.TextBox txtResetPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}