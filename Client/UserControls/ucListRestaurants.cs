using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class ucListRestaurants : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly frmMain _frmMain;
        private readonly ApiClient _apiClient;

        private string _selectedRestaurant = null;
        private string _selectedFavoriteLevel = null;
        private bool _isOpenTime;

        public ucListRestaurants(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _apiClient = new ApiClient();
            btnXoa.Click += btnXoa_Click;
        }

        private void ucListRestaurants_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công");
        }

        public void LoadData()
        {
            // Load data from database
            // Bind data to gridview
            // lấy dữ liệu của Restaurant từ database
            DateTime now = DateTime.Now;

            int hour = now.Hour;
            int minute = now.Minute;

            string currentTime = hour + ":" + minute;
            if (_isOpenTime != true)
            {

                currentTime = "";
            }
            var restaurants = _apiClient.GetData<Restaurant>($"Restaurant/GetRestaurantByKeyword?restaurant={_selectedRestaurant}&favoriteLevel={_selectedFavoriteLevel}&time={currentTime}").Data;
            foreach (var item in restaurants)
            {
                item.Image = LoadProductImage(item.ImageUrl);
                cboRestaurant.Properties.Items.Add(item.RestaurantName);
                // Kiểm tra nếu cboFavoriteLevel chưa có mục này thì mới thêm
                if (!cboFavoriteLevel.Properties.Items.Contains(item.FavoriteLevel))
                {
                    cboFavoriteLevel.Properties.Items.Add(item.FavoriteLevel);
                }
            }
            girdRestaurant.DataSource = restaurants;
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }

        private void cboRestaurant_EditValueChanged(object sender, EventArgs e)
        {
            // ép kiểu sender về kiểu ComboBoxEdit
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            _selectedRestaurant = comboBox.EditValue.ToString();
            LoadData();
            //MessageBox.Show(_selectedRestaurant,_selectedFavoriteLevel);
        }

        private void cboFavoriteLevel_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            _selectedFavoriteLevel = comboBox.EditValue.ToString();
            LoadData();


        }

        private void ckOpenTime_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkEdit = sender as CheckEdit;
            if (checkEdit.Checked)
            {
                _isOpenTime = true;
                LoadData();

            }
            else
            {
                _isOpenTime = false;
            }
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
    }
}
