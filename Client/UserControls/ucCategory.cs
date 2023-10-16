using API.Entities;
using Client.Entities;
using Client.Model;
using Client.UserControls;

using System.Net;

namespace Client
{
    public partial class ucCategory : DevExpress.XtraEditors.XtraUserControl
    {
        private bool _isUpdate = false;
        private ApiClient _apiClient;

        public ucCategory()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }
        private void SubbtnAdd_Click(object sender, EventArgs e)
        {
            var category = GetCategory();

            ApiResponse<Model.Category> createResponse = _apiClient.SendPostRequest<Category>("Category/Create", category);
            if (createResponse != null)
            {
                if (createResponse.Code == HttpStatusCode.Created)
                {
                    MessageBox.Show("thêm thành công");

                }
                if (createResponse.Code == HttpStatusCode.OK)
                {
                    MessageBox.Show("Lưu thành công");

                }
                if (createResponse.Code == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Không thành công ");
                    return;

                }
                SubBtnClear_Click(sender, e);
                if (frmMain.Instance != null)
                {
                    // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                    var existingUcProduct = frmMain.Instance?.GetUserControl("ucListCategories") as ucListCategories;
                    if (existingUcProduct != null)
                    {
                        existingUcProduct.getData();
                        frmMain.Instance.AddUserControl(new ucListCategories(), "ucListCategories");
                    }
                    else
                    {
                        frmMain.Instance.AddUserControl(new ucListCategories(), "ucListCategories");
                    }

                }
            }
        }
        private void SubBtnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            btnRestaurantName.Text = "";
            mdDescriptions.Text = "";
        }

        // lấy dữ liệu từ form để gửi lên server
        private Category GetCategory()
        {
            var category = new Category
            {
                CategoryName = txtCategoryName.Text.Trim(),
                RestaurantId = RestaurantId.Text.Trim(),
                Descriptions = mdDescriptions.Text.Trim(),
                Id = Id.Text.Trim()
            };

            if (!_isUpdate || category.Id == null)
            {
                category.GenerateRandomId();
            }

            return category;
        }



        private void btnRestaurantName_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                SessionData.SetUC("ucCategory");
                frmMain.Instance.AddUserControl(new ucListRestaurants(true), "ucListRestaurants");
            }
        }

        // cập nhật restaurantName
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
                btnRestaurantName.Text = string.Join(", ", restaurantNames);
                RestaurantId.Text = SessionData.AllRestaurants.FirstOrDefault().Id;
            }

        }

        // nhận giữ liệu gửi sang
        public void setCategory(Category category)
        {
            if (category != null)
            {
                _isUpdate = true;
                Id.Text = category.Id;
                txtCategoryName.Text = category.CategoryName;
                btnRestaurantName.Text = "";
                RestaurantId.Text = category.RestaurantId;
                mdDescriptions.Text = category.Descriptions;
            }
        }

        private void SubBtnClose_Click(object sender, EventArgs e)
        {

            SubBtnClear_Click(sender, e);
            frmMain.Instance.AddUserControl(new ucListRestaurants(true), "ucListRestaurants");
        }
    }
}
