namespace Client
{
    public partial class formdemo : UserControl


    {

        public event EventHandler ItemClicked;


        public formdemo()
        {
            InitializeComponent();
        }
        public void SetProduct(string title, string description, Image image)
        {
            Title.Text = title;
            profile.Text = description;
            imageProduct.Image = image;
        }
        private void OnItemClicked()
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void formdemo_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OnItemClicked();
        }
    }
}
