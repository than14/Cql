using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Dynamic;
using System.Windows.Documents;
using System.Runtime.Remoting.Contexts;
using DeviceId;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Windows.Shapes;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Entity;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Threading;
using System.IO;
using Path = System.IO.Path;
using Newtonsoft.Json.Linq;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using xNet;
using System.Diagnostics;
using Selenium;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagementApp
{
    public partial class fTest : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        string chromeDriverPath;
        private List<Account> accountList; // Danh sách lưu trữ dữ liệu AC
        public fTest()
        {
            InitializeComponent();
            LoadData();
            foreach (DataGridViewColumn column in datagAC.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            datagAC.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(datagAC_ColumnHeaderMouseClick); ;
            datagAC.ClearSelection();
        }
        List<Account> loadAC()
        {
            var sortedData = db.Accounts.ToList();
            accountList = sortedData;
            // datagAC.DataSource = accountList;
            return sortedData;
        }

        void LoadData()
        {
            var result = from ac in db.Accounts
                         join st in db.StaffAccounts on ac.idSA equals st.idSA
                         join dv in db.Devices on ac.idDevice equals dv.idDevice
                         select new
                         {
                             ac.UID,
                             ac.NameAC,
                             ac.passAC,
                             ac.twoFA,
                             ac.emailAC,
                             ac.passEmail,

                             //Country = ac.CountryAC,
                             //AdstatusAC = ac.AdStatus == 1 ? "ON" : ac.AdStatus == 2 ? "OFF" : "Unknown",
                             //NameST = st.NameSA,
                             //deviceac = dv.nameDevice == "" ? "" : dv.nameDevice,
                             //ac.idAC
                         };
            datagAC.DataSource = result.ToList();
            datagAC.ClearSelection();

            //clear();
        }

      
        public void clear()
        {
            //txtname.Text = string.Empty;
            //txtID.Text = string.Empty;
            // txtCountry.Text = string.Empty;
            //cbOff.Checked = false;
            //cbOn.Checked = false;
        }

        public int ADStatus()
        {
            int ADSta = 2;
            //if (cbOn.Checked == true)
            //{
            //    ADSta = 1;
            //    cbOff.Checked = false;
            //}
            //else if (cbOff.Checked == true)
            //{
            //    ADSta = 2;
            //    cbOn.Checked = false;
            //}
            return ADSta;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = Properties.Settings.Default["UserSA"].ToString();
            //var device = new DeviceIdBuilder().AddMachineName().ToString();
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(richtxAC.Text))
            {
                MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
            }
            else
            {
                foreach (string line in richtxAC.Lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 5)
                    {
                        string UID = parts[0].Trim();
                        string Pass = parts[1].Trim();
                        string TWOFA = parts[2].Trim();
                        string email = parts[3].Trim();
                        string passemail = parts[4].Trim();
                        var uidAC = db.Accounts.Where(bien => bien.UID == UID).FirstOrDefault();
                        if (uidAC == null)
                        {
                            MessageBox.Show($"{TWOFA}, {Pass}, {TWOFA}, {email}, {passemail}");
                            db.Accounts.Add(new Account
                            {
                                UID = UID,
                                passAC = Pass,
                                twoFA = TWOFA,
                                emailAC = email,
                                passEmail = passemail,
                                idSA = max.idSA,
                            });
                            db.StaffaAccounts.Add(new StaffaAccount
                            {
                                idAC = UID,
                                idSA = max.idSA
                            });
                        }
                        else
                        {
                            db.StaffaAccounts.Add(new StaffaAccount
                            {
                                idAC = UID,
                                idSA = max.idSA
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
            clear();
        }

        private void datagAC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Binding();
        }

        private void datagAC_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void datagAC_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void datagAC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
  
        }

        private void datagAC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //if (e.ColumnIndex == 4)
            //{
            //    // Lấy giá trị của ô
            //    var cellValue = e.Value;
            //    datagAC.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //    // Kiểm tra giá trị của ô và thay đổi màu nền tương ứng
            //    if (cellValue != null && cellValue.ToString() == "ON")
            //    {
            //        e.CellStyle.BackColor = Color.Green; // Màu xanh khi trạng thái là ON
            //        e.CellStyle.ForeColor = Color.White;
            //        e.CellStyle.Font = new Font(datagAC.DefaultCellStyle.Font, FontStyle.Bold);
            //    }
            //    else if (cellValue != null && cellValue.ToString() == "OFF")
            //    {
            //        e.CellStyle.BackColor = Color.Red; // Màu đỏ khi trạng thái là OFF
            //        e.CellStyle.ForeColor = Color.White;
            //        e.CellStyle.Font = new Font(datagAC.DefaultCellStyle.Font, FontStyle.Bold);
            //    }
            //}
            if (e.RowIndex < 0 || e.RowIndex == datagAC.NewRowIndex)
                return;
            if (e.ColumnIndex == this.datagAC.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
                    menustripAC.Tag = hti.RowIndex; // Lưu trữ thông tin dòng được nhấp chuột phải
                                                    ////////////////////////////////
                                                    //var hitTestInfo = datagAC.HitTest(e.X, e.Y);
                                                    //if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                                                    //{
                                                    //    datagAC.ClearSelection();
                                                    //    datagAC.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex].Selected = true;

                    //    //menustripAC.Show(datagAC, e.Location);
                    //    //menustripAC.Tag = hitTestInfo.RowIndex; // Lưu trữ thông tin dòng được nhấp chuột phải
                }
            }
        }



        private void OpenChromeWithProfile(string UID, string password)
        {
            string ChromePaths = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FPlus\\ChromeProfiles", UID);//fplus
            if (!Directory.Exists(ChromePaths))
            {
                ChromePaths = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data");//chrome
            }
            if (!Directory.Exists(ChromePaths))  //
            {
                //check firefox
            }
            else
            {
                //ChromeDriver chrom = null;
                try
                {
                    ChromeOptions op = new ChromeOptions();
                    op.AddArgument("user-data-dir=" + ChromePaths);//"user-data-dir="chỉ định thư mục chứa dữ liệu người dùng (profile) Chrome sẽ sử dụng khi khởi động.
                    if (ChromePaths == Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\\Chrome\\User Data"))
                    {
                        JObject profiles = JToken.Parse(FileHelperc.ReadFile(Path.Combine(ChromePaths, "Local State"))).SelectToken("profile.info_cache") as JObject;
                        List<string> profile = profiles.Properties().Where(prop => prop.Value["name"] != null && prop.Value["name"].ToString() == UID).Select(prop => prop.Name).ToList();
                        op.AddArgument("profile-directory=" + profile[0]);//chon profile lên
                    }
                    try
                    {
                        Process[] chromeProcesses = Process.GetProcessesByName("chrome");
                        foreach (Process process in chromeProcesses)
                        {
                            process.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    op.AddArgument("--disable-notifications");
                    op.AddArgument("--noerrdialogs");
                    op.AddArgument("--hide-crash-restore-bubble");
                    op.AddExcludedArgument("enable-automation");
                    ChromeDriverService services = ChromeDriverService.CreateDefaultService();
                    services.HideCommandPromptWindow = true;
                    ChromeDriver driver = new ChromeDriver(services, op);
                    driver.Navigate().GoToUrl("https://www.facebook.com/");
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                    try
                    {
                        IWebElement loginButton = wait.Until(d => d.FindElement(By.CssSelector("div.x1rg5ohu.x1n2onr6.x3ajldb.x1ja2u2z")));
                        IWebElement divElement = driver.FindElement(By.CssSelector("div.x1rg5ohu.x1n2onr6.x3ajldb.x1ja2u2z"));
                        divElement.Click();
                        Thread.Sleep(1000);
                        IWebElement divElementmore = driver.FindElement(By.CssSelector("div.x9f619.x1n2onr6.x1ja2u2z.x78zum5.xdt5ytf.x193iq5w.xeuugli.x1r8uery.x1iyjqo2.xs83m0k.x150jy0e.x1e558r4.xjkvuk6.x1iorvi4"));
                        string namefb = divElementmore.Text;
                        divElementmore.Click();//vào trang cá nhân
                        Thread.Sleep(1000);
                        
                        IWebElement divElementmorefriend = driver.FindElement(By.CssSelector("div.x9f619.x1n2onr6.x1ja2u2z.x78zum5.xdt5ytf.x2lah0s.x193iq5w.x6s0dn4.xyamay9"));

                        string fbfriend = divElementmorefriend.Text;
                        IWebElement divElementmorelocal = driver.FindElement(By.CssSelector("div.xu06os2.x1ok221b"));
                        string fblocal = divElementmorelocal.Text;


                        
                        if (!Checklogin(driver)) return;
                        string cookie = GetCookie(driver, out HttpRequest http);
                        if (cookie == null)
                        {
                            MessageBox.Show("Cookie is null");
                        }
                        else
                        {
                            MessageBox.Show("Cookie: " + cookie);
                        }
                        //txtCookie.Text = cookie.ToString();
                        string TokenEAAB = GetTokenEAAB(driver, http, out string fb_dtsg, out string fbname);
                        //txtToken.Text = TokenEAAB;
                        //driver.Quit();
                        //driver.Dispose();

                    }
                    catch (WebDriverTimeoutException ex)
                    {
                        MessageBox.Show("Timed out waiting for page to load: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
            




            ////////////////////////////////////////////////////////////////////////////////////////////////////
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArgument($"user-data-dir=C:\\ChromeProfiles\\Profile_{UID}");
            options.AddArgument("window-size=600,550");
            //IWebDriver driver = new ChromeDriver(service, options);



            string url = "https://www.facebook.com";
            if (rbMBasic.Checked)
            {
                url = "https://mbasic.facebook.com";
            }
            else if (rbM.Checked)
            {
                url = "https://m.facebook.com";
            }
            //driver.Navigate().GoToUrl(url);

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
                                        List<string> profile = profiles.Properties().Where(prop => prop.Value["name"] != null && prop.Value["name"].ToString() == UID).Select(prop => prop.Name).ToList();
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

        private async void getinfo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Tuple<string, string>> selectedAccounts = new List<Tuple<string, string>>();

            foreach (DataGridViewRow row in datagAC.SelectedRows)
            {
                string username = row.Cells["UID"].Value.ToString().Trim();
                string password = row.Cells["passAC"].Value.ToString().Trim();
                selectedAccounts.Add(Tuple.Create(username, password));
            }

            List<Task> tasks = new List<Task>();

            foreach (var account in selectedAccounts)
            {
                tasks.Add(Task.Run(() => OpenChromeWithProfile(account.Item1, account.Item2)));
            }

            await Task.WhenAll(tasks);
        }

        private void datagAC_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = datagAC.Columns[e.ColumnIndex].Name;

            // Xác định hướng sắp xếp
            bool isAscending = datagAC.SortOrder != SortOrder.Ascending;

            // Truy vấn cơ sở dữ liệu để lấy dữ liệu đã được sắp xếp

            IQueryable<Account> query = db.Accounts;

            // Sắp xếp dữ liệu dựa trên tên cột và hướng sắp xếp
            if (isAscending)
            {
                query = query.OrderByDynamic(columnName, true);
            }
            else
            {
                query = query.OrderByDynamic(columnName, false);
            }

            // Lấy dữ liệu và cập nhật DataGridView
            var sortedData = query.ToList();
            datagAC.DataSource = sortedData;

        }
    }
}
