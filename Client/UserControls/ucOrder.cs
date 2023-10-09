using Client.Entities;
using Client.Model;
using DevExpress.DataAccess.Native.Web;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace Client.UserControls
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        private readonly ApiClient _apiClient;

        private List<UserInfoDTO> userOrderList;

        private string OrderId;
        private string selectedRestaurantId;
        private string dateString;
        private List<Product> productList = new List<Product>();

        private int userId = 2;


        public ucOrder(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _apiClient = new ApiClient();
        }

        private void ucOrder_Load(object sender, EventArgs e)
        {


            dtOrderDate.DateTime = DateTime.Now;

            OrderCreate();
            //GetOrderByUserAll();
            //GetRestaurant();
            
        }


        // lấy ra thông tin các cửa hàng

        private void GetRestaurant()
        {
            try
            {
                var restaurants = _apiClient.GetData<Restaurant>("Restaurant/Getall").Data;

                // Gán dữ liệu cho LookUpEdit
                ludRestaurant.Properties.DataSource = restaurants;
                ludRestaurant.Properties.DisplayMember = "RestaurantName";
                ludRestaurant.Properties.ValueMember = "Id";

                // Thiết lập chế độ hiển thị
                ludRestaurant.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                //lookUpEdit.Properties.SearchMode = SearchMode.AutoComplete;
                ludRestaurant.Properties.SearchMode = SearchMode.AutoFilter;
                ludRestaurant.Properties.ImmediatePopup = true;
                ludRestaurant.Properties.ShowHeader = false;
                ludRestaurant.Properties.TextEditStyle = TextEditStyles.Standard;
                ludRestaurant.Properties.AutoSearchColumnIndex = 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        // lây ra order của ngày hiện tại khi chayj sẽ lấy ngày hiện tại
        public void OrderCreate()
        {
            DateTime date = dtOrderDate.DateTime;
            string datetime = date.ToString("yyyy/MM/dd");
            var order = _apiClient.GetData<Order>($"Restaurant/GetAllRestaurant?date={datetime}").Data;
            if(order.Count>0)
            {
                OrderId = order[0].Id;
                selectedRestaurantId = order[0].Restaurant.Id;
                GetOrderByUserAll();
                ShowProduct(datetime);


            }
            else
            {
                gridDataProduct.DataSource = null;
                gridDataProduct.RefreshDataSource();
                gridDataUser.DataSource = null;
                gridDataUser.RefreshDataSource();
            }

            GetRestaurant();

        }

        public void ShowProduct(string date)
        {
            var products = _apiClient.GetData<Product>($"Order/GetProductsByOrderDate?date={date}").Data;
            SortProducts(products);


            gridDataProduct.DataSource = products;
            //gridDataProduct.RefreshDataSource();
          


        }


        private void OrderCreateDate()
        {
            DateTime date = dtOrderDate.DateTime;
            string datetime = date.ToString("yyyy/MM/dd");
            var products = _apiClient.GetData<Product>($"Order/GetProductsByOrderDate?date={datetime}").Data;
            var order = _apiClient.GetData<Order>($"Restaurant/GetAllRestaurant?date={datetime}").Data;
            if (products != null && products.Any())
            {
                OrderId = order[0].Id;
                SortProducts(products);
                selectedRestaurantId = order[0].Restaurant.Id;
                gridDataProduct.DataSource = products;

                // hiện thị thông tin người đã dặt hàng hay chưa
                GetOrderByUserAll();
            }
            else
            {
                OrderId = "0";
                gridDataProduct.DataSource = null;
                gridDataProduct.RefreshDataSource();

            }

        }

        // lấy thông tin sản phẩm theo cửa hàng được chọn
        public void GetProduct()
        {
            var products = _apiClient.GetData<Product>($"Product/Restaurant/{selectedRestaurantId}")?.Data;

            if (products != null && products.Any())
            {
                SortProducts(products);
                gridDataProduct.DataSource = products;
                gridDataProduct.RefreshDataSource();
            }
            else
            {
                gridDataProduct.DataSource = null;

            }
            GetOrderByUserAll();

        }


        // sắp xếp product theo người dùng đã mua và chưa mua
        private void SortProducts(List<Product> products)
        {
            if (userOrderList != null)
            {
                products.Sort((p1, p2) =>
                {
                    bool p1InOrderList = userOrderList.Any(u => u.ProductId.Equals(p1.Id));
                    bool p2InOrderList = userOrderList.Any(u => u.ProductId.Equals(p2.Id));

                    return p1InOrderList.CompareTo(p2InOrderList);
                });
            }

            foreach (var product in products)
            {
                ProcessProduct(product);
            }
        }


        // hiện thị thông tin sản phẩm product sang layoutview và cập nhật lại thông tin sản phẩm
        private void ProcessProduct(Product product)
        {
            if (userOrderList != null)
            {
                var userOrder = userOrderList.FirstOrDefault(u => u.ProductId.Equals(product.Id));
                product.Quantity = userOrder?.TotalQuantity ?? 1;
                product.IsSelected = userOrder != null;
            }
            else
            {
                product.Quantity = 1;
            }

            product.Image = LoadProductImage(product.Images);

            int index = productList.FindIndex(p => p.Id == product.Id);
            if (index >= 0)
            {
                productList[index] = product;
            }
            else
            {
                productList.Insert(0, product);
            }
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



        private void GetOrderByUserAll()
        {
            DateTime date = dtOrderDate.DateTime;
            string startDate = date.ToString("yyyy/MM/dd");
            string endDate = null;
            string userName = null;
            string userId = "2";
            //selectedRestaurantId = string.IsNullOrEmpty(selectedRestaurantId) ? "" : selectedRestaurantId;
            string restaurants = null;
            string productName = null;


            try
            {
                var userOrder = _apiClient.GetData<UserInfoDTO>($"Order/UserAllOrders?startDate={startDate}&endDate={endDate}&UserName={userName}&userId={userId}&restaurants={selectedRestaurantId}&productName={productName}").Data;

                Console.WriteLine(JsonConvert.SerializeObject(userOrder));
                userOrderList = userOrder;
                //khi userOrder có 1 giá trị thì mới kiểm tra
                if (userOrder.Count == 1)
                {
                    userOrderList.RemoveAll(u => u.ProductId.Equals("0"));

                }
                // tìm kiếm kiểm tra  phần tử nào có productId =0 xóa khỏi userOrderList
                gridDataUser.DataSource = userOrder;
                GridView view = gridDataUser.MainView as GridView;
                if (view != null)
                {
                    // Ẩn các cột  không muốn hiển thị`
                    //view.Columns["OrderDetailID"].Visible = false;

                    //view.Columns["ProductId"].Visible = false;
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



        public void UserSendOrderDelete()
        {

            var orderDetail = ConvertToListOrderDetail(userOrderList, OrderId, userId);

            var resource = "OrderDetail";

            var response = _apiClient.SendDeteleRequest<OrderDetail>(resource + "/2", 2);

            if (response != null)
            {
                if (response.Code == HttpStatusCode.OK)
                {

                    //MessageBox.Show($"Thêm thành công:");
                    //GetUserProduct();
                }
                else
                {
                    //Đăng nhập thất bại
                    string errorMessage = response.Message;
                    MessageBox.Show($"Thêm thất bại: {errorMessage}");
                }
            }
            else
            {
                //Kết nối đến server thất bại hoặc lỗi khác
                MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
            }
        }

        public void UserSendOrder()
        {

            var orderDetail = ConvertToListOrderDetail(userOrderList, OrderId, userId);

            var resource = "OrderDetail/CreateList";
            UserSendOrderDelete();

            var response = _apiClient.SendListToApi<OrderDetail>(resource, orderDetail);

            if (response != null)
            {
                if (response.Code == HttpStatusCode.OK)
                {

                    MessageBox.Show($"Thêm thành công:");
                    //GetUserProduct();
                }
                else
                {
                    //Đăng nhập thất bại
                    string errorMessage = response.Message;
                    MessageBox.Show($"Thêm thất bại: {errorMessage}");
                }
            }
            else
            {
                //Kết nối đến server thất bại hoặc lỗi khác
                MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
            }
        }


        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            OrderCreate();
        }

        public void UpdateGridData()
        {

            gridDataUser.DataSource = userOrderList;
            gridDataUser.RefreshDataSource();

        }


        private void SubBtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {
            //Cart cart = new Cart()
            //{
            //    OrderId = OrderId,
            //    UserId = 2,
            //    Count = 1
            //};
            //var resource = "Cart/DeleteCart";
            //var sendDeleteOrder = _apiClient.SendDeleteRequest<Cart>(resource, cart);

            //if (sendDeleteOrder != null)
            //{
            //    if (sendDeleteOrder.Code == HttpStatusCode.OK)
            //    {

            //        MessageBox.Show($"xoa thành công:");
            //        GetOrderByUser();
            //        GetProduct();
            //        gridDataProduct.RefreshDataSource();
            //    }
            //    else
            //    {
            //        // Đăng nhập thất bại
            //        string errorMessage = sendDeleteOrder.Message;
            //        MessageBox.Show($"xoa thất bại: {errorMessage}");
            //    }
            //}
            //else
            //{
            //    // Kết nối đến server thất bại hoặc lỗi khác
            //    MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
            //}

        }


        public OrderDetail ConvertToOrderDetail(UserInfoDTO userInfo, string orderId, int userId)
        {
            return new OrderDetail
            {
                Id = userInfo.OrderDetailID ?? "0",
                OrderId = orderId,
                ProductId = userInfo.ProductId,
                UserId = userId,
                Count = userInfo.TotalQuantity,
                Price = userInfo.TotalPrice,
                RestaurantId = selectedRestaurantId
            };
        }

        public List<OrderDetail> ConvertToListOrderDetail(List<UserInfoDTO> userOrderList, string orderId, int userId)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (var user in userOrderList)
            {
                orderDetails.Add(ConvertToOrderDetail(user, orderId, userId));
            }

            return orderDetails;
        }

        private void SubBtnOrder_Click(object sender, EventArgs e)
        {

            DialogResult dg = MessageBox.Show("Bạn muốn đặt cơm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                SubBtnDelete_Click(sender, e);
                UserSendOrder();
                // đóng uc hiện tại
                _frmMain.RemoveUC();
                // mở ucOrder 
                ucListOrder ucOrder = new ucListOrder(_frmMain);
                _frmMain.AddUC(ucOrder);

            }

        }


        private void checkOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click111");
        }



        private void lblRestaurant_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click111");
        }

        private void checkOrder_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckEdit;
            var product = layoutView.GetFocusedRow() as Product;
            var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);

            if (checkbox != null && product != null)
            {
                product.IsSelected = checkbox.Checked;
                if (checkbox.Checked)
                {

                    UserInfoDTO user = new UserInfoDTO()
                    {

                        ProductId = product.Id,
                        ProductName = product.ProductName,
                        TotalQuantity = product.Quantity,
                        TotalPrice = (decimal)product.Price * product.Quantity
                    };
                    userOrderList.Add(user);
                }
                else
                {
                    userOrderList.Remove(existingUserProduct);


                }
            }

            UpdateGridData();
        }


        private void ludRestaurant_EditValueChanged(object sender, EventArgs e)
        {
            selectedRestaurantId = ludRestaurant.EditValue.ToString();
            GetProduct();
        }

        private void spdtPrice_EditValueChanged(object sender, EventArgs e)
        {
            var spinEdit = sender as SpinEdit;
            if (spinEdit != null)
            {
                // Lấy giá trị từ SpinEdit
                int quantity = (int)spinEdit.Value;

                // Lấy dòng dữ liệu hiện tại trong LayoutView
                int rowHandle = layoutView.FocusedRowHandle;
                if (rowHandle >= 0)
                {
                    var product = layoutView.GetRow(rowHandle) as Product;
                    if (product != null)
                    {
                        var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId.Equals(product.Id));
                        if (existingUserProduct != null)
                        {
                            //product.Quantity = quantity;
                            //product.Price = quantity * product.Price;
                            existingUserProduct.TotalQuantity = quantity;
                            existingUserProduct.TotalPrice = (decimal)product.Price * quantity;

                            UpdateGridData();
                        }


                    }
                }
            }
        }

    }
}


