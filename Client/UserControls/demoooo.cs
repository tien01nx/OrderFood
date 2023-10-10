using Client.Entities;
using Client.Model;
using DevExpress.Xpf.Bars;
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
    public partial class demoooo : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        private readonly ApiClient _apiClient;

        // tạo list để lưu dữ liệu từ db về
        private List<Restaurant> _restaurants = new List<Restaurant>();

        public demoooo(frmMain frmMain)
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
            var restaurants = _apiClient.GetData<Restaurant>($"Restaurant/GetRestaurantByKeyword?restaurant=&favoriteLevel=&time=").Data;
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

            girdRestaurant.DataSource = _restaurants;
            // load lại gridview
            girdRestaurant.RefreshDataSource();
        }

        // lấy thông tin nhà hàng tù form người dùng nhập
        public Restaurant GetRestaurant()
        {
            DateTime selectedTime = timeStart.Time;
            DateTime closetime = timeEnd.Time;

            TimeSpan timeOpen = new TimeSpan(selectedTime.Hour, selectedTime.Minute, 0);
            TimeSpan timeClose = new TimeSpan(closetime.Hour, closetime.Minute, 0);

            Restaurant restaurant = new Restaurant()
            {
                RestaurantName = txtRestaurantName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                OpenTime = timeOpen,
                CloseTime = timeClose,
                BankName = txtBankName.Text,
                BankNumber = txtBankNumber.Text,
                BankAccount = Convert.ToInt32(txtBankAccount.Text),
                Notes = meNotes.Text,

            };
            restaurant.GenerateRandomId();

            return restaurant;
        }


        // Thêm nhà hàng
        private void SubBtnAddRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurant = GetRestaurant();
                ApiResponse<Restaurant> createResponse = _apiClient.SendPostRequest<Restaurant>("Restaurant/Create", restaurant);
                if (createResponse != null && createResponse.Code == HttpStatusCode.OK)
                {
                    string restaurantId = createResponse.Data.Id;
                    if (peImage.Image != null)
                    {
                        // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                        using (MemoryStream ms = new MemoryStream())
                        {
                            peImage.Image.Save(ms, peImage.Image.RawFormat);
                            ApiResponse<string> uploadImageResponse = _apiClient.SendImageUploadRequest("Restaurant/UpLoadImage", restaurantId, ms.ToArray());

                            if (uploadImageResponse != null && uploadImageResponse.Code == HttpStatusCode.OK)
                            {
                                Clear();
                                restaurant.Image = LoadProductImage(createResponse.Data.ImageUrl);
                                _restaurants.Add(restaurant);
                                ShowGrid();
                                MessageBox.Show("Tạo nhà hàng thành công");
                            }
                            else
                            {

                                MessageBox.Show("Lỗi khi thêm hình");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void peImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả các tệp (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Kiểm tra xem có hình ảnh được chọn không
                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        // Đặt hình ảnh cho PictureEdit
                        peImage.Image = Image.FromFile(selectedImagePath);
                    }
                }
            }
        }

        private void txtBankAccount_TextChanged(object sender, EventArgs e)
        {

            txtBankAccount.Text = txtBankAccount.Text.Replace(",", "");


        }

        private void txtBankAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập các ký tự khác số
            }
        }
        // set giá trị về null
        public void Clear()
        {
            txtRestaurantName.Text = "";
            txtPhoneNumber.Text = "";
            txtBankAccount.Text = "";
            txtBankName.Text = "";
            txtBankNumber.Text = "";
            meNotes.Text = "";
            peImage.Image = null;
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
