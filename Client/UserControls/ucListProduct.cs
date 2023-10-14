namespace Client.UserControls
{
    public partial class ucListProduct : DevExpress.XtraEditors.XtraUserControl
    {


        public ucListProduct()
        {
            InitializeComponent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh";
                openFileDialog.Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<Image> selectedImages = new List<Image>();

                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        selectedImages.Add(Image.FromFile(fileName));
                    }

                    // Ở đây, bạn có thể xử lý danh sách các ảnh như bạn muốn
                    // Ví dụ: hiển thị ảnh đầu tiên trong PictureEdit:
                    if (selectedImages.Count > 0)
                    {
                        pictureBox1.Image = selectedImages[0];
                    }
                }
            }
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
    }
}
