using Client.Entities;
using Client.Model;
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
            getProduct();
        }



        public void getProduct()
        {
            var categoriesResponse = _apiClient.GetData<Product>("Product/Restaurant/3");

            if (categoriesResponse != null && categoriesResponse.Data != null)
            {
                foreach (var product in categoriesResponse.Data)
                {
                    ucProductItem ucProductItem = new ucProductItem();


                    if (!string.IsNullOrEmpty(product.ImageUrl))
                    {
                        string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";

                        try
                        {
                            Image productImage = LoadImageFromUrl(absoluteImageUrl);
                            ucProductItem.SetProduct(product.Id, product.Title, product.Price, productImage);
                        }
                        catch (Exception ex)
                        {

                            Console.Error.WriteLine($"Lỗi khi tải hình ảnh: {ex.Message}");
                        }
                    }
                    else
                    {
                        // Sử dụng hình ảnh mặc định từ đường dẫn cố định.
                        string defaultImagePath = @".\Images\quan-com-tam-o-ha-noi-.jpg";
                        Image defaultImage = Image.FromFile(defaultImagePath);
                        ucProductItem.SetProduct(product.Id, product.Title, product.Price, defaultImage);
                    }
                    var matchedProductInfo = userOrderList.FirstOrDefault(p => p.ProductId == product.Id);
                    ucProductItem.UpdateProductInfo(matchedProductInfo);
                    flowLayout.Controls.Add(ucProductItem);
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

                    //GridView view = gridData.MainView as GridView;

                    //if (view != null)
                    //{
                    //    // Ẩn các cột bạn không muốn hiển thị
                    //    view.Columns["OrderId"].Visible = false;
                    //    view.Columns["ProductId"].Visible = false;
                    //}
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

        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUser();
        }

       

      
    }
}
