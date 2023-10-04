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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmProduct : Form
    {

        private readonly ApiClient _apiClient;
        public frmProduct()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            Form_load();
        }


        public void Form_load()
        {
            var categoriesResponse = _apiClient.GetData<Product>("Product/Getall");
            gridProduct.DataSource = categoriesResponse?.Data;
        }
        //public void Form_load()
        //{
        //    Uri Url = new Uri("http://localhost:5000/api/Product/Getall");
        //    var restClient = new RestClient(Url);
        //    RestRequest restRequest = new RestRequest("", Method.Get);
        //    var restResponse = restClient.Execute(restRequest);

        //    if (restResponse.IsSuccessful)
        //    {
        //        var content = restResponse.Content; 
        //        var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Product>>>(content); 
        //        var categories = apiResponse.Data; 
        //        gridProduct.DataSource = categories;
        //    }
        //    else
        //    {
        //        Console.WriteLine(restResponse.ErrorMessage);
        //    }
        //}

    }
}
