//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;

//namespace WinFormsApp
//{
//    public partial class Form1 : Form
//    {
//        RadioButton rbWWW;
//        RadioButton rbMBasic;
//        RadioButton rbM;

//        public Form1()
//        {
//            InitializeComponent();

//            // Thêm dữ liệu mẫu vào DataGridView
//            dataGridView1.Columns.Add("ID", "ID");
//            dataGridView1.Columns.Add("Username", "Username");
//            dataGridView1.Columns.Add("Password", "Password");
//            dataGridView1.Rows.Add("1", "your_username1", "your_password1");
//            dataGridView1.Rows.Add("2", "your_username2", "your_password2");
//            dataGridView1.Rows.Add("3", "your_username3", "your_password3");

//            // Gán sự kiện chuột phải cho DataGridView
//            dataGridView1.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);

//            // Thêm các RadioButton
//            rbWWW = new RadioButton
//            {
//                Text = "www",
//                Location = new System.Drawing.Point(10, 10),
//                Checked = true // Mặc định chọn phiên bản www
//            };

//            rbMBasic = new RadioButton
//            {
//                Text = "mbasic",
//                Location = new System.Drawing.Point(70, 10)
//            };

//            rbM = new RadioButton
//            {
//                Text = "m",
//                Location = new System.Drawing.Point(150, 10)
//            };

//            this.Controls.Add(rbWWW);
//            this.Controls.Add(rbMBasic);
//            this.Controls.Add(rbM);
//        }

//        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
//        {
//            // Kiểm tra xem có phải chuột phải không
//            if (e.Button == MouseButtons.Right)
//            {
//                var hti = dataGridView1.HitTest(e.X, e.Y);
//                if (hti.RowIndex != -1)
//                {
//                    // Thêm hoặc bỏ chọn dòng khi nhấn chuột phải
//                    if (!dataGridView1.Rows[hti.RowIndex].Selected)
//                    {
//                        dataGridView1.ClearSelection();
//                        dataGridView1.Rows[hti.RowIndex].Selected = true;
//                    }

//                    // Hiển thị context menu
//                    ContextMenu contextMenu = new ContextMenu();
//                    contextMenu.MenuItems.Add(new MenuItem("Open in Chrome", new EventHandler(OpenSelectedRowsInChrome)));
//                    contextMenu.Show(dataGridView1, new System.Drawing.Point(e.X, e.Y));
//                }
//            }
//        }

//        private async void OpenSelectedRowsInChrome(object sender, EventArgs e)
//        {
//            List<Tuple<string, string, string>> selectedAccounts = new List<Tuple<string, string, string>>();

//            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
//            {
//                string id = row.Cells["ID"].Value.ToString();
//                string username = row.Cells["Username"].Value.ToString();
//                string password = row.Cells["Password"].Value.ToString();
//                selectedAccounts.Add(Tuple.Create(id, username, password));
//            }

//            List<Task> tasks = new List<Task>();

//            foreach (var account in selectedAccounts)
//            {
//                tasks.Add(Task.Run(() => OpenChromeWithProfile(account.Item1, account.Item2, account.Item3)));
//            }

//            await Task.WhenAll(tasks);
//        }

//        private void OpenChromeWithProfile(string profileId, string username, string password)
//        {
//            var service = ChromeDriverService.CreateDefaultService();
//            service.HideCommandPromptWindow = true;

//            var options = new ChromeOptions();
//            options.AddArgument($"user-data-dir=C:\\ChromeProfiles\\Profile_{profileId}"); // Thay đổi đường dẫn này tới nơi bạn muốn lưu profile

//            // Đặt kích thước cửa sổ khi khởi động
//            options.AddArgument("window-size=1200,800");

//            IWebDriver driver = new ChromeDriver(service, options);

//            // Xác định phiên bản Facebook để mở dựa trên RadioButton đã chọn
//            string url = "https://www.facebook.com";
//            if (rbMBasic.Checked)
//            {
//                url = "https://mbasic.facebook.com";
//            }
//            else if (rbM.Checked)
//            {
//                url = "https://m.facebook.com";
//            }

//            driver.Navigate().GoToUrl(url);

//            // Tự động đăng nhập
//            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email"))).SendKeys(username);
//            driver.FindElement(By.Id("pass")).SendKeys(password);
//            driver.FindElement(By.Name("login")).Click();

//            // Đợi đến khi đăng nhập thành công
//            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[placeholder='Search Facebook']")));

//            // Lấy thông tin tài khoản
//            string accountName = driver.FindElement(By.CssSelector("span[id^='profilePicHeader_']")).Text;
//            // Thêm các thao tác để lấy các thông tin khác như ngày tạo, bạn bè, page, group

//            // Ví dụ lấy số lượng bạn bè
//            driver.Navigate().GoToUrl("https://www.facebook.com/me/friends");
//            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[role='heading']")));
//            string friendsCount = driver.FindElement(By.CssSelector("div[role='heading']")).Text;

//            // Đóng trình duyệt khi hoàn thành
//            driver.Quit();

//            // Hiển thị thông tin tài khoản (hoặc lưu trữ ở đâu đó)
//            MessageBox.Show($"Account Name: {accountName}\nFriends Count: {friendsCount}");
//        }
//    }
//}
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System;


