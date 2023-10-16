using API.Entities;
using Client.Entities;
using DataAccess.Model;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class click : DevExpress.XtraEditors.XtraUserControl
    {


        private readonly ApiClient _apiClient;

        // tạo list để lưu dữ liệu từ db về
        private List<Restaurant> _restaurants = new List<Restaurant>();

        private bool _isUpdate = false;
        private bool _isUpdateImage = false;

        public click()
        {
            InitializeComponent();

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
                //restaurant.Image = LoadProductImage(restaurant.ImageUrl);
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
                ImageUrl = "",
                BankName = txtBankName.Text,
                BankNumber = txtBankNumber.Text,
                BankAccount = int.Parse(txtBankAccount.Text),
                Notes = meNotes.Text,
                Id = lbId.Text


            };
            // Kiểm tra biến _isUpdate và xác định xem cần tạo ID mới hay không
            if (!_isUpdate || restaurant.Id == null)
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

        // check dữ liệu phải nhập đầy đủ
        //public bool CheckData()
        //{
        //    if (string.IsNullOrEmpty(txtRestaurantName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtBankAccount.Text) || string.IsNullOrEmpty(txtBankName.Text) || string.IsNullOrEmpty(txtBankNumber.Text) || string.IsNullOrEmpty(meNotes.Text))
        //    {
        //        return false;
        //    }
        //    return true;
        //}


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
            // ép kiểu từ layout view lấy dữ liệu để xóa
            var selectedRow = gridView1.GetFocusedRow() as Restaurant;
            if (selectedRow != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà hàng {selectedRow.RestaurantName} không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ApiResponse<Restaurant> deleteResponse = _apiClient.SendDeteleRequest<Restaurant>($"Restaurant/DeleteRestaurant/{selectedRow.Id}", 2);
                    if (deleteResponse != null && deleteResponse.Code == HttpStatusCode.OK)
                    {
                        // lấy id của từ lbId và kiểm tra trong list restaurant có id đó không
                        // nếu có thì thực hiện xóa nó đi

                        var restaurant = _restaurants.FirstOrDefault(r => r.Id.Equals(selectedRow.Id));
                        if (restaurant != null)
                        {
                            _restaurants.Remove(restaurant);
                            Clear();
                            ShowGrid();

                            MessageBox.Show("Xóa nhà hàng thành công");
                        }

                        //_restaurants.Remove(restaurant);  
                    }
                }
            }
        }

        private void SubBtnAddRestaurant_Click(object sender, EventArgs e)
        {
            try
            {

                //if (!CheckData())
                //{
                //    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                //    return;
                //}
                Restaurant restaurant = GetRestaurant();
                ApiResponse<Restaurant> createResponse = _apiClient.SendPostRequest<Restaurant>("Restaurant/Create", restaurant);
                if (createResponse != null)
                {
                    string restaurantId = createResponse.Data.Id;

                    if (createResponse.Code == HttpStatusCode.OK)
                    {

                        if (_isUpdateImage)
                        {
                            // xử lý thêm người dùng thay ảnh thì mới gửi lên  không thì thôi

                            if (peImage.Image != null)
                            {
                                // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    //peImage.Image.Save(ms, peImage.Image.RawFormat);
                                    peImage.Image.Save(ms, ImageFormat.Jpeg);
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
                                            //r.Image = LoadProductImage(uploadImageResponse.Data.ImageUrl);
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
                        else
                        {
                            Clear(); ;
                            ShowGrid();
                            MessageBox.Show("Cập nhật nhà hàng thành công");
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
                                    //restaurant.Image = LoadProductImage(uploadImageResponse.Data.ImageUrl);
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

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                var selectedRow = gridView1.GetRow(e.RowHandle) as Restaurant;

                if (selectedRow != null)
                {
                    // Hiển thị dữ liệu từ dòng đã chọn vào các TextBox
                    txtRestaurantName.Text = selectedRow.RestaurantName;
                    txtPhoneNumber.Text = selectedRow.PhoneNumber;
                    //peImage.Image = selectedRow.Image;
                    txtBankAccount.Text = selectedRow.BankAccount.ToString();
                    txtBankName.Text = selectedRow.BankName;
                    txtBankNumber.Text = selectedRow.BankNumber;
                    meNotes.Text = selectedRow.Notes;
                    lbId.Text = selectedRow.Id;
                    timeStart.Time = DateTime.Today.Add(selectedRow.OpenTime);
                    timeEnd.Time = DateTime.Today.Add(selectedRow.CloseTime);
                    _isUpdate = true;
                    // Hiển thị hình ảnh từ URL
                    if (!string.IsNullOrEmpty(selectedRow.ImageUrl)) // Kiểm tra xem có URL hình ảnh không
                    {
                        peImage.Image = LoadProductImage(selectedRow.ImageUrl);
                    }
                    else
                    {
                        // Nếu không có URL hình ảnh, xử lý mặc định (hiển thị hình ảnh mặc định hoặc trống)
                        peImage.Image = null;
                    }

                    _isUpdate = true;
                }
            }
        }

        private void txtBankAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn người dùng nhập các ký tự khác số
            }
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {
            // người dùng đx thay ảnh  
            _isUpdateImage = true;
        }
    }
}
