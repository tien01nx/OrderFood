using Client.Entities;
using Client.Model;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        private readonly ApiClient _apiClient;

        private List<UserInfoDTO> userOrderList;

        private int OrderId;

        public ucOrder(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _apiClient = new ApiClient();
            dtOrderDate.EditValue = DateTime.Now;

        }

        private void ucOrder_Load(object sender, EventArgs e)
        {
            GetOrderByUser();
            GetProduct();
            OrderCreateDate();
        }

        // lấy ra id của order vừa tạo của ngày hôm nay 
        private void OrderCreateDate()
        {
            var order = _apiClient.GetSingleData<Order>($"Order/GetOrderByCreatedDate").Data;
            OrderId = order.Id;
            lblRestaurant.Text = order.RestaurantName;

        }


        //public void GetProduct()
        //{
        //    var productResponse = _apiClient.GetData<Product>("Product/Restaurant/3");

        //    foreach (var product in productResponse.Data)
        //    {
        //        if (product.ImageUrl != null)
        //        {
        //            string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";
        //            using (WebClient webClient = new WebClient())
        //            {
        //                byte[] data = webClient.DownloadData(absoluteImageUrl);
        //                using (MemoryStream memStream = new MemoryStream(data))
        //                {
        //                    System.Drawing.Image img = System.Drawing.Image.FromStream(memStream);
        //                    product.Image = img;
        //                }
        //            }
        //        }
        //    }



        //    gridDataProduct.DataSource = productResponse.Data;
        //}
        public void GetProduct()
        {
            var productResponse = _apiClient.GetData<Product>("Product/Restaurant/3");

            foreach (var product in productResponse.Data)
            {
                if (product.ImageUrl != null)
                {
                    string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";

                    product.Image = LoadImageFromUrl(absoluteImageUrl);
                }
            }



            gridDataProduct.DataSource = productResponse.Data;
            var layoutView = gridDataProduct.MainView as LayoutView; // Đảm bảo rằng MainView là một instance của LayoutView.
            if (layoutView != null)
            {
                layoutView.Columns["Id"].Visible = false;
                layoutView.Columns["ImageUrl"].Visible = false;
                layoutView.Columns["Description"].Visible = false;
                layoutView.Columns["RestaurantName"].Visible = false;
                layoutView.Columns["CreateBy"].Visible = false;
                layoutView.Columns["UpdateBy"].Visible = false;
                layoutView.Columns["CreateDate"].Visible = false;
                layoutView.Columns["UpdateDate"].Visible = false;
            }

        }

        private Image LoadImageFromUrl(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(url);
                using (MemoryStream memStream = new MemoryStream(data))
                {
                    System.Drawing.Image img = System.Drawing.Image.FromStream(memStream);
                    return img;
                }
            }
        }




        //public void getProduct()
        //{
        //    var categoriesResponse = _apiClient.GetData<Product>("Product/Restaurant/3");

        //    if (categoriesResponse != null && categoriesResponse.Data != null)
        //    {
        //        foreach (var product in categoriesResponse.Data)
        //        {
        //            ucProductItem ucProductItem = new ucProductItem();
        //            ucProductItem.ItemClicked += (s, args) =>
        //            {

        //                bool isUpdateMode = ucProductItem.GetIsUpdateMode();
        //                int id = ucProductItem.GetId();

        //                decimal spinQuantityValue = ucProductItem.SpinQuantityValue;
        //                if (isUpdateMode)
        //                {
        //                    UserSendOrder(id, OrderId, product.Id, spinQuantityValue, 3);
        //                }
        //                else
        //                {
        //                    UserSendOrder(0, OrderId, product.Id, spinQuantityValue, 2);
        //                }

        //                //UserSendOrder(OrderId, product.Id, spinQuantityValue, 2);
        //                GetOrderByUser();
        //                //MessageBox.Show($"Bạn đã chọn sản phẩm: {product.Id} ,{OrderId} ,{spinQuantityValue}");


        //            };


        //            if (!string.IsNullOrEmpty(product.ImageUrl))
        //            {
        //                string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";

        //                try
        //                {
        //                    Image productImage = LoadImageFromUrl(absoluteImageUrl);
        //                    ucProductItem.SetProduct(product.Id, product.Title, product.Price, productImage);
        //                }
        //                catch (Exception ex)
        //                {

        //                    Console.Error.WriteLine($"Lỗi khi tải hình ảnh: {ex.Message}");
        //                }
        //            }
        //            else
        //            {
        //                // Sử dụng hình ảnh mặc định từ đường dẫn cố định.
        //                string defaultImagePath = @".\Images\quan-com-tam-o-ha-noi-.jpg";
        //                Image defaultImage = Image.FromFile(defaultImagePath);
        //                ucProductItem.SetProduct(product.Id, product.Title, product.Price, defaultImage);
        //            }
        //            var matchedProductInfo = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);
        //            ucProductItem.UpdateProductInfo(matchedProductInfo);
        //            flowLayout.Controls.Add(ucProductItem);
        //        }
        //    }
        //}
        private void GetOrderByUser()
        {
            DateTime date = dtOrderDate.DateTime;
            string userId = "2";
            string dateString = date.ToString("yyyy/MM/dd");

            try
            {
                var userOrderResponse = _apiClient.GetData<UserInfoDTO>($"Order/UserOrders?userId={userId}&date={dateString}");

                if (userOrderResponse != null && userOrderResponse.Data != null)
                {
                    userOrderList = userOrderResponse.Data;

                    Console.WriteLine(JsonConvert.SerializeObject(userOrderList));
                    gridDataUser.DataSource = userOrderList;

                    GridView view = gridDataUser.MainView as GridView;

                    if (view != null)
                    {
                     

                        view.Columns["ProductId"].Visible = false;
                    }
                }
                else
                {
                    Console.WriteLine("No data or data could not be fetched.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void closeUcOrder_Click(object sender, EventArgs e)
        {
            _frmMain.RemoveUC();
        }

        private void gridDataUser_Click(object sender, EventArgs e)
        {

        }




        public void UserSendOrder(int id, int orderId, int productId, decimal count, int userId)
        {

            var orderDetail = new OrderDetail { Id = id, OrderId = orderId, ProductId = productId, Count = count, UserId = userId };
            var resource = "Cart/Create";

            var response = _apiClient.SendPostRequest<Cart>(resource, orderDetail);

            if (response != null)
            {
                if (response.Code == HttpStatusCode.OK)
                {

                    MessageBox.Show($"Thêm thành công:");
                    //GetUserProduct();
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

        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUser();
        }


        private void SubBtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gridDataProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
