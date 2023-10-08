using Client.Entities;
using Client.Model;
using DevExpress.PivotGrid.OLAP;
using DevExpress.Utils.Svg;
using DevExpress.Xpf.Editors;

namespace Client
{
    public partial class ucProductItem : DevExpress.XtraEditors.XtraUserControl
    {
        private int ProductId;

        public int CartId;
        public event EventHandler ItemClicked;

        public bool IsUpdateMode { get; private set; }


        public ucProductItem()
        {
            InitializeComponent();
            IsUpdateMode = false;

        }

        private void OnItemClicked()
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }


        public void SetProduct(int productId, string name, double price, Image image)
        {
            this.ProductId = productId;
            lblProductName.Text = name;
            lblPrice.Text = price.ToString();
            pcProductImg.Image = image;
        }

        public void UpdateProductInfo(UserInfoDTO userInfo)
        {
            //if (userInfo != null && this.ProductId == userInfo.ProductId)
            //{
            //    this.spinQuantity.Value = userInfo.TotalQuantity;
            //    this.chkIsChoose.Checked = true;
            //    CartId = userInfo.Id;
            //    IsUpdateMode = true;

            //}
            //else
            //{
            //    this.spinQuantity.Value = 1;
            //    this.chkIsChoose.Checked = false;
            //    IsUpdateMode = false;
            //}
        }
        public decimal SpinQuantityValue
        {
            get { return spinQuantity.Value; }
            set { spinQuantity.Value = value; }
        }
        public int GetId()
        {
            return CartId;
        }

        public bool GetIsUpdateMode()
        {
            return IsUpdateMode;
        }
    }
}
