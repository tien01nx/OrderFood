using Client.Model;

namespace Client.UserControls
{
    public partial class ucUser : DevExpress.XtraEditors.XtraUserControl
    {

        public ucUser()
        {
            InitializeComponent();
        }

        private void SubBtnClear_Click(object sender, EventArgs e)
        {

        }

        private void SubbtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnClose_Click(object sender, EventArgs e)
        {

        }

        // get giữ liệu lên giao diện frm
        public void getUserFrm(User user)
        {
            txtAddress.Text = user.Address;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            mdApartmentNumber.Text = user.ApartmentNumber;
            txtUserName.Text = user.UserName;
            txtPhoneNumber.Text = user.PhoneNumber;
            id.Text = user.Id.ToString();
            if (user.Gender == "Nam")
            {
                ckNam.Checked = true;
            }
            else
            {
                ckNu.Checked = true;
            }

        }

    }
}
