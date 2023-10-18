using Client.Entities;
using Client.Model;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucListUser : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;
        private string date = null;
        public ucListUser()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            LoadData();
        }

        // lấy danh sách user
        public void LoadData()
        {
            string search = txtSearch.Text;



            var listUser = _apiClient.GetData<User>($"Users/GetListUsers?search={search}&birthday={date}").Data;
            // cập nhật hình ảnh
            foreach (var item in listUser)
            {
                item.Image = LoadProductImage(item.Avatar);
            }
            gridListUser.DataSource = listUser;

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateBirthday_EditValueChanged(object sender, EventArgs e)
        {
            date = dateBirthday.DateTime.Date.ToString("yyyy-MM-dd");
            if (date == "0001-01-01")
            {
                date = null;

            }

            LoadData();

        }

        private void SubBtnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dateBirthday.Text = null;
            LoadData();
        }

        private Image LoadProductImage(string imagePath)
        {
            if (imagePath != null)
            {
                return LoadImageFromUrl($"http://localhost:5000{imagePath.Replace("\\", "/")}");
            }

            return LoadImageFromUrl(@"D:\ThucTap\OrderFood\Client\Images\quan-com-tam-o-ha-noi-.jpg");
        }

        private Image LoadImageFromUrl(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(url);
                using (MemoryStream memStream = new MemoryStream(data))
                {
                    Image img = System.Drawing.Image.FromStream(memStream);
                    return img;
                }
            }
        }

        private void SubBtnSelect_Click(object sender, EventArgs e)
        {
            var gridView = gridListUser.MainView as GridView;

            if (gridView != null)
            {
                var selectedRowsHandles = gridView.GetSelectedRows();
                var selectedData = new List<User>();

                foreach (var rowHandle in selectedRowsHandles)
                {
                    var data = gridView.GetRow(rowHandle) as User;
                    if (data != null)
                    {
                        selectedData.Add(data);
                    }
                }
                SessionData.User = selectedData[0];

                MessageBox.Show(selectedData.Count.ToString());

            }
        }

        private void SubBtnEdit_Click(object sender, EventArgs e)
        {

        }
    }

}
