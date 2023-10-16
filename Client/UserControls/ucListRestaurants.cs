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
            btnXoa.Click += btnXoa_Click;


        }

        private void ucListRestaurants_Load(object sender, EventArgs e) { LoadData(); }
        private void btnXoa_Click(object? sender, EventArgs e) { MessageBox.Show("Xóa thành công"); }

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

        private void btnUcProduct_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new click(), "click");
            }
        }

        private void btnSubmitData_Click(object sender, EventArgs e)
        {
            var restaurant = (gridlayout.GetFocusedRow() as RestaurantVM);
            if (restaurant != null)
            {
                SessionData.AddRestaurant(restaurant);
                if (SessionData.GetUC() != null)
                {
                    if (SessionData.GetUC().Equals("ucProduct"))
                    {
                        // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                        var existingUcProduct = frmMain.Instance?.GetUserControl("ucProduct") as ucProduct;
                        if (existingUcProduct != null)
                        {
                            existingUcProduct.GetRestaurant();

                            SessionData.RemoveRestaurant(restaurant);

                        }
                    }
                    if (SessionData.GetUC().Equals("ucListCategories"))
                    {
                        // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                        var existingUcCategory = frmMain.Instance?.GetUserControl("ucListCategories") as ucListCategories;
                        if (existingUcCategory != null)
                        {
                            existingUcCategory.GetRestaurant();
                            existingUcCategory.getData();
                            SessionData.RemoveRestaurant(restaurant);

                        }
                    }
                    if (SessionData.GetUC().Equals("ucCategory"))
                    {
                        // Cập nhật ucProduct nếu nó vẫn còn tồn tại trong frmMain
                        var existingUcCategory = frmMain.Instance?.GetUserControl("ucCategory") as ucCategory;
                        if (existingUcCategory != null)
                        {
                            existingUcCategory.GetRestaurant();

                            SessionData.RemoveRestaurant(restaurant);

                        }
                    }
                    SessionData.ClearUC();
                }


                this.Hide();
            }
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
    }
}
