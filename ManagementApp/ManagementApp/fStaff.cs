using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ManagementApp
{
    public partial class fStaff : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        public fStaff()
        {
            InitializeComponent();
            datagStaff.Size = new Size(924, 430);
            loadData();
        }

        void loadData()
        {
            var result = from st in db.StaffAccounts     
                         select new { st.idSA, st.UserSA, st.NameSA, st.noteSA, st.RoleSA.NamRole  };
            datagStaff.DataSource = result.ToList();
        }

        void Binding()
        {
            txtname.DataBindings.Clear();
            txtuser.DataBindings.Clear();
            txtnote.DataBindings.Clear();
            txtuser.DataBindings.Add(new Binding("Text", datagStaff.DataSource, "UserSA"));
            txtname.DataBindings.Add(new Binding("Text", datagStaff.DataSource, "NameSA"));
            txtnote.DataBindings.Add(new Binding("Text", datagStaff.DataSource, "NoteSA"));
            var isActiveRole = datagStaff.CurrentRow.Cells["idRole"].Value.ToString();
            if (isActiveRole == "Admin")
            {
                rdbAdmin.Checked = true;
                rdbST.Checked = false;
            }
            else
            {
                rdbAdmin.Checked = false;
                rdbST.Checked = true;
            }

        }

        public string TuTangMNV()
        {
            var resuft = "NV001";

            //var linq = new DataModel1DataContext();

            var max = db.StaffAccounts.Max(ss => ss.idSA);

            if (!string.IsNullOrEmpty(max))
            {
                int maNVSplit = int.Parse(max.Substring(2, max.Length - 2));
                maNVSplit++;
                string numericPart = maNVSplit.ToString().PadLeft(3, '0');
                resuft = "NV" + numericPart;
            }
            return resuft;
        }

        public void clear()
        {
            txtname.Text = string.Empty;
            txtuser.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtnote.Text = string.Empty;
            rdbAdmin.Checked = false;
            rdbST.Checked = false;
        }

        public int role()
        {
            int marole = 1;
            if (rdbAdmin.Checked == true)
            {
                marole = 2;
                rdbST.Checked = false;
            }
            else if (rdbST.Checked == true)
            {
                marole = 1;
                rdbAdmin.Checked = false;
            }
            return marole;
        }

        private void datagStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
            panelinfo.Visible = true;
            panelResetPass.Visible = false;
            //if(panelinfo.Visible = true)
            //{
            //    //datagStaff.Size = new Size(550, 430);
            //}
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = datagStaff.Rows[e.RowIndex];
                var idValue = selectedRow.Cells["idSA"].Value;
                if (idValue != null)
                {
                    string id = idValue.ToString();
                    //MessageBox.Show($"ID: {id}");
                    AboutStafffD(id);
                    AboutStafffA(id);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
            }
            else
            {

                db.StaffAccounts.Add(new StaffAccount
                {

                    idSA = TuTangMNV(),
                    UserSA = txtuser.Text,
                    NameSA = txtname.Text,
                    PassWordSA = txtpass.Text,
                    idRole = role(),
                    noteSA = txtnote.Text,
                    cerated = DateTime.Now,
                });
            }
            db.SaveChanges();
            loadData();
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void AboutStafffD(string id)
        {
            var result = from d in db.Devices
                         join sa in db.StaffAccounts on d.idSA equals sa.idSA
                         where d.idSA == id
                         select new { DeviceName = d.nameDevice };
            datagDevice.DataSource = result.ToList();
        }

        private void AboutStafffA(string id)
        {
            var result = from a in db.StaffaAccounts
                         join sa in db.StaffAccounts on a.idSA equals sa.idSA
                         where a.idSA == id
                         select new { UIDAccount = a.idAC };
            datagAccount.DataSource = result.ToList();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagStaff.SelectedRows.Count != 0)
                {

                    DataGridViewRow row = this.datagStaff.SelectedRows[0];
                    var data = row.Cells["idSA"].Value;

                    var max = db.StaffAccounts.Where(bien => bien.idSA == data).FirstOrDefault();

                    if (max != null)
                    {
                        var accountList = db.Accounts.Where(bien => bien.idSA == max.idSA).ToList();
                        if (accountList.Count() > 0)
                        {
                            if (MessageBox.Show("Xóa user nhân viên sẽ xóa hết tài nguyên thuộc về nhân viên đó. Xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                            {
                                db.Accounts.RemoveRange(accountList);
                                //linq.TAINGUYENs.DeleteAllOnSubmit(checkTaiNguyen);
                                db.StaffAccounts.Remove(max);

                                db.SaveChanges();
                                loadData();
                            }
                        }
                        else
                        {
                            db.StaffAccounts.Remove(max);

                            db.SaveChanges();
                            loadData();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.datagStaff.SelectedRows[0];
                var data = row.Cells["idSA"].Value;
                var max = db.StaffAccounts.Where(bien => bien.idSA == data).FirstOrDefault();
                if (max != null)
                {
                    if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtuser.Text))
                    {
                        MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
                    }
                    else
                    {
                        max.UserSA = txtuser.Text;
                        max.NameSA = txtname.Text;
                        max.idRole = role();
                        max.noteSA = txtnote.Text;
                    }
                }
                db.SaveChanges();
                loadData();
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void datagStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex <0 || e.RowIndex == datagStaff.NewRowIndex)
                return;
            if(e.ColumnIndex == this.datagStaff.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }


        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtResetPass.Text = string.Empty;
            panelinfo.Visible = false;
            panelResetPass.Visible = true;
        }

        private void datagStaff_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = datagStaff.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    // Thêm hoặc bỏ chọn dòng khi nhấn chuột phải
                    if (!datagStaff.Rows[hti.RowIndex].Selected)
                    {
                        datagStaff.ClearSelection();
                        datagStaff.Rows[hti.RowIndex].Selected = true;
                    }
                    contextMenuStrip1.Show(datagStaff, e.Location);
                    contextMenuStrip1.Tag = hti.RowIndex; 
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelResetPass.Visible = false;
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.datagStaff.SelectedRows[0];
                var data = row.Cells["idSA"].Value;
                var max = db.StaffAccounts.Where(bien => bien.idSA == data).FirstOrDefault();
                if (max != null)
                {
                    if (string.IsNullOrWhiteSpace(txtResetPass.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo");
                    }
                    else
                    {
                        max.PassWordSA = txtResetPass.Text;
                        DialogResult result = MessageBox.Show("Reset mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            panelResetPass.Visible = false;
                        }
                        db.SaveChanges();
                        loadData();
                        clear();

                    }
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
