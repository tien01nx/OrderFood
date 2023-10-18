using API.Entities;
using Client.Entities;
using Client.Model;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucRestaurant : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly ApiClient _apiClient;



        private bool _isUpdate = false;
        private bool _isUpdateImage = false;
        public ucRestaurant()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void SubBtnClear_Click(object sender, EventArgs e)
        {

        }

        private void SubbtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //if (!CheckData())
                //{
                //    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                //    return;
                //}
                RestaurantVM restaurant = GetRestaurant();
                ApiResponse<RestaurantVM> createResponse = _apiClient.SendPostRequest<RestaurantVM>("Restaurant/Create", restaurant);
                if (createResponse != null)
                {
                    string restaurantId = createResponse.Data.Id;

                    if (createResponse.Code == HttpStatusCode.OK)
                    {

                        if (!_isUpdateImage)
                        {
                            // xử lý thêm người dùng thay ảnh thì mới gửi lên  không thì thôi

                            if (peImage.Image != null)
                            {
                                // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    //peImage.Image.Save(ms, peImage.Image.RawFormat);
                                    peImage.Image.Save(ms, ImageFormat.Jpeg);
                                    ApiResponse<RestaurantVM> uploadImageResponse = _apiClient.SendImageUploadRequest<RestaurantVM>("Restaurant/UpLoadImage", restaurantId, ms.ToArray());

                                    if (uploadImageResponse != null && uploadImageResponse.Code == HttpStatusCode.OK)
                                    {
                                        Clear();
                                        MessageBox.Show("Cập nhật nhà hàng thành công");
                                        // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                                        var existingUcCategory = frmMain.Instance?.GetUserControl("ucListRestaurants") as ucListRestaurants;
                                        if (existingUcCategory != null)
                                        {
                                            existingUcCategory.LoadData();
                                            frmMain.Instance.AddUserControl(new ucListRestaurants(false), "ucListRestaurants");

                                        }
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
                            Clear(); ;
                            //ShowGrid();
                            MessageBox.Show("Cập nhật nhà hàng thành công");
                            // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                            var existingUcCategory = frmMain.Instance?.GetUserControl("ucListRestaurants") as ucListRestaurants;
                            if (existingUcCategory != null)
                            {
                                existingUcCategory.LoadData();
                                frmMain.Instance.AddUserControl(new ucListRestaurants(false), "ucListRestaurants");

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
                                ApiResponse<RestaurantVM> uploadImageResponse = _apiClient.SendImageUploadRequest<RestaurantVM>("Restaurant/UpLoadImage", restaurantId, ms.ToArray());

                                if (uploadImageResponse != null && uploadImageResponse.Code == HttpStatusCode.OK)
                                {
                                    Clear();

                                    MessageBox.Show("Tạo nhà hàng thành công");

                                    // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                                    var existingUcCategory = frmMain.Instance?.GetUserControl("ucListRestaurants") as ucListRestaurants;
                                    if (existingUcCategory != null)
                                    {
                                        existingUcCategory.LoadData();
                                        frmMain.Instance.AddUserControl(new ucListRestaurants(false), "ucListRestaurants");

                                    }

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

        private void SubBtnClose_Click(object sender, EventArgs e)
        {
            var existingUcCategory = frmMain.Instance?.GetUserControl("ucListRestaurants") as ucListRestaurants;
            if (existingUcCategory != null)
            {
                existingUcCategory.LoadData();
                frmMain.Instance.AddUserControl(new ucListRestaurants(false), "ucListRestaurants");

            }
        }



        // lấy thông tin nhà hàng tù form người dùng nhập
        public RestaurantVM GetRestaurant()
        {
            DateTime selectedTime = timeStart.Time;
            DateTime closetime = timeEnd.Time;

            TimeSpan timeOpen = new TimeSpan(selectedTime.Hour, selectedTime.Minute, 0);
            TimeSpan timeClose = new TimeSpan(closetime.Hour, closetime.Minute, 0);

            RestaurantVM restaurant = new RestaurantVM()
            {
                RestaurantName = txtRestaurantName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                OpenTime = timeOpen,
                CloseTime = timeClose,
                ImageUrl = null,
                BankName = txtBankName.Text,
                BankNumber = txtBankNumber.Text,
                BankAccount = int.Parse(txtBankAccount.Text),
                Notes = meNotes.Text,
                Id = Id.Text


            };
            // Kiểm tra biến _isUpdate và xác định xem cần tạo ID mới hay không
            if (restaurant.Id == null)
            {
                restaurant.GenerateRandomId();
            }

            return restaurant;
        }

        public void Clear()
        {
            txtRestaurantName.Text = "";
            txtPhoneNumber.Text = "";
            txtBankAccount.Text = "";
            txtBankName.Text = "";
            txtBankNumber.Text = "";
            meNotes.Text = "";
            peImage.Image = null;
            Id.Text = null;
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

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {
            _isUpdateImage = true;
        }

        public void setRestaurant(RestaurantVM restaurantVM)
        {
            // cập nhật lên giao diện
            Id.Text = restaurantVM.Id;
            txtRestaurantName.Text = restaurantVM.RestaurantName;
            txtPhoneNumber.Text = restaurantVM.PhoneNumber;
            txtBankName.Text = restaurantVM.BankName;
            txtBankNumber.Text = restaurantVM.BankNumber;
            txtBankAccount.Text = restaurantVM.BankAccount.ToString();
            meNotes.Text = restaurantVM.Notes;
            timeStart.Time = DateTime.Today.Add(restaurantVM.OpenTime);
            timeEnd.Time = DateTime.Today.Add(restaurantVM.CloseTime);
            peImage.Image = LoadProductImage(restaurantVM.ImageUrl);

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
    }
}
