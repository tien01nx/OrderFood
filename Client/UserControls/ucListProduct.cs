using Client.Entities;
using Client.Model;

namespace Client.UserControls
{
    public partial class ucListProduct : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly ApiClient _apiClient;
        public ucListProduct()
        {
            InitializeComponent();
            _apiClient = new ApiClient();

        }
        public void LoadData()
        {
            string restaurantName = btnRestaurantname.Text;
            string categoryName = btnCategoryName.Text;
            string productName = txtProductName.Text;
            // lấy dữ liêu từ database
            var product = _apiClient.GetData<ProductVM>($"Product/GetListProduct?restaurantName={restaurantName}&categoryName={categoryName}&productName={productName}").Data;
            // hiển thị dữ liệu lên gridcontrol
            gridListProduct.DataSource = product;
        }




        private void btnClose_Click(object sender, EventArgs e)
        {

            frmMain.Instance.AddUserControl(new ucListOrder(), "ucListOrder");

        }

        private void btnUcProduct_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucProduct(), "ucProduct");
            }
        }

        private void btnRestaurantname_Click(object sender, EventArgs e)
        {
            // thực hiện chuyển sang ucListRestaurant
            if (frmMain.Instance != null)
            {
                SessionData.SetUC("ucListProduct");
                frmMain.Instance.AddUserControl(new ucListRestaurants(false), "ucListRestaurant");
            }
        }

        private void btnCategoryName_Click(object sender, EventArgs e)
        {
            // thực hiện chuyển sang ucListRestaurant
            if (frmMain.Instance != null)
            {
                SessionData.SetUC("ucListProduct");
                frmMain.Instance.AddUserControl(new ucListCategories(), "ucListCategories");
            }
        }

        private void txtProductName_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

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
                btnRestaurantname.Text = string.Join(", ", restaurantNames);
            }

        }
        // hiện CategoryName
        public void GetcategoryName()
        {
            if (SessionData.Category != null)
            {

                btnCategoryName.Text = SessionData.Category.CategoryName;
                SessionData.Category = null;
            }
        }

        private void ucListProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRestaurantname_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCategoryName_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
