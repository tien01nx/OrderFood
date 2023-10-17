using Client.Entities;
using Client.Model;
using System.IO;
using System.Net;

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
            // cập nhật hình cho product
            foreach (var item in product)
            {
                item.ImageProduct = LoadProductImage(item.Images);
            }
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

        private void SubBtnSelect_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                var firstSelectedRowHandle = gridView1.GetSelectedRows()[0];
                var firstSelectedRow = gridView1.GetRow(firstSelectedRowHandle) as ProductVM;

                if (firstSelectedRow != null)
                {

                    SessionData.ProductVM = firstSelectedRow;
                    MessageBox.Show("Đã chọn");



                }



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

        private void SubBtnEdit_Click(object sender, EventArgs e)
        {
            // kiểm tra xem ucProduct đX TỒN TẠI  chưa, nếu tồn tại thì cập nhật còn chưa tồn tại thì tạo mới và cập nhật
            if (SessionData.ProductVM == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            else
            {
                var existingUcProduct = frmMain.Instance?.GetUserControl("ucProduct") as ucProduct;

                if (existingUcProduct != null)
                {

                    existingUcProduct.setProductVM(SessionData.ProductVM);
                    frmMain.Instance.AddUserControl(new ucProduct(), "ucProduct");

                }
                else
                {
                    frmMain.Instance.AddUserControl(new ucProduct(), "ucProduct");
                    var ucProduct = frmMain.Instance?.GetUserControl("ucProduct") as ucProduct;
                    ucProduct.setProductVM(SessionData.ProductVM);
                }

            }
        }

        private void SubBtnDelete_Click(object sender, EventArgs e)
        {
            // hiện thông báo xem người dùng có muốn xóa không, nếu đồng ý thì xóa

            if (SessionData.ProductVM == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            else
            {
                var result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var response = _apiClient.SendDeteleRequest<ProductVM>($"Product/{SessionData.ProductVM.Id}");
                    if (response.Code == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }
    }
}
