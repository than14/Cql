using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using System.IO;
using Path = System.IO.Path;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using xNet;
using System.ComponentModel;
using System.Text;
using System.Linq.Dynamic;
using System.Windows.Documents;
using System.Runtime.Remoting.Contexts;
using DeviceId;
using OpenQA.Selenium.Support.UI;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using System.Security.Cryptography;
using System.Net.Http;
using System.Xml.Linq;


namespace ManagementApp
{
    public partial class fAccountT : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        string chromeDriverPath;
        private Dictionary<string, bool> columnSortDirections = new Dictionary<string, bool>();
        private string user = "admin";
        string deviceName = Environment.MachineName;
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
        public fAccountT()
        {
            InitializeComponent();
            //try
            //{
            //    chromeDriverPath = new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            //    MessageBox.Show(chromeDriverPath, "Update ChromeDriver Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Update ChromeDriver Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            LoadData();
            loadcbbStatus();
            panel3.Visible = false;
            datagAC.ClearSelection();
        }
        
        void LoadData(string statusFilter = null, string searchText = null, string sortColumn = null, bool ascending = true)
        {
            var roleSA = GetIdRole(user);
            IQueryable<AccountModel> result;

            if (roleSA == 2)
            {
                result = from ac in db.Accounts
                         select new AccountModel
                         {
                             UID = ac.UID,
                             NameAC = ac.NameAC,
                             passAC = ac.passAC,
                             twoFA = ac.twoFA,
                             emailAC = ac.emailAC,
                             passEmail = ac.passEmail,
                             Status = ac.Status
                         };

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    result = result.Where(ac => ac.Status == statusFilter);
                }
            }
            else
            {
                var idSA = GetIdSA(user);

                result = from ac in db.Accounts
                         join sa in db.StaffaAccounts on ac.UID equals sa.idAC
                         where sa.idSA == idSA
                         select new AccountModel
                         {
                             UID = ac.UID,
                             NameAC = ac.NameAC,
                             passAC = ac.passAC,
                             twoFA = ac.twoFA,
                             emailAC = ac.emailAC,
                             passEmail = ac.passEmail,
                             Status = ac.Status
                         };

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    result = result.Where(ac => ac.Status == statusFilter);
                }
            }

            // Áp dụng tìm kiếm
            if (!string.IsNullOrEmpty(searchText))
            {
                result = result.Where(a => a.UID.Contains(searchText) ||
                                         a.NameAC.Contains(searchText) ||
                                         a.emailAC.Contains(searchText) ||
                                         a.passEmail.Contains(searchText) ||
                                         a.twoFA.Contains(searchText) ||
                                         a.passAC.Contains(searchText));
            }

            // Áp dụng sắp xếp
            if (!string.IsNullOrEmpty(sortColumn))
            {
                if (ascending)
                {
                    result = result.OrderByDynamic(sortColumn, true);
                }
                else
                {
                    result = result.OrderByDynamic(sortColumn, false);
                }
            }
            datagAC.DataSource = result.ToList();
            datagAC.ClearSelection();
        }

        void loadcbbStatus()
        {
            var items = new List<cbbStatus>
            {
                new cbbStatus { ID = 1, Value = "live" },
                new cbbStatus { ID = 2, Value = "checkpoin" },
                new cbbStatus { ID = 3, Value = "notlive" },
                new cbbStatus { ID = 4, Value = "all" }
            };
            cbbLoc.DataSource = items;
            cbbLoc.DisplayMember = "Value"; 
            cbbLoc.ValueMember = "ID";
            cbbLoc.SelectedIndex = items.FindIndex(item => item.Value == "all");
        }
        
        

        void Binding()
        {

            txt2FA.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtnameAC.DataBindings.Clear();
            txtpassAC.DataBindings.Clear();
            txtpassMail.DataBindings.Clear();
            txt2FA.DataBindings.Add(new Binding("Text", datagAC.DataSource, "twoFA"));
            txtEmail.DataBindings.Add(new Binding("Text", datagAC.DataSource, "emailAC"));
            txtnameAC.DataBindings.Add(new Binding("Text", datagAC.DataSource, "NameAC"));
            txtpassAC.DataBindings.Add(new Binding("Text", datagAC.DataSource, "passAC"));
            txtpassMail.DataBindings.Add(new Binding("Text", datagAC.DataSource, "passEmail"));

        }

        public void clear()
        {
            txtpassAC.Text = string.Empty;
            txtnameAC.Text = string.Empty;
            txt2FA.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtpassMail.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = Properties.Settings.Default["UserSA"].ToString();
            //var device = new DeviceIdBuilder().AddMachineName().ToString();
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(richtxAC.Text) )
            {
                MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
            }
            else
            {
                foreach (string line in richtxAC.Lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 5 )
                    {
                        string UID = parts[0].Trim();
                        string Pass = parts[1].Trim();
                        string TWOFA = parts[2].Trim();
                        string email = parts[3].Trim();
                        string passemail = parts[4].Trim();
                        var uidAC = db.Accounts.Where(bien => bien.UID == UID).FirstOrDefault();
                        if(uidAC == null)
                        {
                            //MessageBox.Show($"{TWOFA}, {Pass}, {TWOFA}, {email}, {passemail}");
                            db.Accounts.Add(new Account
                            {
                                UID = UID,
                                passAC = Pass,
                                twoFA = TWOFA,
                                emailAC = email,
                                passEmail = passemail,
                                //idSA = max.idSA
                            });
                            db.StaffaAccounts.Add(new StaffaAccount
                            {
                                idAC = UID,
                                //idSA = max.idSA,
                                nameDevice = deviceName
                            });
                        }
                        else
                        {
                            db.StaffaAccounts.Add(new StaffaAccount
                            {
                                idAC = UID,
                                idSA = max.idSA,
                                nameDevice = deviceName
                            });
                        }
                    }
                    else
                    {
                        string wholeLine = line.Trim();// Xử lý trường hợp không có dấu  trong dòng
                        MessageBox.Show($"Whole line: {wholeLine}");
                    }
                }
            }
            db.SaveChanges();
            LoadData();
            richtxAC.Text=string.Empty;
            //datagAC.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.datagAC.SelectedRows[0];
                var data = row.Cells["UID"].Value;
                var max = db.Accounts.Where(bien => bien.UID == data).FirstOrDefault();
                if (max != null)
                {
                    max.passAC = txtpassAC.Text;
                    max.NameAC = txtnameAC.Text;
                    max.twoFA = txt2FA.Text;
                    max.emailAC = txtEmail.Text;
                    max.passEmail = txtpassMail.Text;
                }
                db.SaveChanges();
                LoadData();
                clear();
                datagAC.ClearSelection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void datagAC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Binding();
        }

        private void datagAC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 9)
            {
                // Lấy giá trị của ô
                var cellValue = e.Value;
                datagAC.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // Kiểm tra giá trị của ô và thay đổi màu nền tương ứng
                if (cellValue != null && cellValue.ToString() == "live")
                {
                    e.CellStyle.BackColor = Color.DarkGreen; // Màu xanh khi trạng thái là ON
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font(datagAC.DefaultCellStyle.Font, FontStyle.Bold);
                }
                else if (cellValue != null && cellValue.ToString() == "checkpoin" || cellValue != null && cellValue.ToString() == "notlive")
                {
                    e.CellStyle.BackColor = Color.DarkRed; // Màu đỏ khi trạng thái là OFF
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font(datagAC.DefaultCellStyle.Font, FontStyle.Bold);
                }
            }
            if (e.RowIndex < 0 || e.RowIndex == datagAC.NewRowIndex)
                return;
            if (e.ColumnIndex == this.datagAC.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
            //datagAC.ClearSelection();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagAC.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = datagAC.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            string id = datagAC.SelectedRows[i].Cells["UID"].Value.ToString();
                            var entityToDelete = db.Accounts.Find(id); 

                            if (entityToDelete != null)
                            {
                                var SAaAC = db.StaffaAccounts.Where(bien => bien.idAC == entityToDelete.UID).ToList();

                                if (SAaAC.Count() > 0)
                                {
                                    db.StaffaAccounts.RemoveRange(SAaAC);
                                    db.Accounts.Remove(entityToDelete);
                                }
                                else { db.Accounts.Remove(entityToDelete); }
                            }
                        }
                        db.SaveChanges();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            datagAC.ClearSelection();
        }

        private void datagAC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = datagAC.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {
                    // Thêm hoặc bỏ chọn dòng khi nhấn chuột phải
                    if (!datagAC.Rows[hti.RowIndex].Selected)
                    {
                        datagAC.ClearSelection();
                        datagAC.Rows[hti.RowIndex].Selected = true;
                    }
                    menustripAC.Show(datagAC, e.Location);
                    menustripAC.Tag = hti.RowIndex;
                }
            }
        }

        private void pictureBoxHidden_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void OpenChromeWithProfile(string profileId, string username, string password)
        {
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArgument($"user-data-dir=C:\\ChromeProfiles\\Profile_{profileId}");
            options.AddArgument("window-size=600,550");
            IWebDriver driver = new ChromeDriver(service, options);

            string url = "https://www.facebook.com";
            if (rbMBasic.Checked)
            {
                url = "https://mbasic.facebook.com";
            }
            else if (rbM.Checked)
            {
                url = "https://m.facebook.com";
            }
            driver.Navigate().GoToUrl(url);

            // Tự động đăng nhập
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.Id("yourElementId")));

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(exp ExpectedConditions.ElementIsVisible(By.Id("email"))).SendKeys(username);
            //driver.FindElement(By.Id("pass")).SendKeys(password);
            //driver.FindElement(By.Name("login")).Click();


            // Đóng trình duyệt khi hoàn thành
            // driver.Quit();
        }

        private async void getAboutAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của ô được chọn
            //string cellValue = datagAC.CurrentCell.Value.ToString();


            Thread t1 = new Thread(() => 
            {
                int so_luong_dang_chay = 0;
                for (int i = 0; i < datagAC.Rows.Count; i++)
                {
                    while (true)
                    {
                        if (so_luong_dang_chay < (int)numericUpDownThread.Value)
                            break;
                        Thread.Sleep(500);
                    }
                    if (!datagAC.Rows[i].Selected)
                    {
                        continue;
                    }
                    so_luong_dang_chay++;
                    int index = i;
                    Thread t2 = new Thread(() => {
                        try
                        {
                            string UID = datagAC.Rows[index].Cells["UID"].Value.ToString().Trim();
                            string pass = datagAC.Rows[index].Cells["passAC"].Value.ToString().Trim();
                            string ChromePaths = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FPlus\\ChromeProfiles", UID); //check chromeprofile fplus truoc
                            if (!Directory.Exists(ChromePaths))
                            {
                                ChromePaths = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data");
                            }
                            if (!Directory.Exists(ChromePaths))  //
                            {
                                //check firefox
                            }
                            else
                            {
                                ChromeDriver chrome = null;
                                try
                                {
                                    ChromeOptions options = new ChromeOptions();
                                    options.AddArgument("user-data-dir=" + ChromePaths);
                                    if (ChromePaths == Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data"))
                                    {
                                        JObject profiles = JToken.Parse(FileHelperc.ReadFile(Path.Combine(ChromePaths, "Local State"))).SelectToken("profile.info_cache") as JObject;
                                        List<string> profile = profiles.Properties().Where(prop => prop.Value["name"] != null && prop.Value["name"].ToString()==UID).Select(prop => prop.Name).ToList();
                                        options.AddArgument("profile-directory=" + profile[0]);
                                    }
                                    options.AddArgument("--disable-notifications");
                                    options.AddArgument("--noerrdialogs");
                                    options.AddArgument("--hide-crash-restore-bubble");
                                    options.AddExcludedArgument("enable-automation");
                                    ChromeDriverService services = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(chromeDriverPath));
                                    services.HideCommandPromptWindow = true;
                                    Thread.Sleep(100);
                                    chrome = new ChromeDriver(services, options);
                                    chrome.Navigate().GoToUrl("https://www.facebook.com/");
                                    Thread.Sleep(5000);
                                    if (!Checklogin(chrome)) return;
                                    string cookie = GetCookie(chrome, out HttpRequest http);
                                    string TokenEAAB = GetTokenEAAB(chrome, http, out string fb_dtsg, out string fbname);
                                    chrome.Quit();
                                    chrome.Dispose();

                                    //check thong tin tai nguyen cua acc

                                }
                                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
                        so_luong_dang_chay--;

                    });
                    t2.Start();
                    Thread.Sleep(2000);
                }
                while (true)
                {
                    if (so_luong_dang_chay == 0)
                        break;
                    Thread.Sleep(500);
                }
            });
            t1.Start();

            foreach (DataGridViewRow row in datagAC.SelectedRows)
            {
                string UID = row.Cells["UID"].Value.ToString();
                string password = row.Cells["passAC"].Value.ToString();

            }
            List<Task> tasks = new List<Task>();

            //foreach (var id in selectedIds)
            //{
            //    tasks.Add(Task.Run(() => OpenChromeWithProfile(id.Item1, id.Item2, id.Item3)));
            //}

            await Task.WhenAll(tasks);

            //fb fm = new fb(cellValue);
            //fm.ShowDialog();
        }
        private bool Checklogin(ChromeDriver chrome)
        {
            try
            {
                chrome.FindElement(By.CssSelector("label[class='uiLinkButton']")).Click();
                Thread.Sleep(10000);
            }
            catch (Exception ex) { }
            try
            {
                IWebElement userNavigationLabel = chrome.FindElement(By.CssSelector("[data-visualcompletion='ignore-dynamic']"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static string GetCookie(ChromeDriver chrome, out HttpRequest http)
        {
            string cookie = "";
            try
            {
                for (int i = 0; i < chrome.Manage().Cookies.AllCookies.Count; i++)
                {
                    try
                    {
                        string name = chrome.Manage().Cookies.AllCookies.ElementAt(i).Name.ToString().Trim();
                        string value = chrome.Manage().Cookies.AllCookies.ElementAt(i).Value.ToString().Trim();

                        if (!"".Equals(name))
                            cookie += $"{name}={value};";
                    }
                    catch (Exception) { }
                }
            }
            catch { }
            http = new HttpRequest();
            http.ConnectTimeout = 180000;
            http.UserAgent = (string)chrome.ExecuteScript("return navigator.userAgent;");
            http.Cookies = new CookieDictionary();
            for (int c = 0; c < cookie.Split(';').Length; c++)
            {
                try
                {
                    string name = cookie.Split(';')[c].Split('=')[0].Trim();
                    string value = cookie.Split(';')[c].Substring(cookie.Split(';')[c].IndexOf('=') + 1).Trim();
                    if (http.Cookies.ContainsKey(name))
                        http.Cookies.Remove(name);

                    if ("c_user".Equals(name) || "xs".Equals(name) || "wd".Equals(name) || "sb".Equals(name) || "datr".Equals(name) || "fr".Equals(name) || "presence".Equals(name) || "locale".Equals(name) || "m_pixel_ratio".Equals(name))
                        http.Cookies.Add(name, value);
                }
                catch (Exception ex) { }
            } //import cookies htpp
            return cookie;
        }

        public static string GetTokenEAAB(ChromeDriver chrome, HttpRequest http, out string fb_dtsg, out string fbname)
        {
            string TokenEAAB = "";
            chrome.Navigate().GoToUrl("https://adsmanager.facebook.com/adsmanager/manage/campaigns");
            DateTime startTime = DateTime.Now;
            TimeSpan timeout = TimeSpan.FromSeconds(30);
            while (true)
            {
                try
                {
                    TokenEAAB = chrome.PageSource.Split(new[] { "window.__accessToken=\"" }, StringSplitOptions.None)[1].Split(new[] { "\";" }, StringSplitOptions.None)[0];
                    break;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(500);
                    TimeSpan elapsedTime = DateTime.Now - startTime;
                    if (elapsedTime >= timeout)
                    {
                        break;
                    }
                }
            }
            fb_dtsg = chrome.PageSource.Split(new[] { "\"token\":\"" }, StringSplitOptions.None)[1].Split('\"')[0];
            JToken accountInfos = JToken.Parse(http.Get("https://graph.facebook.com/v16.0/me?fields=name,businesses{id}&access_token=" + TokenEAAB).ToString());
            fbname = accountInfos["name"].ToString();
            return TokenEAAB;
        }

        private void EditProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible=true;
        }

        private void DatagAC_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex != 0)
            {
                string columnName = datagAC.Columns[e.ColumnIndex].Name;

                bool isAscending;
                if (columnSortDirections.ContainsKey(columnName))
                {
                    isAscending = !columnSortDirections[columnName];
                    columnSortDirections[columnName] = isAscending;
                }
                else
                {
                    isAscending = true;
                    columnSortDirections[columnName] = isAscending;
                }

                string statusfilter = ""; //lọc theo trạng thái
                string searchtext = txtSearch.Text.Trim(); // lấy văn bản tìm kiếm từ textbox
                LoadData(statusfilter, searchtext, columnName, isAscending);

                datagAC.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void cbbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cbbLoc.SelectedItem.ToString();
            string statusFilter = null;

            if (selectedId == "live")
            {
                statusFilter = "live";
            }
            else if (selectedId == "checkpoin")
            {
                statusFilter = "checkpoin";
            }
            else if (selectedId == "notlive")
            {
                statusFilter = "notlive";
            }
            LoadData(statusFilter);
            datagAC.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string statusFilter = ""; 
            string sortColumn = datagAC.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.HeaderCell.SortGlyphDirection != SortOrder.None)?
                                                .Name; // Lấy tên cột đang được sắp xếp

            bool ascending = true; // Giá trị mặc định nếu không có cột nào được sắp xếp
            if (!string.IsNullOrEmpty(sortColumn) && columnSortDirections.ContainsKey(sortColumn))
            {
                ascending = columnSortDirections[sortColumn];
            }

            LoadData(statusFilter, searchText, sortColumn, ascending);
            txtSearch.Text = string.Empty;
        }

        private void AboutACD(string id)
        {
            var result = from d in db.StaffaAccounts
                         where d.idAC == id
                         select new { d.nameDevice };
            var data = result.ToList();
            datagDevice.DataSource = data;
        }

        private void AboutACS(string id)
        {
            var result = from sa in db.StaffaAccounts
                         join s in db.StaffAccounts on sa.idSA equals s.idSA
                         //join a in db.Accounts on sa.idAC equals a.UID
                         where sa.idAC == id
                         select new { Staff = s.NameSA };
            datagStaff.DataSource = result.ToList();
        }

        private void datagAC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = datagAC.Rows[e.RowIndex];
                var idValue = selectedRow.Cells["UID"].Value;
                if (idValue != null)
                {
                    string id = idValue.ToString();
                    //MessageBox.Show($"ID: {id}");
                    AboutACD(id);
                    AboutACS(id);
                }
            }
        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void getInfoStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible=true;
            
        }

        private void ptReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void GetnameUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var token = "EAABsbCS1iHgBO0g7T63SZCdLKnpPGncKAfg2IARRAulLudH50kzkk5hOtzXmser0k3g1kbhfkcH8uZAy8YKsgJ2ziMRMTRsfOtofhEKzkkBmjvKWGJ1haDRxqCz4QLmCvXpn0ZBwHLMLmKgmXfPfWKQg71w3YQ6jXTsRIuDbZCSbvomFSgw7r1b2YUb4Te4vL6O1adb2dwZDZD";
            var accessToken = "EAALVIodQKxUBO08qnHGlKsePSB7u6MSP7tIxATZBfHSZA82tYZCKzpbntAksXHzVgw8piejoXlUxW5e39ZChAP3gpzLA5yHJyh2OMsevE6cOthdes12hHRmxZBTgRUJJmDnC6HMLjGU3d9CCbAZAFYbfw5DkqjrbVSEpjA4P0oncMv5ru7WZCVFGYut5rcchIGc7QndeuSKZAAPfwgXuwL1uKyRqn7BZCleidd5wZD";
            var url = $"https://graph.facebook.com/v20.0/me?fields=name&access_token={token}";

            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(url);
                    var data = JObject.Parse(response);
                    var name = data["name"]?.ToString();
                    MessageBox.Show("name: " + name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
    }
}
