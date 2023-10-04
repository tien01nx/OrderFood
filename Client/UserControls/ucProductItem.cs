using Client.Entities;
using Client.Model;
using DevExpress.PivotGrid.OLAP;
using DevExpress.Utils.Svg;
using DevExpress.Xpf.Editors;

namespace Client
{
    public partial class ucProductItem : DevExpress.XtraEditors.XtraUserControl
    {
        private int ProductId;

        private readonly ApiClient _apiClient;
        private int OrderId;

        public ucProductItem()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            OrderCreateDate();  
        }


        public void SetProduct(int id, string name, double price, Image image)
        {
            this.ProductId = id;
            lblProductName.Text = name;
            lblPrice.Text = price.ToString();
            pcProductImg.Image = image;
        }

        public void UpdateProductInfo(UserInfoDTO userInfo)
        {
            if (userInfo != null && this.ProductId == userInfo.ProductId)
            {
                this.spinQuantity.Value = userInfo.TotalQuantity;
                this.chkIsChoose.Checked = true;
            }
            else
            {
                this.spinQuantity.Value = 1;
                this.chkIsChoose.Checked = false;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bạn đã chọn sản phẩm: {ProductId} ,{OrderId} ");
            UserSendOrder(OrderId, ProductId, spinQuantity.Value, 2);
        }

        private void OrderCreateDate()
        {
            var order = _apiClient.GetSingleData<Order>($"Order/GetOrderByCreatedDate").Data;

            OrderId = order.Id;

        }



        public void UserSendOrder(int orderId, int productId, decimal count, int userId)
        {

            var orderDetail = new OrderDetail { OrderId = orderId, ProductId = productId, Count = count, UserId = userId };
            var resource = "Cart/Create";

            var response = _apiClient.SendPostRequest<Cart>(resource, orderDetail);

            if (response != null)
            {
                if (response.Code == System.Net.HttpStatusCode.OK)
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
    }
}
