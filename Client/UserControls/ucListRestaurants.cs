using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class ucListRestaurants : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly frmMain _frmMain;
        private readonly ApiClient _apiClient;

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
            var restaurants = _apiClient.GetData<Restaurant>("Restaurant/GetAll").Data;
            girdRestaurant.DataSource = restaurants;
           foreach(var item in restaurants)
            {
               cboRestaurant.Properties.Items.Add(item.RestaurantName);
               cboFavoriteLevel.Properties.Items.Add(item.FavoriteLevel);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }
    }
}
