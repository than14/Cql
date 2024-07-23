using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementApp
{
    public partial class fDevice : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        private string user = Properties.Settings.Default["UserSA"].ToString();
        public fDevice()
        {
            InitializeComponent();
            loadcbbStaff();
            loadData(GetIdSA(user));
        }
        int? GetIdRole(string user)
        {
            var roleStaff = db.StaffAccounts.FirstOrDefault(sa => sa.UserSA == user);
            return roleStaff?.idRole;
        }
        public string GetIdSA(string user)
        {
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            return max.idSA;
        }

        void loadData(string idSA)
        {
            var roleSA = GetIdRole(user);
            if (roleSA == 2)
            {
                var result = from dv in db.Devices
                             join st in db.StaffAccounts on dv.idSA equals st.idSA
                             select new { dv.idDevice, dv.nameDevice, dv.serialnumber, dv.typeDevice, st.NameSA };
                datagDevice.DataSource = result.ToList();
            }
            else
            {
                datagDevice.Columns.Clear();
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn
                {
                    Name = "STT", HeaderText = "STT", Width = 50,
                };
                datagDevice.Columns.Add(sttColumn);
                
                var result = from dv in db.Devices
                             where dv.idSA == idSA
                             select new
                             {
                                 idDevice = dv.idDevice,
                                 nameDevice = dv.nameDevice,
                                 serialnumber = dv.serialnumber,
                                 typeDevice = dv.typeDevice,
                             };
                datagDevice.DataSource = result.ToList();

                datagDevice.Columns["idDevice"].HeaderText = "ID Thiết Bị";
                datagDevice.Columns["nameDevice"].HeaderText = "Tên Thiết Bị";
                datagDevice.Columns["serialnumber"].HeaderText = "Số Serial";
                datagDevice.Columns["typeDevice"].HeaderText = "Loại Thiết Bị";
                datagDevice.Columns["nameDevice"].Width = 150;
            }

        }

        void Binding()
        {
            //
            DataGridViewRow row = this.datagDevice.SelectedRows[0];
            txtNameDevice.DataBindings.Clear();
            txtserialnumber.DataBindings.Clear();
            txtTypeDevice.DataBindings.Clear();
            //cbbStaff.DataBindings.Clear();
            txtNameDevice.DataBindings.Add(new Binding("Text", datagDevice.DataSource, "nameDevice"));
            txtserialnumber.DataBindings.Add(new Binding("Text", datagDevice.DataSource, "serialnumber"));
            txtTypeDevice.DataBindings.Add(new Binding("Text", datagDevice.DataSource, "typeDevice"));
            //var ccbcheck = datagDevice.CurrentRow.Cells["NameSA"].Value.ToString();
            //var max = db.StaffAccounts.Where(bien => bien.NameSA == ccbcheck).FirstOrDefault();
            //if (max != null)
            //{
            //    string name = max.NameSA;
            //    //string idSA = max.idSA;
            //    //string datatn = row.Cells["tenTN"].Value.ToString();
            //    cbbStaff.Text = name;
            //    //cbbStaff.DisplayMember = name;
            //    //cbbStaff.ValueMember = idSA;
            //}
        }
        public void clear()
        {
            txtNameDevice.Text = string.Empty;
            txtserialnumber.Text = string.Empty;
            txtTypeDevice.Text = string.Empty;
            cbbStaff.Text = string.Empty;
        }

        public void loadcbbStaff()
        {
            try
            {
                var data = from a in db.StaffAccounts select a;
                cbbStaff.DataSource = data.ToList();
                cbbStaff.DisplayMember = "NameSA";
                cbbStaff.ValueMember = "idSA";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void datagDevice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == datagDevice.NewRowIndex)
                return;
            if (e.ColumnIndex == this.datagDevice.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameDevice.Text) || string.IsNullOrWhiteSpace(txtTypeDevice.Text))
                {
                    MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
                }
                else
                {

                    db.Devices.Add(new Device
                    {
                        nameDevice = txtNameDevice.Text,
                        serialnumber = txtserialnumber.Text,
                        typeDevice = txtTypeDevice.Text,
                        idSA = cbbStaff.SelectedValue.ToString(),
                    });
                }
                db.SaveChanges();
                loadData(GetIdSA(user));
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void datagDevice_MouseClick(object sender, MouseEventArgs e)
        {
            Binding();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagDevice.SelectedRows.Count != 0)
                {

                    DataGridViewRow row = this.datagDevice.SelectedRows[0];
                    //var data = row.Cells["idDevice"].Value;
                    int deviceId = (int)datagDevice.SelectedRows[0].Cells["idDevice"].Value;
                    var device = db.Devices.FirstOrDefault(a => a.idDevice == deviceId);
                    //string datastr = data.ToString();
                    //var max = db.Device.Where(bien => bien.idDevice == int.Parse(datastr));
                    
                    if (MessageBox.Show("Xóa user nhân viên sẽ xóa hết tài nguyên thuộc về nhân viên đó. Xác nhận xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        db.Devices.Remove(device);
                        db.SaveChanges();
                        loadData(GetIdSA(user));
                    }
                    else
                    {
                        db.SaveChanges();
                        loadData(GetIdSA(user));
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
                //DataGridViewRow row = this.datagDevice.SelectedRows[0];
                int data = (int)datagDevice.SelectedRows[0].Cells["idDevice"].Value;
                var max = db.Devices.Where(bien => bien.idDevice == data).FirstOrDefault();
                if (max != null)
                {
                    if (string.IsNullOrWhiteSpace(txtNameDevice.Text) || string.IsNullOrWhiteSpace(txtTypeDevice.Text))
                    {
                        MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
                    }
                    else
                    {
                        max.nameDevice = txtNameDevice.Text;
                        max.serialnumber = txtserialnumber.Text;
                        max.typeDevice = txtTypeDevice.Text;
                        max.idSA = cbbStaff.SelectedValue.ToString();
                    }
                }
                db.SaveChanges();
                loadData(GetIdSA(user));
                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
