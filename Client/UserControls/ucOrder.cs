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

namespace Client.UserControls
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        private readonly ApiClient _apiClient;

        private List<UserInfoDTO> userOrderList;

        private string  OrderId;
        private string selectedRestaurantId;
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

            dtOrderDate.DateTime = DateTime.Now;
            GetRestaurant();
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


        // lấy ra id của order vừa tạo của ngày hôm nay 
        private void OrderCreateDate()
        {
            DateTime date = dtOrderDate.DateTime;
            string dateString = date.ToString("yyyy/MM/dd");
            var order = _apiClient.GetData<Product>($"Order/GetProductsByOrderDate?date={dateString}").Data;
            if ( order != null )
            {
                OrderId = order[0].Id;
                // làm tiếp check order đãcó và chưa có

            }


        }

        // lấy thông tin sản phẩm theo cửa hàng được chọn
        public void GetProduct()
        {
            var productResponse = _apiClient.GetData<Product>($"Product/Restaurant/{selectedRestaurantId}");
            if (productResponse != null && productResponse.Data != null)
            {
                // Sắp xếp sản phẩm dựa trên sự hiện diện trong userOrderList
                productResponse.Data.Sort((p1, p2) =>
                {
                    var p1InOrderList = userOrderList.Any(u => u.ProductId.Equals(p1.Id));
                    var p2InOrderList = userOrderList.Any(u => u.ProductId.Equals(p2.Id));

                    if (p1InOrderList && !p2InOrderList)
                    {
                        return -1;
                    }
                    else if (!p1InOrderList && p2InOrderList)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                });

                foreach (var product in productResponse.Data)
                {
                    var userOrder = userOrderList.FirstOrDefault(u => u.ProductId.Equals(product.Id));
                    if (userOrder != null)
                    {
                        product.Quantity = userOrder.TotalQuantity;
                        product.IsSelected = true;
                    }

                    if (product.Images != null)
                    {
                        string absoluteImageUrl = $"http://localhost:5000{product.Images.Replace("\\", "/")}";
                        product.Image = LoadImageFromUrl(absoluteImageUrl);
                    }
                    else
                    {
                        string defaultImageUrl = @"D:\ThucTap\OrderFood\Client\Images\quan-com-tam-o-ha-noi-.jpg";
                        product.Image = LoadImageFromUrl(defaultImageUrl);
                    }

                    // Tìm vị trí thích hợp để thêm sản phẩm vào danh sách
                    int index = productList.FindIndex(p => p.Id == product.Id);
                    if (index >= 0)
                    {
                        // Sản phẩm đã tồn tại, cập nhật nó
                        productList[index] = product;
                    }
                    else
                    {
                        // Sản phẩm chưa tồn tại, thêm nó vào danh sách
                        productList.Insert(0, product); // Thêm vào đầu danh sách để hiển thị đầu tiên
                    }
                }

                gridDataProduct.DataSource = productList;
            }
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

            var orderDetail = ConvertToListOrderDetail(userOrderList, OrderId, "2");
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


        //private void layoutView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    if (e.Column.FieldName == "IsSelected" && (bool)e.Value)
        //    {
        //        Product product = layoutView.GetRow(e.RowHandle) as Product;
        //        if (product != null)
        //        {
        //            var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);
        //            if (existingUserProduct != null)
        //            {
        //                existingUserProduct.TotalQuantity = product.Quantity;
        //                existingUserProduct.TotalPrice = (decimal)product.Price * product.Quantity;
        //                MessageBox.Show("Quantity: " + product.Quantity);

        //            }
        //            else
        //            {
        //                UserInfoDTO user = new UserInfoDTO()
        //                {
        //                    UserName = "Nguyen Van A",
        //                    ProductId = product.Id,
        //                    Title = product.Title,
        //                    TotalQuantity = product.Quantity,
        //                    TotalPrice = (decimal)product.Price * product.Quantity
        //                };
        //                userOrderList.Add(user);
        //                MessageBox.Show("Thêm thành công");

        //            }
        //            UpdateGridData();
        //        }
        //    }
        //    else
        //    {
        //        Product product = layoutView.GetRow(e.RowHandle) as Product;
        //        if (product != null)
        //        {
        //            var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);
        //            userOrderList.Remove(existingUserProduct);
        //            MessageBox.Show("Xoa");


        //            UpdateGridData();
        //        }

        //    }
        //}

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


        public Cart ConvertToOrderDetail(UserInfoDTO userInfo, string orderId, string userId)
        {
            return new Cart
            {
                //Id = userInfo.Id,
                OrderId = orderId,
                ProductId = userInfo.ProductId,
                UserId = userId,
                Count = userInfo.TotalQuantity
            };
        }

        public List<Cart> ConvertToListOrderDetail(List<UserInfoDTO> userOrderList, string orderId, string userId)
        {
            List<Cart> orderDetails = new List<Cart>();

            //foreach (var user in userOrderList)
            //{
            //    orderDetails.Add(ConvertToOrderDetail(user, orderId, userId));
            //}

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
            //var checkbox = sender as CheckEdit;
            //var product = layoutView.GetFocusedRow() as Product;
            //var existingUserProduct = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);

            //if (checkbox != null && product != null)
            //{
            //    product.IsSelected = checkbox.Checked;
            //    if (checkbox.Checked)
            //    {
            //        if (existingUserProduct != null)
            //        {
            //            existingUserProduct.TotalQuantity = product.Quantity;
            //            existingUserProduct.TotalPrice = (decimal)product.Price * product.Quantity;
            //            MessageBox.Show("Quantity: " + product.Quantity);

            //        }
            //        else
            //        {
            //            UserInfoDTO user = new UserInfoDTO()
            //            {
            //                UserName = "Nguyen Van A",
            //                ProductId = product.Id,
            //                Title = product.Title,
            //                TotalQuantity = product.Quantity,
            //                TotalPrice = (decimal)product.Price * product.Quantity
            //            };
            //            userOrderList.Add(user);
            //            MessageBox.Show("Thêm thành công");

            //        }
            //    }
            //    else
            //    {
            //        userOrderList.Remove(existingUserProduct);
            //        MessageBox.Show("Xoa nos di");

            //    }
            //    UpdateGridData();
            //}
        }

        private void ludRestaurant_EditValueChanged(object sender, EventArgs e)
        {
            selectedRestaurantId = ludRestaurant.EditValue.ToString();
            GetRestaurant();
        }
    }
}


