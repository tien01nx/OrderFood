using API.Entities;
using Client.Entities;
using Client.Model;
using DataAccess.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class ucProduct : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly ApiClient _apiClient;
        private bool _isUpdateImage = false;
        public ucProduct()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void SubBtnClose_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                SessionData.SetUC("ucListProduct");
                frmMain.Instance.AddUserControl(new ucListProduct(), "ucListProduct");
            }
        }

        private void SubbtnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                var product = productVM();
                ApiResponse<ProductVM> createResponse = _apiClient.SendPostRequest<ProductVM>("Product/Create", product);
                if (createResponse != null)
                {
                    string productId = createResponse.Data.Id;

                    if (createResponse.Code == HttpStatusCode.OK)
                    {

                        if (!_isUpdateImage)
                        {
                            // xử lý thêm người dùng thay ảnh thì mới gửi lên  không thì thôi

                            if (svgProductImage.Image != null)
                            {
                                // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    //peImage.Image.Save(ms, peImage.Image.RawFormat);
                                    svgProductImage.Image.Save(ms, ImageFormat.Jpeg);
                                    ApiResponse<ProductVM> uploadImageResponse = _apiClient.SendImageUploadRequest<ProductVM>("Product/UpLoadImage", productId, ms.ToArray());

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
                        if (svgProductImage.Image != null)
                        {
                            // Chuyển đổi hình ảnh trong PictureBox thành một đối tượng MemoryStream
                            using (MemoryStream ms = new MemoryStream())
                            {
                                svgProductImage.Image.Save(ms, svgProductImage.Image.RawFormat);
                                ApiResponse<RestaurantVM> uploadImageResponse = _apiClient.SendImageUploadRequest<RestaurantVM>("Product/UpLoadImage", productId, ms.ToArray());

                                if (uploadImageResponse != null && uploadImageResponse.Code == HttpStatusCode.OK)
                                {
                                    Clear();

                                    MessageBox.Show("Tạo nhà hàng thành công");

                                    // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                                    var existingUcCategory = frmMain.Instance?.GetUserControl("ucListProduct") as ucListProduct;
                                    if (existingUcCategory != null)
                                    {
                                        existingUcCategory.LoadData();
                                        frmMain.Instance.AddUserControl(new ucListProduct(), "ucListProduct");

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

        private void SubBtnClear_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            // setUc là ucListProduct và thực hiện chuyển đến trang ucListRestaurant
            SessionData.SetUC("ucProduct");
            frmMain.Instance.AddUserControl(new ucListRestaurants(false), "ucListRestaurant");
        }

        public void GetRestaurant()
        {
            // Kiểm tra xem có danh sách nhà hàng nào trong SessionData không
            if (SessionData.AllRestaurants.Count > 0)
            {
                // Tạo một danh sách tên nhà hàng để hiển thị
                List<string> restaurantNames = new List<string>();

                // Lấy tên của tất cả các nhà hàng từ SessionData
                foreach (var restaurant in SessionData.AllRestaurants)
                {
                    restaurantNames.Add(restaurant.RestaurantName);
                }

                // Hiển thị danh sách tên nhà hàng lên buttonEdit
                btnRestaurant.Text = string.Join(", ", restaurantNames);
                RestaurantId.Text = SessionData.AllRestaurants[0].Id.ToString();
            }

        }
        public void setCategory()
        {
            if (SessionData.Category != null)
            {
                btnCategoryName.Text = SessionData.Category.CategoryName;
                CategoryId.Text = SessionData.Category.Id.ToString();
            }
        }

        private void btnCategoryName_Click(object sender, EventArgs e)
        {
            // setUc là ucProduct và thực hiện chuyển đến trang ucListCategory
            SessionData.SetUC("ucProduct");
            frmMain.Instance.AddUserControl(new ucListCategories(), "ucListCategories");
        }

        private ProductVM productVM()
        {
            // lấy dữ liệu trên form
            ProductVM productVM = new ProductVM()
            {
                ProductName = txtProductName.Text,
                Price = spPrice.Value,
                Description = mdDescription.Text,
                RestaurantId = RestaurantId.Text,
                CategoryId = CategoryId.Text,
                Id = id.Text,
                Images = null,
            };
            if (productVM.Id.Equals(""))
            {
                productVM.GenerateRandomId();
            }

            return productVM;
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

        private void svgProductImage_MouseDown(object sender, MouseEventArgs e)
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
                        svgProductImage.Image = System.Drawing.Image.FromFile(selectedImagePath);
                    }
                }
            }
        }


        // clear dữ liệu trên form
        private void Clear()
        {
            btnCategoryName.Text = "";
            btnRestaurant.Text = "";
            txtProductName.Text = "";
            mdDescription.Text = "";
            RestaurantId.Text = "";
            CategoryId.Text = "";
            svgProductImage.Image = null;
            id.Text = "";
            spPrice.Value = 20000;

        }
        private void svgProductImage_EditValueChanged(object sender, EventArgs e)
        {
            _isUpdateImage = true;
        }
    }
}
