using API.DTO;
using Client.Entities;
using Client.Model;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;

        private List<UserInfoDTO> userOrderList = new List<UserInfoDTO>();

        private string OrderId;

        private List<Product> productList = new List<Product>();
        private int userId = Properties.Settings.Default.ID;
        //private string restaurantName;

        public ucOrder()
        {
            InitializeComponent();

            _apiClient = new ApiClient();
        }

        private void ucOrder_Load(object sender, EventArgs e)
        {
            dtOrderDate.DateTime = DateTime.Now;

        }


        // lây ra order của ngày hiện tại khi chay sẽ lấy ngày hiện tại
        public void OrderCreate()
        {

            var order = _apiClient.GetData<Order>($"Restaurant/GetAllRestaurant?date={OrderDate}").Data;
            // thực hiện đổ dữ liệu ra combobox theo ngày hiên tại
            if (order.Count != 0)
            {
                // Trích xuất danh sách nhà hàng từ order
                var restaurants = order.Select(o => o.Restaurant).Distinct().ToList();
                OrderId = order[0].Id;
                // Chuyển đổi danh sách nhà hàng thành danh sách RestaurantVM 
                List<RestaurantVM> restaurantVMs = restaurants.Select(r => new RestaurantVM(r)).ToList();
                //SessionData.SetListRestaurants(restaurantVMs);
                cboRestaurants.DataSource = restaurantVMs;
                cboRestaurants.DisplayMember = "RestaurantName";
                cboRestaurants.ValueMember = "Id";
                // hiện sản phẩm theo nhà hàng
                ShowProduct(OrderDate, restaurantName);
                gridDataProduct.RefreshDataSource();

            }
            else
            {
                var restaurants = _apiClient.GetData<Restaurant>("Restaurant/Getall").Data;
                cboRestaurants.DataSource = restaurants;
                cboRestaurants.DisplayMember = "RestaurantName";
                cboRestaurants.ValueMember = "Id";
            }
        }
        private void cboRestaurants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboRestaurants.SelectedValue != null)
            {
                ShowProduct(OrderDate, restaurantName);
            }

        }
        // hiện thị sản phẩm theo ngày hiện tại và nhà hàng được chọn
        public void ShowProduct(string date, string restaurantName)
        {
            List<Product> products = new List<Product>();
            products = _apiClient.GetData<Product>($"Order/GetProductsByOrderDate?date={date}&restautanName={restaurantName}").Data;
            // kiểm tra chưa có  thì hiện tất cả của product đó lên theo restaurantId
            if (products.Count ==0)
            {
                 products = _apiClient.GetData<Product>($"Product/Restaurant/{restaurantId}")?.Data;
            }
           if(products== null) return;
            SortProducts(products);
            gridDataProduct.DataSource = products;
            gridDataProduct.RefreshDataSource();
            GetOrderByUserAll();
        }


        // sắp xếp product theo người dùng đã mua và chưa mua
        private void SortProducts(List<Product> products)
        {
            // Tìm những sản phẩm product có trong userOrderList
            try
            {
                List<Product> purchasedProducts = new List<Product>();

                foreach (var product in products)
                {
                    if (userOrderList == null) return;
                    var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId.Equals(product.Id));
                    if (existingUserProduct != null)
                    {
                        product.Quantity = existingUserProduct.TotalQuantity;
                        product.IsSelected = true;
                        product.Image = LoadProductImage(product.Images);
                        purchasedProducts.Add(product);
                    }
                    else
                    {
                        product.Image = LoadProductImage(product.Images);
                        product.Quantity = 1;
                        product.IsSelected = false;
                    }
                }
                products.RemoveAll(product => purchasedProducts.Contains(product));
                products.InsertRange(0, purchasedProducts);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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


            try
            {
                var userOrder = _apiClient
                    .GetData<UserInfoDTO>(
                        $"Order/UserAllOrders?startDate={startDate}&userId={userId}")
                    .Data;

                Console.WriteLine(JsonConvert.SerializeObject(userOrder));
                userOrderList = userOrder;
                if (userId != null)
                {

                    //khi userOrder có 1 giá trị thì mới kiểm tra
                    if (userOrder.Count == 1)
                    {
                        userOrderList.RemoveAll(u => u.ProductId.Equals("0"));
                    }

                    UpdateGridData();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void closeUcOrder_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucListOrder(), "ucListOrder");
            }
        }
        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            gridDataProduct.DataSource = null;
            gridDataProduct.RefreshDataSource();
            gridDataUser.DataSource = null;
            gridDataUser.RefreshDataSource();
            cboRestaurants.DataSource = null;
            cboRestaurants.Refresh();
            OrderCreate();
        }

        public void UpdateGridData()
        {
            var filteredList = userOrderList.Where(u => u.TotalQuantity != 0).ToList();
            gridDataUser.DataSource = filteredList;
            gridDataUser.RefreshDataSource();
        }


        public OrderDetail ConvertToOrderDetail(UserInfoDTO userInfo, string orderId, int userId)
        {
            return new OrderDetail
            {
                Id = userInfo.OrderDetailID ?? "0",
                OrderId = orderId,
                ProductId = userInfo.ProductId,
                UserId = userId,
                Price = userInfo.TotalPrice,
                Count = userInfo.TotalQuantity,
                RestaurantId = restaurantId,

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
            DialogResult dg = MessageBox.Show("Bạn muốn đặt cơm không", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                var orderDetail = ConvertToListOrderDetail(userOrderList, OrderId, userId);

                if (orderDetail.Count != 0)
                {
                    //var resource = "OrderDetail/CreateList";

                    //UserSendOrderDelete();

                    var response = _apiClient.SendListToApi<OrderDetail>("OrderDetail/CREATE/LIST", orderDetail);

                    if (response != null)
                    {
                        if (response.Code == HttpStatusCode.OK)
                        {
                            notifyIcon.ShowBalloonTip(1000, "Thông báo", "Đặt cơm thành công", ToolTipIcon.None);
                            var existingUcListOrder = frmMain.Instance?.GetUserControl("ucListOrder") as ucListOrder;

                            if (existingUcListOrder != null)
                            {

                                existingUcListOrder.GetData();
                                frmMain.Instance.AddUserControl(new ucProduct(), "ucListOrder");
                            }
                        }
                        else
                        {
                            string errorMessage = response.Message;
                            MessageBox.Show($"Thêm thất bại: {errorMessage}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm nào");
                    return;
                }


            }
        }
        private void checkOrder_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckEdit;

            // lấy ra dữ liệu của dòng đang được chọn
            var product = layoutView.GetFocusedRow() as Product;

            if (userOrderList == null) return;
            var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);

            if (checkbox != null && product != null)
            {
                product.IsSelected = checkbox.Checked;
                if (checkbox.Checked)
                {
                    // Nếu sản phẩm chưa tồn tại trong danh sách, thì thêm vào
                    if (existingUserProduct == null)
                    {
                        UserInfoDTO user = new UserInfoDTO()
                        {
                            ProductId = product.Id,
                            ProductName = product.ProductName,
                            ProductPrice = product.Price,
                            TotalQuantity = product.Quantity,
                            TotalPrice = (decimal)product.Price * product.Quantity,
                            RestaurantName = restaurantName,
                        };
                        userOrderList.Add(user);
                    }
                    else
                    {
                        // Nếu sản phẩm đã tồn tại, thì cập nhật số lượng và tổng giá
                        existingUserProduct.TotalQuantity = product.Quantity;
                        existingUserProduct.TotalPrice = (decimal)product.Price * product.Quantity;
                    }
                }
                else
                {
                    // Nếu người dùng hủy chọn sản phẩm
                    if (existingUserProduct != null)
                    {
                        existingUserProduct.TotalQuantity = 0;
                        existingUserProduct.TotalPrice = 0;
                    }
                }
            }

            UpdateGridData();
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

                            existingUserProduct.TotalQuantity = quantity;
                            existingUserProduct.TotalPrice = (decimal)product.Price * quantity;

                            UpdateGridData();
                        }
                    }
                }
            }
        }

        private void gridView2_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void gridDataProduct_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {

        }


        // lấy dữ liêu người dùng chọn trên combobox
        public string restaurantId
        {
            get
            {
                if (cboRestaurants.SelectedValue != null)
                {
                    return cboRestaurants.SelectedValue.ToString();
                }
                return null;
            }
        }

        // lấy displayname combobox
        public string restaurantName
        {
            get
            {
                if (cboRestaurants.SelectedValue != null)
                {
                    return cboRestaurants.Text;
                }
                return null;
            }
        }


        // lấy dữ liệu người dùng chon ngày
        public string OrderDate
        {
            get
            {
                DateTime date = dtOrderDate.DateTime;
                string datetime = date.ToString("yyyy/MM/dd");
                return datetime;
            }
        }



    }
}