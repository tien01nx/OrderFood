using Client.Entities;
using Client.Model;
using System.IO;
using System.Net;
using Image = System.Drawing.Image;

namespace Client
{
    public partial class frmProductRestaurant : Form
    {
        private readonly ApiClient _apiClient;
        private int _orderId;
        public frmProductRestaurant()
        {

            InitializeComponent();
            _apiClient = new ApiClient();
        }



        private void frmProductRestaurant_Load(object sender, EventArgs e)
        {
            //getProduct();
            GetUserProduct();

            Time.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        public void GetUserProduct()
        {
            var userOrder = _apiClient.GetData<UserInfoDTO>("Order/UserOrders");
            var firstUserOrder = userOrder?.Data?.FirstOrDefault();
            _orderId = firstUserOrder.OrderId;


            grilUserOrder.DataSource = userOrder?.Data;
        }

        //public void getProduct()
        //{
        //    var categoriesResponse = _apiClient.GetData<Product>("Product/Restaurant/3");

        //    if (categoriesResponse != null && categoriesResponse.Data != null)
        //    {
        //        foreach (var product in categoriesResponse.Data)
        //        {
        //            formdemo productControl = new formdemo();
        //            productControl.ItemClicked += (s, args) =>
        //            {
        //                // Xử lý sự kiện khi UserControl được ấn
        //                // Hiển thị thông báo với tiêu đề của mục đó
        //                // sau sửa thành UserId
        //                UserSendOrder(_orderId, product.Id, 1, 5);



        //            };
        //            // Kiểm tra nếu imageUrl không phải là null hoặc empty.
        //            if (!string.IsNullOrEmpty(product.ImageUrl))
        //            {
        //                string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";

        //                try
        //                {
        //                    Image productImage = LoadImageFromUrl(absoluteImageUrl);
        //                    productControl.SetProduct(product.Title, product.Description, productImage);
        //                }
        //                catch (Exception ex)
        //                {
        //                    // Xử lý ngoại lệ khi tải hình ảnh.
        //                    // Ví dụ: hiển thị thông báo lỗi, ghi log, ...
        //                    Console.Error.WriteLine($"Lỗi khi tải hình ảnh: {ex.Message}");
        //                }
        //            }
        //            else
        //            {
        //                // Sử dụng hình ảnh mặc định từ đường dẫn cố định.
        //                string defaultImagePath = @".\Images\Screenshot 2023-08-09 235148.png";
        //                Image defaultImage = Image.FromFile(defaultImagePath);
        //                productControl.SetProduct(product.Title, product.Description, defaultImage);
        //            }

        //            flowLayoutPanel1.Controls.Add(productControl);
        //        }
        //    }
        //}

        public void UserSendOrder(int orderId, int productId, int count, int userId)
        {

            var orderDetail = new OrderDetail { OrderId = orderId, ProductId = productId, Count = count, UserId = userId };
            var resource = "Cart/Create";

            var response = _apiClient.SendPostRequest<Cart>(resource, orderDetail);

            if (response != null)
            {
                if (response.Code == System.Net.HttpStatusCode.OK)
                {

                    MessageBox.Show($"Thêm thành công:");
                    GetUserProduct();
                }
                else
                {
                    // Đăng nhập thất bại
                    string errorMessage = response.Message;
                    MessageBox.Show($"Thêm thất bại: {errorMessage}");
                }
            }
            else
            {
                // Kết nối đến server thất bại hoặc lỗi khác
                MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
            }
        }

        private Image LoadImageFromUrl(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(url);
                using (MemoryStream memStream = new MemoryStream(data))
                {
                    return Image.FromStream(memStream);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
