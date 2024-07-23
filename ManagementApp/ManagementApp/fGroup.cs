using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class fGroup : Form
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
        string GetIdSA(string user)
        {
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            return max.idSA;
        }
        public fGroup()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData(string searchText = null, string sortColumn = null, bool ascending = true)
        {
            var roleSA = GetIdRole(user);
            IQueryable<GroupModel> result;

            if (roleSA == 2)
            {
                result = from gr in db.GroupMs
                         select new GroupModel
                         {
                             idG = gr.idG,
                             nameG = gr.nameG,
                             MemCount = gr.MemCount,
                             countryG = gr.countryG,
                             languageG = gr.languageG,
                             Topic = gr.Topic,
                             
                         };
            }
            else
            {
                var idSA = GetIdSA(user);

                result = from gr in db.GroupMs
                         //where gr.idAC == idSA
                         select new GroupModel
                         {
                             idG = gr.idG,
                             nameG = gr.nameG,
                             MemCount = gr.MemCount,
                             countryG = gr.countryG,
                             languageG = gr.languageG,
                             Topic = gr.Topic,

                         };
            }

            // Áp dụng tìm kiếm
            if (!string.IsNullOrEmpty(searchText))
            {
                result = result.Where(a => a.idG.Contains(searchText) ||
                                         a.nameG.Contains(searchText));
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
            datagGroup.DataSource = result.ToList();
            datagGroup.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = Properties.Settings.Default["UserSA"].ToString();
            var max = db.StaffAccounts.Where(bien => bien.UserSA == user).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(richtxGroup.Text))
            {
                MessageBox.Show("Vui lòng nhập các trường có dấu *!", "Thông báo");
            }
            else
            {
                foreach (string line in richtxGroup.Lines)
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
            richtxGroup.Text = string.Empty;
        }

        private void ptReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string sortColumn = datagGroup.Columns.Cast<DataGridViewColumn>()
                                                .FirstOrDefault(c => c.HeaderCell.SortGlyphDirection != SortOrder.None)?
                                                .Name; // Lấy tên cột đang được sắp xếp
            bool ascending = true; // Giá trị mặc định nếu không có cột nào được sắp xếp
            if (!string.IsNullOrEmpty(sortColumn) && columnSortDirections.ContainsKey(sortColumn))
            {
                ascending = columnSortDirections[sortColumn];
            }
            LoadData(searchText, sortColumn, ascending);
            txtSearch.Text = string.Empty;
        }

        private void datagGroup_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                string columnName = datagGroup.Columns[e.ColumnIndex].Name;

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

                datagGroup.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = isAscending ? SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void datagGroup_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti =   datagGroup.HitTest(e.X, e.Y);
                if (hti.RowIndex != -1)
                {// Thêm hoặc bỏ chọn dòng khi nhấn chuột phải
                    if (!datagGroup.Rows[hti.RowIndex].Selected)
                    {
                        datagGroup.ClearSelection();
                        datagGroup.Rows[hti.RowIndex].Selected = true;
                    }
                    menustripGroup.Show(datagGroup, e.Location);
                    menustripGroup.Tag = hti.RowIndex;
                }
            }
        }

        private void datagGroup_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == datagGroup.NewRowIndex)
                return;
            if (e.ColumnIndex == this.datagGroup.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagGroup.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = datagGroup.SelectedRows.Count - 1; i >= 0; i--)
                        {
                            string id = datagGroup.SelectedRows[i].Cells["PID"].Value.ToString();
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
            datagGroup.ClearSelection();
        }
    }
}
