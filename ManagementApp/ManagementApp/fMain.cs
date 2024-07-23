using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class fMain : Form
    {
        private DataManagementEntities db = new DataManagementEntities();
        private string user = Properties.Settings.Default["UserSA"].ToString();
        
        public fMain()
        {
            InitializeComponent();
            LoadUsername();
            loadDashboard();
            Hidenbt();
            LoadDeviceName();
            GetIdRole(user);
        }
        public string LoadUsername()
        {
            //var user = Properties.Settings.Default["UserSA"].ToString();
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            txtname.Text = max.NameSA;
            return max.idSA;
        }
        public int? GetIdRole(string idSA)
        {
            var roleStaff = db.StaffAccounts.FirstOrDefault(sa => sa.UserSA == user);
            return roleStaff?.idRole;
        }
        private void Hidenbt()
        {
            var user = Properties.Settings.Default["UserSA"].ToString();
            var query = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            if (query.idRole == 1)
            {
                btnStaff.Visible = false;
            }
        }

        private void LoadDeviceName()
        {
            string deviceName = Environment.MachineName;
            // Hiển thị tên thiết bị
            lbnamedv.Text = $"Device Name: {deviceName}";
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            currentFormChild?.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false; ;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panMain.Controls.Add(childForm);
            panMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void loadDashboard()
        {
            OpenChildForm(new fDashboard());
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fStaff());
            lbname.Text = btnStaff.Text;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAccount());
            lbname.Text = btnAccount.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            //this.Close();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           //if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông Báp", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
           //{ e.Cancel = true; }
            
        }
        private void Logout()
        {
            fLogin loginForm = new fLogin();
            this.Hide();
            loginForm.ShowDialog();
            // Đóng form chính (MainForm)
            //this.Close();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Xử lý đăng xuất
                Logout();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbname.Text = "Dashboard";
            loadDashboard();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDevice());
            lbname.Text = btnDevice.Text;
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fPage());
            lbname.Text = btnPage.Text;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fGroup());
            lbname.Text = btnGroup.Text;
        }

        private void btnBM_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fBM());
            lbname.Text = btnBM.Text;
        }
    }
}
