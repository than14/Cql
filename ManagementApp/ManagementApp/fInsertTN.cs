using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class fInsertTN : Form
    {
        DataManagementEntities db = new DataManagementEntities();
        public fInsertTN()
        {
            InitializeComponent();
            loadcbbTN();
        }
        void loadcbbTN()
        {
            try
            {
                var tn = db.Resources
                                 .Select(r => new { r.Id, r.Name })
                                 .ToList();
                cbbTN.DataSource = tn;
                cbbTN.DisplayMember = "Name";
                cbbTN.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var getidtn = int.Parse(cbbTN.SelectedValue.ToString());
            try
            {
                switch (getidtn)
                {
                    case 1:
                        foreach (string line in richTextBox1.Lines)
                        {
                            string[] parts = line.Split('/');// Tách chuỗi thành hai phần dựa trên dấu 

                            if (parts.Length >= 2)
                            {
                                string beforePipe = parts[0].Trim(); // Giá trị trước dấu 
                                string afterPipe = parts[1].Trim(); // Giá trị sau dấu 
                                
                                db.PageMs.Add(new PageM
                                {
                                    idP = beforePipe,
                                    idAC = afterPipe
                                });
                                db.Accounts.Add(new Account
                                {
                                    UID = afterPipe 
                                });
                                db.SaveChanges();

                            //MessageBox.Show($"Before: {beforePipe}, After: {afterPipe}");//show giá trị
                            }
                            else
                            {
                                string wholeLine = line.Trim();// Xử lý trường hợp không có dấu  trong dòng
                                MessageBox.Show($"Whole line: {wholeLine}");
                            }
                        }
                        MessageBox.Show("Đã thêm thành công!");
                        break;
                    case 2:
                        foreach (string line in richTextBox1.Lines)
                        {
                            string[] parts = line.Split('/'); 

                            if (parts.Length >= 2)
                            {
                                string beforePipe = parts[0].Trim(); 
                                string afterPipe = parts[1].Trim(); 
                                db.GroupMs.Add(new GroupM
                                {
                                    idG = beforePipe,
                                    idAC = afterPipe
                                });
                                db.SaveChanges();
                            }
                            else
                            {
                                string wholeLine = line.Trim();
                                MessageBox.Show($"Whole line: {wholeLine}");
                            }
                        }
                        MessageBox.Show("Đã thêm thành công!");
                        break;
                    case 3:
                        foreach (string line in richTextBox1.Lines)
                        {
                            string[] parts = line.Split('/');

                            if (parts.Length >= 2)
                            {
                                string beforePipe = parts[0].Trim();
                                string afterPipe = parts[1].Trim();
                                db.BMs.Add(new BM
                                {
                                    id = beforePipe,
                                    idAC = int.Parse(afterPipe)
                                });
                                db.SaveChanges();
                            }
                            else
                            {
                                string wholeLine = line.Trim();
                                MessageBox.Show($"Whole line: {wholeLine}");
                            }
                        }
                        MessageBox.Show("Đã thêm thành công!");
                        break;
                    case 4:
                        foreach (string line in richTextBox1.Lines)
                        {
                            string[] parts = line.Split('/');

                            if (parts.Length >= 2)
                            {
                                string beforePipe = parts[0].Trim();
                                string afterPipe = parts[1].Trim();
                                db.Payouts.Add(new Payout
                                {
                                    id = beforePipe,
                                    idAC = int.Parse(afterPipe)
                                });
                                db.SaveChanges();
                            }
                            else
                            {
                                string wholeLine = line.Trim();
                                MessageBox.Show($"Whole line: {wholeLine}");
                            }
                        }
                        MessageBox.Show("Đã thêm thành công!");
                        break;
                    case 5:
                        foreach (string line in richTextBox1.Lines)
                        {
                            string[] parts = line.Split('/');

                            if (parts.Length >= 2)
                            {
                                string beforePipe = parts[0].Trim();
                                string afterPipe = parts[1].Trim();
                                db.ADS.Add(new AD
                                {
                                    id = beforePipe,
                                    idAC = int.Parse(afterPipe)
                                });
                                db.SaveChanges();
                            }
                            else
                            {
                                string wholeLine = line.Trim();
                                MessageBox.Show($"Whole line: {wholeLine}");
                            }
                        }
                        MessageBox.Show("Đã thêm thành công!");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string[] parts = text.Split('|');

            if (parts.Length >= 2)
            {
                string beforePipe = parts[0].Trim(); // Giá trị trước dấu |
                string afterPipe = parts[1].Trim();  // Giá trị sau dấu |

                MessageBox.Show($"Before |: {beforePipe}\nAfter |: {afterPipe}");
            }
            else
            {
                MessageBox.Show("None.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string line in richTextBox1.Lines)
            {
                // Tách chuỗi thành hai phần dựa trên dấu |
                string[] parts = line.Split('|');

                if (parts.Length >= 2)
                {
                    string beforePipe = parts[0].Trim(); // Giá trị trước dấu |
                    string afterPipe = parts[1].Trim(); // Giá trị sau dấu |

                    // Để làm gì đó với giá trị beforePipe và afterPipe ở đây
                    MessageBox.Show($"Before: {beforePipe}, After: {afterPipe}");
                }
                else
                {
                    // Xử lý trường hợp không có dấu | trong dòng
                    string wholeLine = line.Trim();
                    Console.WriteLine($"Whole line: {wholeLine}");
                }
            }
        }
    }
}
