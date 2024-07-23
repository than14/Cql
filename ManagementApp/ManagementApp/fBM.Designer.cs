namespace ManagementApp
{
    partial class fBM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagBM = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SharingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdCreateLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iaAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameBM = new System.Windows.Forms.TextBox();
            this.txtSharingstt = new System.Windows.Forms.TextBox();
            this.txtIdBM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbAccount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerified = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtADLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagBM)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagBM
            // 
            this.datagBM.AllowUserToAddRows = false;
            this.datagBM.AllowUserToDeleteRows = false;
            this.datagBM.AllowUserToOrderColumns = true;
            this.datagBM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagBM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagBM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.datagBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagBM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.NameBM,
            this.SharingStatus,
            this.AdCreateLimit,
            this.Verified,
            this.PaymentMethods,
            this.iaAC,
            this.idSA});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagBM.DefaultCellStyle = dataGridViewCellStyle11;
            this.datagBM.Location = new System.Drawing.Point(12, 3);
            this.datagBM.MultiSelect = false;
            this.datagBM.Name = "datagBM";
            this.datagBM.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagBM.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.datagBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagBM.Size = new System.Drawing.Size(924, 422);
            this.datagBM.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // NameBM
            // 
            this.NameBM.DataPropertyName = "NameBM";
            this.NameBM.HeaderText = "Name BM";
            this.NameBM.Name = "NameBM";
            this.NameBM.ReadOnly = true;
            this.NameBM.Width = 73;
            // 
            // SharingStatus
            // 
            this.SharingStatus.DataPropertyName = "SharingStatus";
            this.SharingStatus.HeaderText = "Sharing Status";
            this.SharingStatus.Name = "SharingStatus";
            this.SharingStatus.ReadOnly = true;
            this.SharingStatus.Width = 93;
            // 
            // AdCreateLimit
            // 
            this.AdCreateLimit.DataPropertyName = "AdCreateLimit";
            this.AdCreateLimit.HeaderText = "AdCreate Limit";
            this.AdCreateLimit.Name = "AdCreateLimit";
            this.AdCreateLimit.ReadOnly = true;
            this.AdCreateLimit.Width = 92;
            // 
            // Verified
            // 
            this.Verified.DataPropertyName = "Verified";
            this.Verified.HeaderText = "Verified";
            this.Verified.Name = "Verified";
            this.Verified.ReadOnly = true;
            this.Verified.Width = 67;
            // 
            // PaymentMethods
            // 
            this.PaymentMethods.DataPropertyName = "PaymentMethods";
            this.PaymentMethods.HeaderText = "Payment Methods";
            this.PaymentMethods.Name = "PaymentMethods";
            this.PaymentMethods.ReadOnly = true;
            this.PaymentMethods.Width = 107;
            // 
            // iaAC
            // 
            this.iaAC.DataPropertyName = "iaAC";
            this.iaAC.HeaderText = "Account";
            this.iaAC.Name = "iaAC";
            this.iaAC.ReadOnly = true;
            this.iaAC.Width = 72;
            // 
            // idSA
            // 
            this.idSA.DataPropertyName = "idSA";
            this.idSA.HeaderText = "Staff";
            this.idSA.Name = "idSA";
            this.idSA.ReadOnly = true;
            this.idSA.Width = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagBM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 431);
            this.panel2.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(811, 82);
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
            this.btnDel.Location = new System.Drawing.Point(811, 47);
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
            this.btnEdit.Location = new System.Drawing.Point(662, 82);
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
            this.btnAdd.Location = new System.Drawing.Point(662, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameBM
            // 
            this.txtNameBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameBM.Location = new System.Drawing.Point(115, 40);
            this.txtNameBM.Name = "txtNameBM";
            this.txtNameBM.Size = new System.Drawing.Size(200, 26);
            this.txtNameBM.TabIndex = 2;
            // 
            // txtSharingstt
            // 
            this.txtSharingstt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSharingstt.Location = new System.Drawing.Point(138, 72);
            this.txtSharingstt.Name = "txtSharingstt";
            this.txtSharingstt.Size = new System.Drawing.Size(177, 26);
            this.txtSharingstt.TabIndex = 3;
            // 
            // txtIdBM
            // 
            this.txtIdBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdBM.Location = new System.Drawing.Point(115, 7);
            this.txtIdBM.Name = "txtIdBM";
            this.txtIdBM.Size = new System.Drawing.Size(200, 26);
            this.txtIdBM.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name BM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sharing Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID BM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtVerified);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.txtADLimit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbbAccount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtNameBM);
            this.panel1.Controls.Add(this.txtSharingstt);
            this.panel1.Controls.Add(this.txtIdBM);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 119);
            this.panel1.TabIndex = 2;
            // 
            // cbbAccount
            // 
            this.cbbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAccount.FormattingEnabled = true;
            this.cbbAccount.Location = new System.Drawing.Point(738, 8);
            this.cbbAccount.Name = "cbbAccount";
            this.cbbAccount.Size = new System.Drawing.Size(184, 26);
            this.cbbAccount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(655, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Account";
            // 
            // txtVerified
            // 
            this.txtVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtVerified.Location = new System.Drawing.Point(426, 40);
            this.txtVerified.Name = "txtVerified";
            this.txtVerified.Size = new System.Drawing.Size(200, 26);
            this.txtVerified.TabIndex = 18;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPayment.Location = new System.Drawing.Point(479, 72);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(147, 26);
            this.txtPayment.TabIndex = 20;
            // 
            // txtADLimit
            // 
            this.txtADLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtADLimit.Location = new System.Drawing.Point(454, 7);
            this.txtADLimit.Name = "txtADLimit";
            this.txtADLimit.Size = new System.Drawing.Size(172, 26);
            this.txtADLimit.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(323, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Verified";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(323, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Payment Methods";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(323, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "ADCreate Limit";
            // 
            // fBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(948, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fBM";
            this.Text = "fBM";
            ((System.ComponentModel.ISupportInitialize)(this.datagBM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datagBM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameBM;
        private System.Windows.Forms.TextBox txtSharingstt;
        private System.Windows.Forms.TextBox txtIdBM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdCreateLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verified;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethods;
        private System.Windows.Forms.DataGridViewTextBoxColumn iaAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSA;
        private System.Windows.Forms.TextBox txtVerified;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtADLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}