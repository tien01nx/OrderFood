namespace Client.UserControls
{
    public partial class ucListBank : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        public ucListBank(frmMain frmMain)
        {

            InitializeComponent();
            _frmMain = frmMain;
        }

        private void gridData_Click(object sender, EventArgs e)
        {

        }

        private void closeUcBank_Click(object sender, EventArgs e)
        {
            _frmMain.RemoveUC();
        }

        private void btnSwitchToBank_Click(object sender, EventArgs e)
        {

            ucBank uc = new ucBank(_frmMain);
            _frmMain.AddUC(uc);

        }
    }
}
