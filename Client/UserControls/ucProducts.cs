using Client.DTO;
using Client.Entities;
using DataAccess.Model;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucProducts : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;
        private readonly ApiClient _apiClient;
        private List<Restaurant> _restaurants;
        public ucProducts()
        {
            InitializeComponent();

            _apiClient = new ApiClient();
            _restaurants = new List<DataAccess.Model.Restaurant>();

            GetData();
            GetRestaurant();
        }

        private void closeucProduct_Click(object sender, EventArgs e)
        {
            frmMain.Instance.AddUserControl(new ucListProduct(), "ucListProduct");
        }

        // lấy thông tin từ DTO/CategoryDTO.cs lấy dữ liệu từ database

        public void GetData()
        {
            try
            {
                var restaurants = _apiClient.GetData<CategoryDTO>($"Category/GetAllCategory").Data;
                //if (restaurants != null)
                //{
                //    foreach (var itemData in restaurants)
                //    {
                //        ComboBoxItem comboBoxItem = new ComboBoxItem(itemData.RestaurantId, itemData.RestaurantName);
                //        cboRestaurant.Properties.Items.Add(comboBoxItem);
                //    }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }



        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }


        private void cboRestaurant_EditValueChanged(object sender, EventArgs e)
        {

        }
        private bool isInitialized = false;

        private void cboRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cboRestaurant.SelectedItem != null)
            //{
            //    ComboBoxItem selectedItem = (ComboBoxItem)cboRestaurant.SelectedItem;
            //    string selectedValue = selectedItem.Value;
            //    string selectedText = selectedItem.Text;
            //    MessageBox.Show(selectedValue + " " + selectedText);

            //}
            //    if (isInitialized)
            //{
            //    int selectedIndex = cboRestaurant.SelectedIndex;
            //    string restaurandId = "";



            //    // Kiểm tra xem selectedIndex có hợp lệ hay không
            //    if (selectedIndex >= 0)
            //    {
            //        string restaurantName = cboRestaurant.SelectedItem.ToString();

            //        // lấy dữ liệu của categoryName theo restaurantName từ database
            //        var categories = _apiClient.GetData<CategoryDTO>($"Category/GetAllCategory?restaurantName={restaurantName}").Data;
            //        if (categories != null && categories.Count > 0)
            //        {

            //            restaurandId = categories[0].RestaurantId;
            //            //lấy dữ liệu đổ ra product theo id nhà hàng
            //            var products = _apiClient.GetData<Product>($"Product/Restaurant/{restaurandId}").Data;
            //            // đổ dữ liệu vào gridview
            //            products.ForEach(p => p.ImageProduct = LoadProductImage(p.Images));
            //            gridData.DataSource = products;
            //            gridData.RefreshDataSource();
            //            // add dữ liệu vào cboCategoryName

            //            foreach (var category in categories)
            //            {
            //                if (!cboCategoryName.Properties.Items.Contains(category.CategoryName) && category.CategoryName != "N/A")
            //                {
            //                    cboCategoryName.Properties.Items.Add(category.CategoryName);
            //                }
            //            }

            //        }
            //        else
            //        {
            //            cboCategoryName.Text = "";
            //            cboCategoryName.Properties.Items.Clear();
            //            gridData.DataSource = null;
            //        }
            //    }
            //}
            //else
            //{
            //    isInitialized = true;
            //}
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

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            // cập nhật giao diện ucListRestaurants

            //var existingUcRestaurant = frmMain.Instance?.GetUserControl("ucListCategories") as ucListRestaurants;
            //if (existingUcRestaurant != null)
            //{
            //    //existingUcRestaurant.LoadData();

            //}

            if (frmMain.Instance != null)
            {
                SessionData.SetUC("ucProduct");
                frmMain.Instance.AddUserControl(new ucListRestaurants(true), "ucListRestaurants");
            }
        }
        // lấy dữ liệu từ DataSession

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
            }

        }

        private void btnRestaurant_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
