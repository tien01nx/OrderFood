using Client.Entities;
using Client.Model;
using DevExpress.Utils.DirectXPaint;
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
    public partial class click : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly frmMain _frmMain;

        private readonly ApiClient _apiClient;

        // tạo list để lưu dữ liệu từ db về
        private List<Restaurant> _restaurants = new List<Restaurant>();

        public click(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _apiClient = new ApiClient();
            GetData();
            ShowGrid();

        }

        // lấy dữ liệu gán cho list
        public void GetData()
        {
            var restaurants = _apiClient.GetData<Restaurant>($"Restaurant/GetRestaurantByKeyword").Data;
            // từ imageurl lấy hình ảnh
            foreach (var restaurant in restaurants)
            {
                restaurant.Image = LoadProductImage(restaurant.ImageUrl);
            }
            _restaurants = restaurants;
        }

        // đổ dữ liệu ra gridview từ list
        public void ShowGrid()
        {

            gridControl1.DataSource = _restaurants;
            // load lại gridview
            gridControl1.RefreshDataSource();
        }

        // lấy thông tin nhà hàng tù form người dùng nhập
        public Restaurant GetRestaurant()
        {
            //DateTime selectedTime = timeStart.Time;
            //DateTime closetime = timeEnd.Time;

            //TimeSpan timeOpen = new TimeSpan(selectedTime.Hour, selectedTime.Minute, 0);
            //TimeSpan timeClose = new TimeSpan(closetime.Hour, closetime.Minute, 0);

            Restaurant restaurant = new Restaurant()
            {
                //RestaurantName = txtRestaurantName.Text,
                //PhoneNumber = txtPhoneNumber.Text,
                //OpenTime = timeOpen,
                //CloseTime = timeClose,
                //BankName = txtBankName.Text,
                //BankNumber = txtBankNumber.Text,
                //BankAccount = int.Parse(txtBankAccount.Text),
                //Notes = meNotes.Text,
                //Id = lbId.Text



            };
            if (restaurant.Id == null)
            {
                restaurant.GenerateRandomId();

            }

            return restaurant;
        }
        // set giá trị về null
        public void Clear()
        {
            //txtRestaurantName.Text = "";
            //txtPhoneNumber.Text = "";
            //txtBankAccount.Text = "";
            //txtBankName.Text = "";
            //txtBankNumber.Text = "";
            //meNotes.Text = "";
            //peImage.Image = null;
            //lbId.Text = "";
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

        private void click_Load(object sender, EventArgs e)
        {
            BtnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
          MessageBox.Show("Xóa thành công");
        }
    }
}
