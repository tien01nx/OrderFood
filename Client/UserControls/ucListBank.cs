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
            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucListOrder(), "ucListOrder");
            }
        }

        private void btnSwitchToBank_Click(object sender, EventArgs e)
        {

            if (frmMain.Instance != null)
            {
                frmMain.Instance.AddUserControl(new ucBank(), "ucBank");
            }

        }
    }
}
