using Client.UserControls;
using DevExpress.XtraEditors;

namespace Client
{
    public partial class frmMain : XtraForm
    {
        public static frmMain Instance;

        public frmMain()
        {

            InitializeComponent();
            Instance = this;

        }

        public PanelControl PnlParent
        {
            get { return pnParent; }
            set { pnParent = value; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            if (!PnlParent.Controls.ContainsKey("ucListOrder"))
            {
                ucListOrder uc = new ucListOrder();
                uc.Name = "ucListOrder";
                uc.Dock = DockStyle.Fill;
                PnlParent.Controls.Add(uc);
            }

            PnlParent.Controls["ucListOrder"].BringToFront();
            PnlParent.Controls["ucListOrder"].Show();

        }

        // thêm UserControl vào frmMain
        public void AddUserControl(XtraUserControl uc, string ucName)
        {
            if (!PnlParent.Controls.ContainsKey(ucName))
            {
                uc.Name = ucName;
                uc.Dock = DockStyle.Fill;
                PnlParent.Controls.Add(uc);
            }
            PnlParent.Controls[ucName].BringToFront();
            PnlParent.Controls[ucName].Show();

        }


        public XtraUserControl GetUserControl(string controlName)
        {
            if (PnlParent.Controls.ContainsKey(controlName))
            {
                return PnlParent.Controls[controlName] as XtraUserControl;
            }
            return null;
        }



        // thêm ucListOrder vào frmMain
        private void btnDanhsachdonhang_Click(object sender, EventArgs e)
        {
            //ucListOrder uc = new ucListOrder(this);
            //AddUC(uc);

            AddUserControl(new ucListOrder(), "ucListOrder");

        }

        // thêm ucListProduct vào frmMain

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddUserControl(new ucListProduct(), "ucListProduct");
            //ucListProduct uc = new ucListProduct(this);
            //AddUC(uc);
        }

        // thêm ucListBank vào frmMain
        private void danhSáchThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserControl(new ucListBank(this), "ucListBank");

            //ucListBank uc = new ucListBank(this);
            //AddUC(uc);
        }

        private void restaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserControl(new ucListRestaurants(false), "ucListRestaurants");

            //ucListRestaurants uc = new ucListRestaurants(this, false);
            //AddUC(uc);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserControl(new ucListProduct(), "ucListProduct");

            //ucProduct uc = new ucProduct(this);
            //AddUC(uc);
        }

        private void SubBtnListCategories_Click(object sender, EventArgs e)
        {
            AddUserControl(new ucListCategories(), "ucListCategories");
        }
    }

}
