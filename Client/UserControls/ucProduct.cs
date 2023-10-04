namespace Client.UserControls
{
    public partial class ucProduct : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        public ucProduct(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }


        private void closeucProduct_Click(object sender, EventArgs e)
        {
            _frmMain.RemoveUC();
        }
    }
}
