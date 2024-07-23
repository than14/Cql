using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class fLogin : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["UserSA"] = txtUser.Text;
            // var datauser = linq.NHANVIENs.Max(ss => ss.userNV);
            // var datapass = linq.NHANVIENs.Max(ss => ss.passNV);
            string username = txtUser.Text;
            string password = txtPassword.Text;
            var user = db.StaffAccounts .FirstOrDefault(u => u.UserSA == username && u.PassWordSA == password);
            if (user != null)
            {
                if (user.idRole == 2)
                {
                    //MessageBox.Show("Đăng nhập thành công!");
                    fMain fm = new fMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    //MessageBox.Show("Đăng nhập thành công!");
                    fMain fm = new fMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                //if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông Báp", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                //{ e.Cancel = true; }
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true; // Ngăn chặn tiếng 'beep' mặc định khi nhấn Enter
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
