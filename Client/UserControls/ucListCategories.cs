using Client.Entities;
using DataAccess.Model;

namespace Client.UserControls
{
    public partial class ucListCategories : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly ApiClient _apiClient;
        public ucListCategories()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
        }


        // lấy thông tin nhà hàng từ ucRestaurant

        private void btnRestaurant_Click(object sender, EventArgs e)
        {

        }


        // hiện danh sách các categories ra gridCategories

        private void getData()
        {
            try
            {
                var categories = _apiClient.GetData<Category>($"Category/GetAllCategory").Data;
                if (categories != null)
                {
                    gridCategories.DataSource = categories;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ucListCategories_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
