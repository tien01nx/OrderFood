namespace Client
{
    public partial class ucProductItem : DevExpress.XtraEditors.XtraUserControl
    {
        public ucProductItem()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        public void SetProduct(string name, double price, Image image)
        {
            lblProductName.Text = name;
            lblPrice.Text = price.ToString();
            //nudQuantity.Text = quantity.ToString();
            pcProductImg.Image = image;
        }


    }
}
