namespace ManagementApp
{
    partial class fTest
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
            this.datagAC = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twoFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownThread = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.richtxAC = new System.Windows.Forms.RichTextBox();
            this.menustripAC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.láyThôngTinAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCookie = new System.Windows.Forms.TextBox();
            this.cookie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrithday = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagAC)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThread)).BeginInit();
            this.menustripAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbMBasic);
            this.panel2.Controls.Add(this.rbM);
            this.panel2.Controls.Add(this.rbWWW);
            this.panel2.Controls.Add(this.datagAC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 440);
            this.panel2.TabIndex = 3;
            // 
            // rbMBasic
            // 
            this.rbMBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbMBasic.AutoSize = true;
            this.rbMBasic.Location = new System.Drawing.Point(70, 413);
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
            this.rbM.Location = new System.Drawing.Point(134, 413);
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
            this.rbWWW.Location = new System.Drawing.Point(16, 413);
            this.rbWWW.Name = "rbWWW";
            this.rbWWW.Size = new System.Drawing.Size(49, 17);
            this.rbWWW.TabIndex = 2;
            this.rbWWW.TabStop = true;
            this.rbWWW.Text = "www";
            this.rbWWW.UseVisualStyleBackColor = true;
            // 
            // datagAC
            // 
            this.datagAC.AllowUserToResizeRows = false;
            this.datagAC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagAC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagAC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagAC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.UID,
            this.NameAC,
            this.CountryAC,
            this.Column5,
            this.passAC,
            this.twoFA,
            this.emailAC,
            this.passEmail,
            this.Column3});
            this.datagAC.Location = new System.Drawing.Point(3, 0);
            this.datagAC.Name = "datagAC";
            this.datagAC.RowHeadersVisible = false;
            this.datagAC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagAC.Size = new System.Drawing.Size(949, 407);
            this.datagAC.TabIndex = 0;
            this.datagAC.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagAC_CellFormatting);
            this.datagAC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagAC_CellMouseClick);
            this.datagAC.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagAC_ColumnHeaderMouseClick_1);
            this.datagAC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datagAC_MouseDown);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 53;
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.Width = 51;
            // 
            // NameAC
            // 
            this.NameAC.DataPropertyName = "NameAC";
            this.NameAC.HeaderText = "Name";
            this.NameAC.Name = "NameAC";
            this.NameAC.Width = 60;
            // 
            // CountryAC
            // 
            this.CountryAC.DataPropertyName = "CountryAC";
            this.CountryAC.HeaderText = "Location";
            this.CountryAC.Name = "CountryAC";
            this.CountryAC.Width = 73;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.Width = 62;
            // 
            // passAC
            // 
            this.passAC.DataPropertyName = "passAC";
            this.passAC.HeaderText = "Pass Word";
            this.passAC.Name = "passAC";
            this.passAC.Width = 84;
            // 
            // twoFA
            // 
            this.twoFA.DataPropertyName = "twoFA";
            this.twoFA.HeaderText = "2FA";
            this.twoFA.Name = "twoFA";
            this.twoFA.Width = 51;
            // 
            // emailAC
            // 
            this.emailAC.DataPropertyName = "emailAC";
            this.emailAC.HeaderText = "Email";
            this.emailAC.Name = "emailAC";
            this.emailAC.Width = 57;
            // 
            // passEmail
            // 
            this.passEmail.DataPropertyName = "passEmail";
            this.passEmail.HeaderText = "Pass Mail";
            this.passEmail.Name = "passEmail";
            this.passEmail.Width = 77;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gender";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
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
            this.label1.Size = new System.Drawing.Size(406, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách tài khoản (Nhập theo UID|Pass|2FA|email|passemail)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBrithday);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtToken);
            this.panel1.Controls.Add(this.cookie);
            this.panel1.Controls.Add(this.txtCookie);
            this.panel1.Controls.Add(this.numericUpDownThread);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.richtxAC);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 110);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDownThread
            // 
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
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(843, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thread:";
            // 
            // richtxAC
            // 
            this.richtxAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxAC.Location = new System.Drawing.Point(16, 21);
            this.richtxAC.Name = "richtxAC";
            this.richtxAC.Size = new System.Drawing.Size(425, 79);
            this.richtxAC.TabIndex = 15;
            this.richtxAC.Text = "";
            // 
            // menustripAC
            // 
            this.menustripAC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.láyThôngTinAccountToolStripMenuItem,
            this.chỉnhSửaThôngTinToolStripMenuItem});
            this.menustripAC.Name = "menustripAC";
            this.menustripAC.Size = new System.Drawing.Size(191, 48);
            // 
            // láyThôngTinAccountToolStripMenuItem
            // 
            this.láyThôngTinAccountToolStripMenuItem.Name = "láyThôngTinAccountToolStripMenuItem";
            this.láyThôngTinAccountToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.láyThôngTinAccountToolStripMenuItem.Text = "Lấy thông tin account";
            this.láyThôngTinAccountToolStripMenuItem.Click += new System.EventHandler(this.getAboutAccountToolStripMenuItem_Click);
            // 
            // chỉnhSửaThôngTinToolStripMenuItem
            // 
            this.chỉnhSửaThôngTinToolStripMenuItem.Name = "chỉnhSửaThôngTinToolStripMenuItem";
            this.chỉnhSửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.chỉnhSửaThôngTinToolStripMenuItem.Text = "Lấy thông tin 2";
            this.chỉnhSửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.getinfo2ToolStripMenuItem_Click);
            // 
            // txtCookie
            // 
            this.txtCookie.Location = new System.Drawing.Point(503, 9);
            this.txtCookie.Name = "txtCookie";
            this.txtCookie.Size = new System.Drawing.Size(224, 20);
            this.txtCookie.TabIndex = 18;
            // 
            // cookie
            // 
            this.cookie.AutoSize = true;
            this.cookie.Location = new System.Drawing.Point(458, 12);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(39, 13);
            this.cookie.TabIndex = 19;
            this.cookie.Text = "cookie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(503, 35);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(224, 20);
            this.txtToken.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(503, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "brithday";
            // 
            // txtBrithday
            // 
            this.txtBrithday.Location = new System.Drawing.Point(503, 87);
            this.txtBrithday.Name = "txtBrithday";
            this.txtBrithday.Size = new System.Drawing.Size(224, 20);
            this.txtBrithday.TabIndex = 24;
            // 
            // fPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(955, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fPage";
            this.Text = "fPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagAC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThread)).EndInit();
            this.menustripAC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView datagAC;
        private System.Windows.Forms.RichTextBox richtxAC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip menustripAC;
        private System.Windows.Forms.ToolStripMenuItem láyThôngTinAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbMBasic;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbWWW;
        private System.Windows.Forms.NumericUpDown numericUpDownThread;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn passAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn twoFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn passEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label cookie;
        private System.Windows.Forms.TextBox txtCookie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrithday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
    }
}