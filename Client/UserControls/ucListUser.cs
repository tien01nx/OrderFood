using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class ucListUser : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;
        private string date = null;
        public ucListUser()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            LoadData();
        }

        // lấy danh sách user
        public void LoadData()
        {
            string search = txtSearch.Text;



            var listUser = _apiClient.GetData<User>($"Users/GetListUsers?search={search}&birthday={date}").Data;
            gridListUser.DataSource = listUser;

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateBirthday_EditValueChanged(object sender, EventArgs e)
        {
            date = dateBirthday.DateTime.Date.ToString("yyyy-MM-dd");
            if(date == "0001-01-01")
            {
               date= null;

            }
         
            LoadData();

        }

        private void SubBtnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dateBirthday.Text = null;
            LoadData();
        }
    }

}
