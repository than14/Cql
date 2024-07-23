namespace ManagementApp
{
    partial class fDevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagDevice = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtserialnumber = new System.Windows.Forms.TextBox();
            this.txtTypeDevice = new System.Windows.Forms.TextBox();
            this.txtNameDevice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagDevice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagDevice
            // 
            this.datagDevice.AllowUserToAddRows = false;
            this.datagDevice.AllowUserToDeleteRows = false;
            this.datagDevice.AllowUserToOrderColumns = true;
            this.datagDevice.AllowUserToResizeRows = false;
            this.datagDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idDevice,
            this.nameDevice,
            this.serialnumber,
            this.typeDevice,
            this.NameSA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagDevice.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagDevice.Location = new System.Drawing.Point(12, 3);
            this.datagDevice.MultiSelect = false;
            this.datagDevice.Name = "datagDevice";
            this.datagDevice.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagDevice.RowHeadersVisible = false;
            this.datagDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagDevice.Size = new System.Drawing.Size(924, 422);
            this.datagDevice.TabIndex = 0;
            this.datagDevice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagDevice_CellFormatting);
            this.datagDevice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagDevice_MouseClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // idDevice
            // 
            this.idDevice.DataPropertyName = "idDevice";
            this.idDevice.HeaderText = "Mã thiết bị";
            this.idDevice.Name = "idDevice";
            this.idDevice.ReadOnly = true;
            this.idDevice.Width = 81;
            // 
            // nameDevice
            // 
            this.nameDevice.DataPropertyName = "nameDevice";
            this.nameDevice.HeaderText = "Tên Thiết Bị";
            this.nameDevice.Name = "nameDevice";
            this.nameDevice.ReadOnly = true;
            this.nameDevice.Width = 90;
            // 
            // serialnumber
            // 
            this.serialnumber.DataPropertyName = "serialnumber";
            this.serialnumber.HeaderText = "Số Serial";
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ReadOnly = true;
            this.serialnumber.Width = 74;
            // 
            // typeDevice
            // 
            this.typeDevice.DataPropertyName = "typeDevice";
            this.typeDevice.HeaderText = "Loại Thiết Bị";
            this.typeDevice.Name = "typeDevice";
            this.typeDevice.ReadOnly = true;
            this.typeDevice.Width = 91;
            // 
            // NameSA
            // 
            this.NameSA.DataPropertyName = "NameSA";
            this.NameSA.HeaderText = "Staff";
            this.NameSA.Name = "NameSA";
            this.NameSA.ReadOnly = true;
            this.NameSA.Width = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagDevice);
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
            this.btnClear.Location = new System.Drawing.Point(738, 82);
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
            this.btnDel.Location = new System.Drawing.Point(738, 47);
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
            this.btnEdit.Location = new System.Drawing.Point(559, 82);
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
            this.btnAdd.Location = new System.Drawing.Point(559, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtserialnumber
            // 
            this.txtserialnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtserialnumber.Location = new System.Drawing.Point(115, 40);
            this.txtserialnumber.Name = "txtserialnumber";
            this.txtserialnumber.Size = new System.Drawing.Size(298, 26);
            this.txtserialnumber.TabIndex = 2;
            // 
            // txtTypeDevice
            // 
            this.txtTypeDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTypeDevice.Location = new System.Drawing.Point(115, 72);
            this.txtTypeDevice.Name = "txtTypeDevice";
            this.txtTypeDevice.Size = new System.Drawing.Size(298, 26);
            this.txtTypeDevice.TabIndex = 3;
            // 
            // txtNameDevice
            // 
            this.txtNameDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameDevice.Location = new System.Drawing.Point(115, 7);
            this.txtNameDevice.Name = "txtNameDevice";
            this.txtNameDevice.Size = new System.Drawing.Size(298, 26);
            this.txtNameDevice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thiết bị";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbStaff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtserialnumber);
            this.panel1.Controls.Add(this.txtTypeDevice);
            this.panel1.Controls.Add(this.txtNameDevice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 119);
            this.panel1.TabIndex = 2;
            // 
            // cbbStaff
            // 
            this.cbbStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(558, 12);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(259, 26);
            this.cbbStaff.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(496, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Staff";
            // 
            // fDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(948, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fDevice";
            this.Text = "fDevice";
            ((System.ComponentModel.ISupportInitialize)(this.datagDevice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView datagDevice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtserialnumber;
        private System.Windows.Forms.TextBox txtTypeDevice;
        private System.Windows.Forms.TextBox txtNameDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSA;
    }
}