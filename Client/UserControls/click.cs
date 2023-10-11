﻿using Client.Entities;
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
                BankAccount = int.Parse(txtBankAccount.Text),
                Notes = meNotes.Text,
                Id = lbId.Text



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
            txtRestaurantName.Text = "";
            txtPhoneNumber.Text = "";
            txtBankAccount.Text = "";
            txtBankName.Text = "";
            txtBankNumber.Text = "";
            meNotes.Text = "";
            peImage.Image = null;
            lbId.Text = "";
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

        private void SubBtnAddRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                Restaurant restaurant = GetRestaurant();
                ApiResponse<Restaurant> createResponse = _apiClient.SendPostRequest<Restaurant>("Restaurant/Create", restaurant);
                if (createResponse != null && createResponse.Code == HttpStatusCode.OK)
                {
                    string restaurantId = createResponse.Data.Id;

                    if (createResponse.Code == HttpStatusCode.OK)
                    {
                        if (peImage.Image != null)
                        {
                            // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                            using (MemoryStream ms = new MemoryStream())
                            {
                                peImage.Image.Save(ms, peImage.Image.RawFormat);
                                ApiResponse<Restaurant> uploadImageResponse = _apiClient.SendImageUploadRequest<Restaurant>("Restaurant/UpLoadImage", restaurantId, ms.ToArray());

                                if (uploadImageResponse != null && uploadImageResponse.Code == HttpStatusCode.OK)
                                {

                                    // thực hiện cập nhật  dữ liệu theo id
                                    _restaurants.Where(r => r.Id.Equals(restaurantId)).ToList().ForEach(r =>
                                    {
                                        r.RestaurantName = restaurant.RestaurantName;
                                        r.PhoneNumber = restaurant.PhoneNumber;
                                        r.OpenTime = restaurant.OpenTime;
                                        r.CloseTime = restaurant.CloseTime;
                                        r.BankName = restaurant.BankName;
                                        r.BankNumber = restaurant.BankNumber;
                                        r.BankAccount = restaurant.BankAccount;
                                        r.Notes = restaurant.Notes;
                                        r.Image = LoadProductImage(uploadImageResponse.Data.ImageUrl);
                                    });
                                    Clear(); ;
                                    ShowGrid();
                                    MessageBox.Show("Cập nhật nhà hàng thành công");
                                }
                                else
                                {

                                    MessageBox.Show("Lỗi khi thêm hình");
                                }
                            }
                        }
                    }

                    if (createResponse.Code == HttpStatusCode.Created)
                    {
                        if (peImage.Image != null)
                        {
                            // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                            using (MemoryStream ms = new MemoryStream())
                            {
                                peImage.Image.Save(ms, peImage.Image.RawFormat);
                                ApiResponse<Restaurant> uploadImageResponse = _apiClient.SendImageUploadRequest<Restaurant>("Restaurant/UpLoadImage", restaurantId, ms.ToArray());

                                if (uploadImageResponse != null && uploadImageResponse.Code == HttpStatusCode.OK)
                                {
                                    Clear();
                                    restaurant.Image = LoadProductImage(uploadImageResponse.Data.ImageUrl);
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

        private void SubBtnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà hàng {txtRestaurantName.Text} không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ApiResponse<Restaurant> deleteResponse = _apiClient.SendDeteleRequest<Restaurant>($"Restaurant/DeleteRestaurant/{lbId.Text}", 2);
                if (deleteResponse != null && deleteResponse.Code == HttpStatusCode.OK)
                {
                    // lấy id của từ lbId và kiểm tra trong list restaurant có id đó không
                    // nếu có thì thực hiện xóa nó đi

                    var restaurant = _restaurants.FirstOrDefault(r => r.Id.Equals(lbId.Text));
                    if (restaurant != null)
                    {
                        _restaurants.Remove(restaurant);
                        Clear();
                        ShowGrid();

                        MessageBox.Show("Xóa nhà hàng thành công");
                    }

                    //_restaurants.Remove(restaurant);


                }
                else
                {
                    MessageBox.Show("Xóa nhà hàng thất bại");
                }
            }
        }

        private void SubBtnSearch_Click(object sender, EventArgs e)
        {

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
                        peImage.Image = System.Drawing.Image.FromFile(selectedImagePath);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
