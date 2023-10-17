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

            var response = _client.SendPostRequest<LoginVM>(resource, GetData());

            if (response != null)
            {
                if (response.Code == System.Net.HttpStatusCode.OK)
                {

                    var user = response.Data.user;
                    //MessageBox.Show("Đăng nhập thành công");
                    SaveData(user.Id,user.UserName,txtPassword.Text, response.Data.Token);

                    frmMain main = new frmMain();

                    // Đăng ký sự kiện CompletedWork
                    main.CompletedWork += (sender, e) => {
                        // Đóng formLogin khi frmMain đã hoàn thành công việc
                        this.Close();
                    };

                    // Hiển thị frmMain
                    main.Show();



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

        // lưu dữ liệu vào Settings.settings
        public void SaveData(int id,string username,string password, string token)
        {
            Properties.Settings.Default.UserName = username;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Token = token;
            Properties.Settings.Default.ID = id;
            Properties.Settings.Default.Save();
            // Tạo chuỗi biểu diễn để hiển thị trong MessageBox
            string message = $"ID: {Properties.Settings.Default.ID}" + Environment.NewLine +
                             $"Username: {Properties.Settings.Default.UserName}" + Environment.NewLine +
                             $"Password: [Hidden]" + Environment.NewLine + // Dùng [Hidden] để ẩn mật khẩu
                             $"Token: {Properties.Settings.Default.Token}";

            MessageBox.Show(message, "Saved Data"); // Hiển thị MessageBox với tiêu đề "Saved Data"
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