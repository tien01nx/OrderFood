using Client.Entities;
using Client.Model;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Client.UserControls
{
    public partial class ucListOrder : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ApiClient _apiClient;
        private readonly frmMain _mainForm;

        public ucListOrder(frmMain mainForm)
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            _mainForm = mainForm;
            dtOrderDate.DateTime = DateTime.Now;
        }

        private void ucListOrder_Load(object sender, EventArgs e)
        {
            GetOrderByUserAll();
            //getProduct();
        }


        private void GetOrderByUserAll()
        {
            DateTime date = dtOrderDate.DateTime;
            string dateString = date.ToString("yyyy/MM/dd");
            string UserName = string.IsNullOrEmpty(txtUserName.Text) ? "" : txtUserName.Text;
            string Title = string.IsNullOrEmpty(txtTile.Text) ? "" : txtTile.Text;

            try
            {
                var userOrder = _apiClient.GetData<UserInfoDTO>($"Order/UserAllOrders?date={dateString}&UserName={UserName}&Title={Title}").Data;
                //var userOrder = _apiClient.GetData<UserInfoDTO>($"Order/UserAllOrders?date={dateString}&UserName={UserName}&Title={Title}").Data;
                Console.WriteLine(JsonConvert.SerializeObject(userOrder));
                gridData.DataSource = userOrder;
                // Lấy GridView từ gridData's MainView
                //GridView view = gridData.MainView as GridView;

                //if (view != null)
                //{
                //    // Ẩn các cột bạn không muốn hiển thị
                //    view.Columns["OrderId"].Visible = false;
                //    view.Columns["ProductId"].Visible = false;
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SubBtnOrder_Click(object sender, EventArgs e)
        {
            ucOrder uc = new ucOrder(_mainForm);
            _mainForm.AddUC(uc);
        }



        private Image LoadImageFromUrl(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(url);
                using (MemoryStream memStream = new MemoryStream(data))
                {
                    return Image.FromStream(memStream);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void closeUcListOrder_Click(object sender, EventArgs e)
        {
            _mainForm.RemoveUC();
        }

        private void dtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }

        private void gridData_Click(object sender, EventArgs e)
        {

        }

        private void dtOrderDate_EditValueChanged_1(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }

        private void txtUserName_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }

        private void txtTile_EditValueChanged(object sender, EventArgs e)
        {
            GetOrderByUserAll();
        }
    }
}
