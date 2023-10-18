using Client.DTO;
using Client.Entities;
using Client.Model;

namespace Client
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        private readonly ApiClient _client;
        public frmLogin()
        {

            InitializeComponent();
            _client = new ApiClient();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            var loginDto = new LoginDTO { UserName = username, Password = password };
            signIn(loginDto);
        }


        // Login 
        public void signIn(LoginDTO loginDto)
        {
            var resource = "Account/login";

            var response = _client.SendPostRequest<LoginVM>(resource, loginDto);

            if (response != null)
            {
                if (response.Code == System.Net.HttpStatusCode.OK)
                {

                    //MessageBox.Show("Đăng nhập thành công");
                    var user = response.Data.user;
                    SaveData(user.Id, user.UserName, txtPassword.Text, response.Data.Token);
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    string errorMessage = response.Message;
                    MessageBox.Show($"Đăng nhập thất bại: {errorMessage}");
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
            }
        }
        // lưu dữ liệu vào Settings.settings
        public void SaveData(int id, string username, string? password, string token)
        {
            Properties.Settings.Default.UserName = username;
            if (!password.Equals(""))
            {
                Properties.Settings.Default.Password = password;

            }
            Properties.Settings.Default.Token = token;
            Properties.Settings.Default.ID = id;
            Properties.Settings.Default.Save();

        }
        // xóa dữ liệu khỏi Settings.settings

        public void ClearData()
        {
            Properties.Settings.Default.UserName = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
        }

        // lấy dữ liệu từ Settings.settings
        public LoginDTO GetData()
        {
            LoginDTO loginDTO = new LoginDTO()
            {
                UserName = Properties.Settings.Default.UserName,
                Password = Properties.Settings.Default.Password
            };
            return loginDTO;
        }

    }
}