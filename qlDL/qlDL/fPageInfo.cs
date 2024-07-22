using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlDL
{
    public partial class fPageInfo : Form
    {

        private string accessToken = "your_access_token_here";
        private string pageId = "your_page_id_here";
        public fPageInfo()
        {
            InitializeComponent();
        }

        private async Task fPageInfo_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = $"https://graph.facebook.com/{pageId}?fields=name,about,description&access_token={accessToken}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        // Xử lý dữ liệu JSON ở đây
                        MessageBox.Show(jsonResponse);
                    }
                    else
                    {
                        MessageBox.Show("Failed to fetch data. Status code: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
