using Client.UserControls;
using DevExpress.XtraEditors;

namespace Client
{
    public partial class frmMain : XtraForm
    {
        // tạo một stack để lưu trữ các UserControl 
        private Stack<XtraUserControl> userControlStack = new Stack<XtraUserControl>();

        public frmMain()
        {

            InitializeComponent();

        }

        public void AddUC(XtraUserControl uc)
        {



            // Ẩn UserControl hiện tại (nếu có)
            if (userControlStack.Count > 0)
            {
                userControlStack.Peek().Hide();
            }

            // Thêm  mới vào stack
            userControlStack.Push(uc);

            // Hiển thị UserControl mới
            uc.Dock = DockStyle.Fill;
            pnParent.Controls.Add(uc);
            uc.Show();
        }


        // kiểm tra xem stack có UserControl nào không 
        public void RemoveUC()
        {
            if (userControlStack.Count > 0)
            {
                XtraUserControl currentUC = userControlStack.Pop();
                currentUC.Hide();
                if (userControlStack.Count > 0)
                {
                    userControlStack.Peek().Show();
                }
            }
        }
        // thêm ucContainer vào frmMain
        private void frmMain_Load(object sender, EventArgs e)
        {
            //ucListOrder uc = new ucListOrder(this);
            ucProduct uc = new ucProduct(this);
            AddUC(uc);
        }

        // thêm ucListOrder vào frmMain
        private void btnDanhsachdonhang_Click(object sender, EventArgs e)
        {
            ucListOrder uc = new ucListOrder(this);
            AddUC(uc);

        }

        // thêm ucListProduct vào frmMain

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucListProduct uc = new ucListProduct(this);
            AddUC(uc);
        }

        // thêm ucListBank vào frmMain
        private void danhSáchThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucListBank uc = new ucListBank(this);
            AddUC(uc);
        }

        private void restaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucListRestaurants uc = new ucListRestaurants(this);
            AddUC(uc);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucProduct uc = new ucProduct(this);
            AddUC(uc);
        }
    }

}
