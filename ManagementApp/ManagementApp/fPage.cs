using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class fPage : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        private Dictionary<string, bool> columnSortDirections = new Dictionary<string, bool>();
        private string user = Properties.Settings.Default["UserSA"].ToString();
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
        public fPage()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData( string searchText = null, string sortColumn = null, bool ascending = true)
        {
            var roleSA = GetIdRole(user);
            IQueryable<PageModel> result;

            if (roleSA == 2)
            {
                result = from page in db.PageMs
                         select new PageModel
                         {
                             idP=page.idP,
                             nameP=page.nameP,
                             FollowCount=page.FollowCount,
                             VideoCount=page.VideoCount,
                             ViewCount=page.ViewCount,
                             Adbreak=page.Adbreak,
                             Reel=page.Reel,
                             Bonus=page.Bonus,
                             RightManager=page.RightManager,
                             Verified=page.Verified,
                             countryP=page.countryP,
                             languageP=page.languageP,
                             Topic=page.Topic
                         };

                
            }
            else
            {
                var idSA = GetIdSA(user);

                result = from page in db.PageMs
                         select new PageModel
                         {
                             idP = page.idP,
                             nameP = page.nameP,
                             FollowCount = page.FollowCount,
                             VideoCount = page.VideoCount,
                             ViewCount = page.ViewCount,
                             Adbreak = page.Adbreak,
                             Reel = page.Reel,
                             Bonus = page.Bonus,
                             RightManager = page.RightManager,
                             Verified = page.Verified,
                             countryP = page.countryP,
                             languageP = page.languageP,
                             Topic = page.Topic
                         };
            }

            // Áp dụng tìm kiếm
            if (!string.IsNullOrEmpty(searchText))
            {
                result = result.Where(a => a.idP.Contains(searchText) ||
                                         a.nameP.Contains(searchText));
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
            datagPage.DataSource = result.ToList();
            datagPage.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = Properties.Settings.Default["UserSA"].ToString();
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(richtxPage.Text))
            {
                MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
            }
            else
            {
                foreach (string line in richtxPage.Lines)
                {
                        //var uidAC = db.Accounts.Where(bien => bien.UID == UID).FirstOrDefault();
                            db.PageMs.Add(new PageM
                            {
                                idP = line,
                            });
                }
            }
            db.SaveChanges();
            LoadData();
            richtxPage.Text = string.Empty;
        }

        private void datagPage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == datagPage.NewRowIndex)
                return;
            if (e.ColumnIndex == this.datagPage.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }



        private void datagPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = datagPage.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {// Thêm hoặc bỏ chọn dòng khi nhấn chuột phải
                    if (!datagPage.Rows[hti.RowIndex].Selected)
                    {
                        datagPage.ClearSelection();
                        datagPage.Rows[hti.RowIndex].Selected = true;
                    }
                    menustripPage.Show(datagPage, e.Location);
                    menustripPage.Tag = hti.RowIndex;
                }
            }
        }

        private void datagPage_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                string columnName = datagPage.Columns[e.ColumnIndex].Name;

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
                string searchtext = txtSearch.Text.Trim(); // lấy văn bản tìm kiếm từ textbox
                LoadData(searchtext, columnName, isAscending);

                datagPage.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void ptReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string sortColumn = datagPage.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.HeaderCell.SortGlyphDirection != SortOrder.None)?
                                                .Name; // Lấy tên cột đang được sắp xếp
            bool ascending = true; // Giá trị mặc định nếu không có cột nào được sắp xếp
            if (!string.IsNullOrEmpty(sortColumn) && columnSortDirections.ContainsKey(sortColumn))
            {
                ascending = columnSortDirections[sortColumn];
            }
            LoadData( searchText, sortColumn, ascending);
            txtSearch.Text = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagPage.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = datagPage.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            string id = datagPage.SelectedRows[i].Cells["PID"].Value.ToString();
                            var entityToDelete = db.PageMs.Find(id);
                                db.PageMs.Remove(entityToDelete);
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
            datagPage.ClearSelection();
        }
    }
}
