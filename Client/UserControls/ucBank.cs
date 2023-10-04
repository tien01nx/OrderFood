namespace Client.UserControls
{
    public partial class ucBank : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;
        public ucBank(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void closeUcBank_Click(object sender, EventArgs e)
        {
            _frmMain.RemoveUC();
        }
    }
}
