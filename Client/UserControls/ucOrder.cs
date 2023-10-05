using Client.Entities;
using Client.Model;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
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
        private List<Product> productList = new List<Product>();


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

        public void GetProduct()
        {
            var productResponse = _apiClient.GetData<Product>("Product/Restaurant/3");

            foreach (var product in productResponse.Data)
            {

                var userOrder = userOrderList.FirstOrDefault(u => u.ProductId == product.Id);
                if (userOrder != null)
                {
                    product.Quantity = userOrder.TotalQuantity;
                    product.IsSelected = true;
                }

                if (product.ImageUrl != null)
                {
                    string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";

                    product.Image = LoadImageFromUrl(absoluteImageUrl);
                }
                else
                {
                    string defaultImageUrl = @"D:\ThucTap\OrderFood\Client\Images\quan-com-tam-o-ha-noi-.jpg";
                    product.Image = LoadImageFromUrl(defaultImageUrl);
                }
                productList.Add(product);
            }

            gridDataProduct.DataSource = productResponse.Data;
            var layoutView = gridDataProduct.MainView as LayoutView;
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

                // không cho phep sua

                layoutView.Columns["Price"].OptionsColumn.ReadOnly = true;
                layoutView.Columns["Title"].OptionsColumn.ReadOnly = true;
            }


        }

        private Image LoadImageFromUrl(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(url);
                using (MemoryStream memStream = new MemoryStream(data))
                {
                    Image img = Image.FromStream(memStream);
                    return img;
                }
            }
        }

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


        public void UserSendOrder()
        {

            var orderDetail = ConvertToListOrderDetail(userOrderList, OrderId, 2);
            var resource = "Cart/CreateList";

            var response = _apiClient.SendListToApi<Cart>(resource, orderDetail);

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



        private void layoutView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "IsSelected" && (bool)e.Value)
            {
                Product product = layoutView.GetRow(e.RowHandle) as Product;
                if (product != null)
                {
                    var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);
                    if (existingUserProduct != null)
                    {
                        existingUserProduct.TotalQuantity = product.Quantity;
                        existingUserProduct.TotalPrice = (decimal)product.Price * product.Quantity;
                        MessageBox.Show("Quantity: " + product.Quantity);

                    }
                    else
                    {
                        UserInfoDTO user = new UserInfoDTO()
                        {
                            UserName = "Nguyen Van A",
                            ProductId = product.Id,
                            Title = product.Title,
                            TotalQuantity = product.Quantity,
                            TotalPrice = (decimal)product.Price * product.Quantity
                        };
                        userOrderList.Add(user);
                        MessageBox.Show("Thêm thành công");

                    }
                    UpdateGridData();
                }
            }
        }

        public void UpdateGridData()
        {

            gridDataUser.DataSource = userOrderList;
            gridDataUser.RefreshDataSource();
            //ConvertToListOrderDetail(userOrderList, OrderId, 2);

        }

        private void SubBtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {

        }


        public Cart ConvertToOrderDetail(UserInfoDTO userInfo, int orderId, int userId)
        {
            return new Cart
            {
                Id = userInfo.Id,
                OrderId = orderId,
                ProductId = userInfo.ProductId,
                UserId = userId,
                Count = userInfo.TotalQuantity
            };
        }

        public List<Cart> ConvertToListOrderDetail(List<UserInfoDTO> userOrderList, int orderId, int userId)
        {
            List<Cart> orderDetails = new List<Cart>();

            foreach (var user in userOrderList)
            {
                orderDetails.Add(ConvertToOrderDetail(user, orderId, userId));
            }

            return orderDetails;
        }

        private void SubBtnOrder_Click(object sender, EventArgs e)
        {
            UserSendOrder();
        }
    }
}
