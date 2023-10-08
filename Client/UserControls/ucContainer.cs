using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
using System.IO;
using System.Net;

namespace Client
{
    public partial class ucContainer : XtraUserControl
    {

        private readonly ApiClient _apiClient;

        public ucContainer()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }

        private void ucContaine_Load(object sender, EventArgs e)
        {
            dateEdit.EditValue = DateTime.Now;
            //GetOrderByUser();
            //getProduct();
        }

        private void GetOrderByUser()
        {

            try
            {
                var userOrder = _apiClient.GetData<UserInfoDTO>("Order/UserOrders").Data;
                if (userOrder != null)
                {
                    gridData.DataSource = userOrder;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
        //            //productControl.ItemClicked += (s, args) =>
        //            //{
        //            //    // Xử lý sự kiện khi UserControl được ấn
        //            //    // Hiển thị thông báo với tiêu đề của mục đó
        //            //    // sau sửa thành UserId
        //            //    //UserSendOrder(_orderId, product.Id, 1, 5);



        //            //};
        //            if (!string.IsNullOrEmpty(product.ImageUrl))
        //            {
        //                string absoluteImageUrl = $"http://localhost:5000{product.ImageUrl.Replace("\\", "/")}";

        //                try
        //                {
        //                    Image productImage = LoadImageFromUrl(absoluteImageUrl);
        //                    ucProductItem.SetProduct(product.Title, product.Price, productImage);
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
        //                ucProductItem.SetProduct(product.Title, product.Price, defaultImage);
        //            }

        //            flowLayout.Controls.Add(ucProductItem);
        //        }
        //    }
        //}

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

        private void gridData_Click(object sender, EventArgs e)
        {

        }
    }
}
