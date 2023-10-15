
using Client.Entities;
using Client.Model;

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
                var categories = _apiClient.GetData<Category>(
            $"Category/GetCategory")
            .Data;
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



        // lấy dữ liệu trong sessionData và tìm ra tên nhà hàng
        private string GetRestaurantName(string restaurantId)
        {
            var restaurntName = SessionData.GetAllRestaurants.FirstOrDefault(r => r.Id == restaurantId)?.RestaurantName;
            return restaurntName;
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "RestaurantName" && e.IsGetData)
            {
                string restaurantId = gridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "RestaurantId").ToString();
                e.Value = GetRestaurantName(restaurantId);
            };
        }
    }

}
