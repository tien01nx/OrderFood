using Client.Entities;
using Client.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmCategory : Form
    {

        private ApiClient _apiClient;
        public frmCategory()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            Form_load();
        }


        public void Form_load()
        {
            var categoriesResponse = _apiClient.GetData<Category>("Category/Getall");
            gridCategory.DataSource = categoriesResponse?.Data;
        }


        private void gridCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //public void Form_load()
        //{
        //    Uri Url = new Uri("http://localhost:5000/api/Category/Getall");
        //    var restClient = new RestClient(Url);
        //    RestRequest restRequest = new RestRequest("", Method.Get);
        //    var restResponse = restClient.Execute(restRequest);

        //    if (restResponse.IsSuccessful)
        //    {
        //        var content = restResponse.Content; // Đọc nội dung JSON trực tiếp
        //        var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Category>>>(content); // Chuyển đổi JSON thành đối tượng
        //        var categories = apiResponse.Data; // Lấy danh sách các Category
        //        gridCategory.DataSource = categories; // Gán làm DataSource cho DataGridView
        //    }
        //    else
        //    {
        //        Console.WriteLine(restResponse.ErrorMessage);
        //    }
        //}


    }
}
