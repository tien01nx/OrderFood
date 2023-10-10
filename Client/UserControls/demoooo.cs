using Client.Entities;
using Client.Model;
using DevExpress.XtraEditors;
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
    public partial class demoooo : DevExpress.XtraEditors.XtraUserControl
    {

        private readonly frmMain _frmMain;

        private readonly ApiClient _apiClient;


        public demoooo(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
            _apiClient = new ApiClient();
        }

        private void timeEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        // ánh xạ để lấy dữ liệu từ form
        public void getView()
        {

            DateTime selectedTime = timeStart.Time;
            DateTime closetime = timeEnd.Time;

            TimeSpan timeOpen = new TimeSpan(selectedTime.Hour, selectedTime.Minute, 0);
            TimeSpan timeClose = new TimeSpan(closetime.Hour, closetime.Minute, 0);

            Restaurant restaurant = new Restaurant()
            {
                RestaurantName = txtBankName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                OpenTime = timeOpen,
                CloseTime = timeClose,
                BankName = txtBankName.Text,
                BankNumber = txtBankNumber.Text,
                BankAccount = int.Parse(txtBankAccount.Text),
                Notes = meNotes.Text,
                ImageUrl = "hehehe"
            };
            MessageBox.Show(restaurant.ToString());


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnAddRestaurant_Click(object sender, EventArgs e)
        {
            getView();
        }
    }
}
