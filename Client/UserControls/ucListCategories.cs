
using API.DTO;
using API.Entities;
using Client.Entities;
using Client.Model;
using System.Net;

namespace Client.UserControls
{
    public partial class ucListCategories : DevExpress.XtraEditors.XtraUserControl
    {


        private readonly ApiClient _apiClient;
        private string selectedRestaurantId;
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

        public void getData()
        {
            try
            {
                string categoryName = txtCategoryName.Text.Trim();
                string restaurantName = btnRestaurantname.Text.Trim();
                var categories = _apiClient.GetData<CategoryDto>($"Category/GetCategory?categoryName={categoryName}&restaurantId={selectedRestaurantId}")
            .Data;
                if (categories != null)
                {
                    gridCategories.DataSource = categories;
                    gridCategories.RefreshDataSource();
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
            //if (e.Column.FieldName == "RestaurantName" && e.IsGetData)
            //{
            //    string restaurantId = gridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "RestaurantId").ToString();
            //    e.Value = GetRestaurantName(restaurantId);
            //};
        }

        private void btnRestaurantname_Click(object sender, EventArgs e)
        {
            // cập nhật giao diện ucListRestaurants

            var existingUcProduct = frmMain.Instance?.GetUserControl("ucListRestaurants");
            if (existingUcProduct != null)
            {
                existingUcProduct.Refresh();
            }

            if (frmMain.Instance != null)
            {
                SessionData.SetUC("ucListCategories");

                frmMain.Instance.AddUserControl(new ucListRestaurants(true), "ucListRestaurants");
            }
        }

        public void GetRestaurant()
        {
            //// Kiểm tra xem có danh sách nhà hàng nào trong SessionData không
            //if (SessionData.AllRestaurants.Count > 0)
            //{
            //    // Tạo một danh sách tên nhà hàng để hiển thị
            //    List<string> restaurantNames = new List<string>();

            //    // Lấy tên của tất cả các nhà hàng từ SessionData
            //    foreach (var restaurant in SessionData.AllRestaurants)
            //    {
            //        restaurantNames.Add(restaurant.RestaurantName);
            //    }

            //    // Hiển thị danh sách tên nhà hàng lên buttonEdit
            //    btnRestaurantname.Text = string.Join(", ", restaurantNames);
            //    selectedRestaurantId = SessionData.AllRestaurants.FirstOrDefault().Id;
            //}

        }

        private void txtCategoryName_EditValueChanged(object sender, EventArgs e)
        {

            getData();

        }

        private void btnRestaurantname_EditValueChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void SubBtnClear_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            btnRestaurantname.Text = "";
            getData();
            gridCategories.RefreshDataSource();
        }

        private void SubBtnAdd_Click(object sender, EventArgs e)
        {
            frmMain.Instance.AddUserControl(new ucCategory(), "ucCategory");
        }

        private void SubBtnSelect_Click(object sender, EventArgs e)
        {

            //var selectedRows = gridView1.GetSelectedRows();
            //List<Category> selectedData = new List<Category>();
            //foreach (var rowHandle in selectedRows)
            //{
            //    var selectedRow = gridView1.GetRow(rowHandle) as Category;

            //    selectedData.Add(selectedRow);
            //}

            if (gridView1.SelectedRowsCount > 0)
            {
                var firstSelectedRowHandle = gridView1.GetSelectedRows()[0];
                var firstSelectedRow = gridView1.GetRow(firstSelectedRowHandle) as CategoryDto;

                if (firstSelectedRow != null)
                {
                    //var existingUcProduct = frmMain.Instance?.GetUserControl("ucCategory") as ucCategory;
                    //if (existingUcProduct != null)
                    //{
                    //    existingUcProduct.setCategory(firstSelectedRow);
                    //    frmMain.Instance.AddUserControl(new ucCategory(), "ucCategory");
                    //}
                    //else
                    //{
                    //    // UserControl chưa tồn tại, tạo và thêm vào frmMain
                    //    ucCategory newUcCategory = new ucCategory();
                    //    newUcCategory.setCategory(firstSelectedRow);
                    //    frmMain.Instance.AddUserControl(newUcCategory, "ucCategory");
                    //}
                    SessionData.Category = firstSelectedRow;
                    MessageBox.Show("Đã chọn");
                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    var selectedRow = gridView1.GetRow(e.RowHandle) as Category;
            //    //object cellValue = gridView1.GetRowCellValue(e.RowHandle, "RestaurantName");
            //    //string restaurantName = cellValue != null ? cellValue.ToString() : string.Empty;

            //    if (selectedRow != null)
            //    {


            //        Category category = new Category()
            //        {
            //            Id = selectedRow.Id,
            //            CategoryName = selectedRow.CategoryName,
            //            Descriptions = selectedRow.Descriptions,
            //            RestaurantId = selectedRow.RestaurantId,

            //        };
            //        // kiểm tra ucCategory có tồn tại trong frmMain không  nếu tồn tại thì cập nhật giao diện
            //        // nếu không tồn tại thì chuyển sang ucCategory và cập nhật giao diện
            //        var existingUcProduct = frmMain.Instance?.GetUserControl("ucCategory") as ucCategory;
            //        if (existingUcProduct != null)
            //        {
            //            existingUcProduct.setCategory(category);
            //            frmMain.Instance.AddUserControl(new ucCategory(), "ucCategory");
            //        }
            //        else
            //        {
            //            // UserControl chưa tồn tại, tạo và thêm vào frmMain
            //            ucCategory newUcCategory = new ucCategory();
            //            newUcCategory.setCategory(category);
            //            frmMain.Instance.AddUserControl(newUcCategory, "ucCategory");
            //        }
            //        //SessionData.Category = category;
            //    }
            //}
        }

        private void SubBtnEdit_Click(object sender, EventArgs e)
        {
            if (SessionData.Category != null)
            {
                {
                    var existingUcProduct = frmMain.Instance?.GetUserControl("ucCategory") as ucCategory;
                    if (existingUcProduct != null)
                    {
                        existingUcProduct.setCategory(SessionData.Category);
                        frmMain.Instance.AddUserControl(new ucCategory(), "ucCategory");
                    }
                    else
                    {
                        // UserControl chưa tồn tại, tạo và thêm vào frmMain
                        ucCategory newUcCategory = new ucCategory();
                        newUcCategory.setCategory(SessionData.Category);
                        frmMain.Instance.AddUserControl(newUcCategory, "ucCategory");
                    }
                }
            }
        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                var firstSelectedRowHandle = gridView1.GetSelectedRows()[0];
                var firstSelectedRow = gridView1.GetRow(firstSelectedRowHandle) as CategoryDto;
                // Hiện thông báo xem người dùng có xác nhận xóa không
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (firstSelectedRow != null)
                    {
                        ApiResponse<Category> deleteResponse = _apiClient.SendDeteleRequest<Category>($"Category/{firstSelectedRow.Id}", 2);
                        if (deleteResponse != null && deleteResponse.Code == HttpStatusCode.OK)
                        {
                            MessageBox.Show("Xóa thành công");
                            getData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }
    }
}


