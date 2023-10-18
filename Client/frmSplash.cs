using Timer = System.Windows.Forms.Timer;

namespace Client
{
    public partial class frmSplash : DevExpress.XtraEditors.XtraForm
    {
        int move = 2;
        Timer splashTimer;
        bool mainFormShown = false;

        public frmSplash()
        {
            InitializeComponent();
            splashTimer = new Timer();
            splashTimer.Interval = 5000; // Đặt thời gian đếm là 5 giây
            splashTimer.Tick += new EventHandler(splashTimer_Tick);
            splashTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if (panelSlide.Left > 734)
            {
                panelSlide.Left = 465;
            }
            if (panelSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Hide();

            if (!mainFormShown)
            {
                string username = Properties.Settings.Default.UserName;
                string password = Properties.Settings.Default.Password;
                // kiểm tra người dùng đã đăng nhập chưa lấy dữ liệu từ Settings.settings nếu đã đăng nhập thì cho vào frmMain 
                // còn không cho sang frmLogin
                if (username != string.Empty && password != string.Empty)
                {
                    // đăng nhập để lấy token mới
                    frmLogin frmLogin = new frmLogin();
                    var login = frmLogin.GetData();
                    frmLogin.signIn(login);
                    mainFormShown = true;

                }
                else
                {
                    frmLogin loginForm = new frmLogin();
                    mainFormShown = true;
                    loginForm.ShowDialog();

                }

                //frmMain mainForm = new frmMain();
                //mainFormShown = true;
                //mainForm.ShowDialog();
            }
        }
    }

}