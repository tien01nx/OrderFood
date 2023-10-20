using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucListRestaurants : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;
        public bool _isCheckuc = false;
        private string _selectedRestaurant = string.Empty;
        private string _selectedFavoriteLevel = string.Empty;
        private bool _isOpenTime;

        public ucListRestaurants(bool isCheckuc)
        {
            InitializeComponent();
            _apiClient = new ApiClient();



        }



        private void ucListRestaurants_Load(object sender, EventArgs e) { LoadData(); }


        public void LoadData()
        {
            // Load data from database
            // Bind data to gridview
            // lấy dữ liệu của Restaurant từ database
            DateTime now = DateTime.Now;

            int hour = now.Hour;
            int minute = now.Minute;

            string currentTime = hour + ":" + minute;
            if (_isOpenTime != true)
            {
                currentTime = string.Empty;
            }
            var restaurants = _apiClient.GetData<RestaurantVM>(
                $"Restaurant/GetRestaurantByKeyword?restaurant={_selectedRestaurant}&favoriteLevel={_selectedFavoriteLevel}&time={currentTime}")
                .Data;
            if (restaurants != null)
            {
                foreach (var item in restaurants)
                {
                    item.Image = LoadProductImage(item.ImageUrl);

                    cboRestaurant.Properties.Items.Add(item.RestaurantName);
                    // Kiểm tra nếu cboFavoriteLevel chưa có mục này thì mới thêm
                    if (!cboFavoriteLevel.Properties.Items.Contains(item.FavoriteLevel))
                    {
                        cboFavoriteLevel.Properties.Items.Add(item.FavoriteLevel);
                    }
                }
                girdRestaurant.DataSource = restaurants;
                girdRestaurant.RefreshDataSource();
                if (SessionData.GetUC() == null)
                {
                    GridView view = girdRestaurant.MainView as GridView;
                    if (view != null)
                    {

                        view.Columns["Chon"].Visible = false;

                    }
                }

            }



        }


        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e) { MessageBox.Show("Edit"); }

        private void cboRestaurant_EditValueChanged(object sender, EventArgs e)
        {
            // ép kiểu sender về kiểu ComboBoxEdit
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            _selectedRestaurant = comboBox.EditValue.ToString();
            LoadData();

            //MessageBox.Show(_selectedRestaurant,_selectedFavoriteLevel);
        }

        private void cboFavoriteLevel_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            _selectedFavoriteLevel = comboBox.EditValue.ToString();
            LoadData();
        }

        private void ckOpenTime_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkEdit = sender as CheckEdit;
            if (checkEdit.Checked)
            {
                _isOpenTime = true;
                LoadData();
            }
            else
            {
                _isOpenTime = false;
            }
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

        private void btnSubmitData_Click(object sender, EventArgs e)
        {
            var restaurant = (gridlayout.GetFocusedRow() as RestaurantVM);
            if (restaurant == null) return;

            SessionData.AddRestaurant(restaurant);
            var ucName = SessionData.GetUC();

            if (ucName != null)
            {
                UserControl userControl = frmMain.Instance?.GetUserControl(ucName);

                switch (ucName)
                {
                    case "ucProduct":
                        UpdateUcProduct(userControl as ucProduct, restaurant);
                        break;

                    case "ucListCategories":
                        UpdateUcListCategories(userControl as ucListCategories, restaurant);
                        break;

                    case "ucCategory":
                        UpdateUcCategory(userControl as ucCategory, restaurant);
                        break;

                    case "ucListProduct":
                        UpdateUcListProduct(userControl as ucListProduct, restaurant);
                        break;
                }

                SessionData.ClearUC();
            }

            this.Hide();
        }

        private void UpdateUcProduct(ucProduct control, RestaurantVM restaurant)
        {
            if (control == null) return;
            control.GetRestaurant();
            SessionData.RemoveRestaurant(restaurant);
        }

        private void UpdateUcListCategories(ucListCategories control, RestaurantVM restaurant)
        {
            if (control == null) return;
            control.GetRestaurant();
            control.getData();
            SessionData.RemoveRestaurant(restaurant);
        }

        private void UpdateUcCategory(ucCategory control, RestaurantVM restaurant)
        {
            if (control == null) return;
            control.GetRestaurant();
            SessionData.RemoveRestaurant(restaurant);
        }

        private void UpdateUcListProduct(ucListProduct control, RestaurantVM restaurant)
        {
            if (control == null) return;
            control.GetRestaurant();
            control.LoadData();
            SessionData.RemoveRestaurant(restaurant);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {

                frmMain.Instance.AddUserControl(new ucListOrder(), "ucListOrder");
            }
        }


        // RefreshUI giao diện uc này
        public void RefreshUI()
        {
            // cập nhật lại các dữ liệu trên form này về ban đầu
            cboRestaurant.EditValue = null;
            cboFavoriteLevel.EditValue = null;
            ckOpenTime.Checked = false;
            _isCheckuc = true;
        }

        private void gridlayout_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {


            //if (e.Column.FieldName == "Hehe" && e.IsGetData)
            //{
            //    // Lấy giá trị URL từ cột ImageUrl
            //    string imageUrl = gridlayout.GetRowCellValue(e.ListSourceRowIndex, "ImageUrl") as string;

            //    // Kiểm tra xem URL có tồn tại không
            //    if (!string.IsNullOrEmpty(imageUrl))
            //    {
            //        Image image = LoadProductImage(imageUrl);
            //        if (image != null)
            //        {
            //            e.Value = image;
            //        }
            //    }
            //    else
            //    {
            //        // Nếu không có URL, bạn có thể gán một hình ảnh mặc định hoặc giá trị khác tùy ý.
            //    }

            //}
        }

        private void SubBtnAdd_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucRestaurant(), "ucRestaurant");
            }
        }

        private void SubBtnSelect_Click(object sender, EventArgs e)
        {
            if (gridlayout.SelectedRowsCount > 0)
            {
                var firstSelectedRowHandle = gridlayout.GetSelectedRows()[0];
                var firstSelectedRow = gridlayout.GetRow(firstSelectedRowHandle) as RestaurantVM;

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


                    //SessionData.Category = firstSelectedRow;
                    SessionData.RestaurantVM = firstSelectedRow;
                    MessageBox.Show("Đã chọn");
                }
            }
        }

        private void SubBtnEdit_Click(object sender, EventArgs e)
        {
            // chuyển  sang ucRestaurant và cập nhật giao diện ucRestaurant
            // kiểm tra ucRestaurant đã tồn tại trong frmMain chưa nếu tồn tại thì cập nhật lại giao diện
            // còn chưa tồn tại thì tao mới và thêm vào frmMain và cập nhật giao diện từ SessionData.RestaurantVM
            if (frmMain.Instance != null)
            {
                var existingUcRestaurant = frmMain.Instance?.GetUserControl("ucRestaurant") as ucRestaurant;
                if (existingUcRestaurant != null)
                {
                    existingUcRestaurant.setRestaurant(SessionData.RestaurantVM);
                    frmMain.Instance.AddUserControl(existingUcRestaurant, "ucRestaurant");
                }
                else
                {
                    // UserControl chưa tồn tại, tạo và thêm vào frmMain
                    ucRestaurant newUcRestaurant = new ucRestaurant();
                    newUcRestaurant.setRestaurant(SessionData.RestaurantVM);
                    frmMain.Instance.AddUserControl(newUcRestaurant, "ucRestaurant");
                }
            }
        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ người dùng chọn => SessionData.RestaurantVM
            if (SessionData.RestaurantVM != null)
            {
                // Thông báo cho người dùng có xóa không ?
                DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà hàng {SessionData.RestaurantVM.RestaurantName} không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // xóa dữ liệu trong database
                    var result = _apiClient.SendDeteleRequest<RestaurantVM>($"Restaurant/{SessionData.RestaurantVM.Id}");
                    if (result != null)
                    {
                        // xóa thành công
                        MessageBox.Show("Xóa thành công");
                        // cập nhật lại giao diện ucListRestaurants
                        LoadData();
                    }
                    else
                    {

                        MessageBox.Show("Vui lòng chọn nhà hàng muốn xoa");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    // không xóa
                }
            }
        }
    }
}
