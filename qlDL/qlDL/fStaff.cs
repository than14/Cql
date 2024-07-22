using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlDL
{
    public partial class fStaff : Form
    {
        DataManagementEntities dbEntityes = new DataManagementEntities();
        dataProvider dtP = new dataProvider();
        public fStaff()
        {
            InitializeComponent();
            //datagStaff.DataSource = dt.loadStaff();
            load();
            
            //addBinding();
        }
        void load()
        {
            var result = from st in dbEntityes.StaffAccounts
                         select new { st.idSA, st.UserSA, st.NameSA, st.RoleSA.NamRole };

            //var result1 = from st in dbEntities.StaffAccounts 
            //select new { USER = st.UserSA, NAME = st.NameSA, ROLE as [Phân Quyền] = st.idRole };
            datagStaff.DataSource = result.ToList();
            role();
        }
        void addBinding()
        {
            //int rows = 0;
            //txtuser.DataBindings.Add(new Binding("text", datagStaff.DataSource, "USER"));
            //txtname.DataBindings.Add(new Binding("text", datagStaff.DataSource, "NAME"));
            //DataGridViewRow rowIndex = (datagStaff.SelectedRows[0]);
            //int checkBoxColumnIndex = datagStaff.Columns["ROLE"].Index;
            ////string checkBoxRowIndex = datagStaff.Rows["ROLE"].Index.ToString();
            //var cellValue = datagStaff.Rows[rowIndex].Cells[checkBoxColumnIndex].Value;
            //int intValue = int.Parse(cellValue.ToString());
            //if (intValue == 1)
            //{
            //    cbADM.Checked = true;
            //}
            //else if (intValue == 0)
            //{
            //    cbST.Checked = true;
            //}
            //cbST.DataBindings.Add(new Binding("checked", datagStaff.DataSource, "ROLE"));

            //datagStaff.Rows[rowIndex].Cells[checkBoxColumnIndex].Value = true;
        }

        private void datagStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int sl = datagStaff.Rows.Count;
            //try
            //{

            //    int rowIndex = e.RowIndex;
            //    Binding existingBinding = txtuser.DataBindings["Text"];
            //    Binding existingBinding1 = txtname.DataBindings["Text"];
            //    if (existingBinding != null && existingBinding1 != null)
            //    {
            //        txtname.DataBindings.Remove(existingBinding1);
            //        txtuser.DataBindings.Remove(existingBinding);
            //    }
            //    txtuser.DataBindings.Add(new Binding("text", datagStaff.DataSource, "USER"));
            //    txtname.DataBindings.Add(new Binding("text", datagStaff.DataSource, "NAME"));
            //    int checkBoxColumnIndex = datagStaff.Columns["ROLE"].Index;
            //    var cellValue = datagStaff.Rows[rowIndex].Cells[checkBoxColumnIndex].Value;
            //    int intValue = int.Parse(cellValue.ToString());
            //    if (intValue == 1)
            //    {
            //        cbADM.Checked = true;
            //        cbST.Checked = false;
            //    }
            //    else if (intValue == 0)
            //    {
            //        cbADM.Checked = false;
            //        cbST.Checked = true;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}

            
        }

        private void datagStaff_Click(object sender, EventArgs e)
        {
            //addBinding();
        }

        private void datagStaff_SelectionChanged(object sender, EventArgs e)
        {
            int sl = datagStaff.SelectedRows.Count;
            if (sl > 0)
            {
                var selecrow = datagStaff.SelectedRows[0];
                txtname.Text = selecrow.Cells["nameSA"].Value.ToString();
            }
            //int sl = datagStaff.SelectedRows.Count;
            //    if (sl > 0)
            //    {
            //        DataGridViewRow row = this.datagStaff.SelectedRows[0];
            //        string dataUser = row.Cells["USER"].Value.ToString();
            //        txtuser.Text = dataUser;
            //        //string datapass = row.Cells["passNV"].Value.ToString();
            //        //tbpwNV.Text = datapass;
            //        string dataname = row.Cells["NAME"].Value.ToString();
            //        txtname.Text = dataname;
            //        var datarole = row.Cells["ROLE"].Value;
            //        if (datarole != null)
            //        {
            //            cbADM.Checked = true;
            //        }
            //        //else { tbnoteNV.Text = ""; }

            //    }               
        }
        public string TuTangMNV()
        {
            var resuft = "NV001";

            //var linq = new DataModel1DataContext();

            var max = dbEntityes.StaffAccounts.Max(ss => ss.idSA);

            if (!string.IsNullOrEmpty(max))
            {
                int maNVSplit = int.Parse(max.Substring(2, max.Length - 2));
                maNVSplit++;
                string numericPart = maNVSplit.ToString().PadLeft(3, '0');
                resuft = "NV" + numericPart;
            }
            return resuft;
        }
        public int role ()
        {
            int marole = 0 ;
            if(cbADM.Checked == true)
            {
                marole = 2;
                cbST.Checked = false;
            }else if(cbST.Checked == true)
            {
                marole = 1;
                cbADM.Checked = false;
            }
            return marole;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dbEntityes.StaffAccounts.Add(new StaffAccount
            {
                idSA = TuTangMNV(),
                UserSA = txtuser.Text,
                NameSA = txtname.Text,
                PassWordSA = txtpass.Text,
                idRole = role(),
                
            });
            dbEntityes.SaveChanges();
            load();
            clear();

        }
        public void clear()
        {
            txtname.Text = string.Empty;
            txtuser.Text = string.Empty;
            txtpass.Text = string.Empty;
            txtnote.Text = string.Empty;
            cbADM.Checked =false;
            cbST.Checked=false;
        }
        private void cbADM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbADM.Checked)
            {
                cbST.Checked = false;
            }
        }

        private void cbST_CheckedChanged(object sender, EventArgs e)
        {
            if (cbST.Checked)
            {
                cbADM.Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(datagStaff.SelectedRows.Count != 0)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
