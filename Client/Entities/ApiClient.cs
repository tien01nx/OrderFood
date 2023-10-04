using Newtonsoft.Json;
using RestSharp;

namespace Client.Entities
{
    public class ApiClient
    {
        private readonly RestClient _client;

        private readonly string _apiKey = "http://localhost:5000/api";
        public ApiClient()
        {
            _client = new RestClient(_apiKey);
        }

        public ApiResponse<T> GetSingleData<T>(string resource)
        {
            var request = new RestRequest(resource, Method.Get);
            var response = _client.Execute(request);
            if (response.IsSuccessful)
            {
                var content = response.Content;
                return JsonConvert.DeserializeObject<ApiResponse<T>>(content);

            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
                return null;
            }
        }

        public ApiResponse<List<T>> GetData<T>(string resource)
        {

            var request = new RestRequest(resource, Method.Get);
            var response = _client.Execute(request);
            if (response.IsSuccessful)
            {
                var content = response.Content;
                return JsonConvert.DeserializeObject<ApiResponse<List<T>>>(content);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
                return null;
            }
        }






        public ApiResponse<T> SendPostRequest<T>(string resource, object body)
        {
            var request = new RestRequest(resource, Method.Post);
            request.AddJsonBody(body);

            var response = _client.Execute(request);
            //var response = _client.Execute<ApiResponse<T>>(request);
            if (response.IsSuccessful)
            {
                var content = response.Content;
                return JsonConvert.DeserializeObject<ApiResponse<T>>(content);
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
                return null;
            }
        }




    }
}
