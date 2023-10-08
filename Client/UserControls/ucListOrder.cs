using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Model;
using Newtonsoft.Json;

namespace Client.UserControls
{
    public partial class ucListOrder : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;
        private readonly frmMain _mainForm;
        private string selectedRestaurantId;


        public ucListOrder(frmMain mainForm)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            _mainForm = mainForm;
            dtOrderDate.DateTime = DateTime.Now;
            GetOrderByUserAll();
            GetRestaurant();
        }

        private void ucListOrder_Load(object sender, EventArgs e)
        {


        }

        private void GetOrderByUserAll()
        {
            DateTime date = dtOrderDate.DateTime;
            string startDate = date.ToString("yyyy/MM/dd");
            string endDate = null;
            string userName = string.IsNullOrEmpty(txtUserName.Text) ? "" : txtUserName.Text;
            string userId = null;
            selectedRestaurantId = string.IsNullOrEmpty(selectedRestaurantId) ? "" : selectedRestaurantId;
            string productName = string.IsNullOrEmpty(txtTile.Text) ? "" : txtTile.Text;


            try
            {
                var userOrder = _apiClient.GetData<UserInfoDTO>($"Order/UserAllOrders?startDate={startDate}&endDate={endDate}&UserName={userName}&userId={userId}&restaurants={selectedRestaurantId}&productName={productName}").Data;
                Console.WriteLine(JsonConvert.SerializeObject(userOrder));
                gridData.DataSource = userOrder;
                GridView view = gridData.MainView as GridView;
                if (view != null)
                {
                    // Ẩn các cột  không muốn hiển thị`
                    view.Columns["OrderDetailID"].Visible = false;

                    view.Columns["ProductId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


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

        private void SubBtnOrder_Click(object sender, EventArgs e)
        {
            ucOrder uc = new ucOrder(_mainForm);
            _mainForm.AddUC(uc);
        }

        private void closeUcListOrder_Click(object sender, EventArgs e)
        {
            _mainForm.RemoveUC();
        }


        private void SubBtnSearch_Click(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }

        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUserAll();

        }

        private void txtTile_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }

        private void lookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            selectedRestaurantId = ludRestaurant.EditValue.ToString();
            GetOrderByUserAll();
        }
    }
}
