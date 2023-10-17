using API.DTO;
using Client.DTO;
using Client.Entities;
using Client.Model;
using DataAccess.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var resource = "Account/login"; // Thay đổi này thành đường dẫn thực sự đến endpoint login của bạn

            var response = _client.SendPostRequest<LoginVM>(resource, loginDto);

            if (response != null)
            {
                if (response.Code == System.Net.HttpStatusCode.OK)
                {
                    Login login = new Login();
                    
                    string token = response.Message;
                    SecureString secureToken = TokenManager.ConvertToSecureString(token);
                    //this.Hide();
                    //frmHome formHome = new frmHome();
                    //formHome.ShowDialog();
                    //this.Close();

                }
                else
                {
                    // Đăng nhập thất bại
                    string errorMessage = response.Message;
                    MessageBox.Show($"Đăng nhập thất bại: {errorMessage}");
                }
            }
            else
            {
                // Kết nối đến server thất bại hoặc lỗi khác
                MessageBox.Show("Không thể kết nối đến server. Vui lòng kiểm tra lại kết nối và thử lại.");
            }
        }
    }
}