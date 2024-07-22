namespace qlDL
{
    partial class fPageInfo
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
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.txtPageID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagInfo = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAccessToken.Location = new System.Drawing.Point(143, 96);
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(190, 29);
            this.txtAccessToken.TabIndex = 0;
            // 
            // txtPageID
            // 
            this.txtPageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPageID.Location = new System.Drawing.Point(507, 96);
            this.txtPageID.Name = "txtPageID";
            this.txtPageID.Size = new System.Drawing.Size(190, 29);
            this.txtPageID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(419, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "page ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(4, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "access-token";
            // 
            // datagInfo
            // 
            this.datagInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data});
            this.datagInfo.Location = new System.Drawing.Point(12, 179);
            this.datagInfo.Name = "datagInfo";
            this.datagInfo.Size = new System.Drawing.Size(768, 203);
            this.datagInfo.TabIndex = 4;
            // 
            // data
            // 
            this.data.HeaderText = "DATA";
            this.data.Name = "data";
            // 
            // fPageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 550);
            this.Controls.Add(this.datagInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPageID);
            this.Controls.Add(this.txtAccessToken);
            this.Name = "fPageInfo";
            this.Text = "fPageInfo";
            ((System.ComponentModel.ISupportInitialize)(this.datagInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.TextBox txtPageID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}