using DevExpress.RichEdit.Export;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RestSharp;
using System.IO;

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
            try
            {
                var request = new RestRequest(resource, Method.Get);
                var response = _client.Execute(request);
                  if (response.IsSuccessful)
                {
                    var content = response.Content;
                    return JsonConvert.DeserializeObject<ApiResponse<List<T>>>(content);
                }
               
                    Console.WriteLine(response.ErrorMessage);
                   return null;
                
            }
            catch (Exception ex)
            {
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
        
        public ApiResponse<List<T>> SendListToApi<T>( string resource, List<T> entities)
        {
          
            var request = new RestRequest(resource, Method.Post);
            request.AddJsonBody(entities);

            var response = _client.Execute(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<ApiResponse<List<T>>>(response.Content);
            }
            else
            {
                Console.WriteLine($"Error: {response.ErrorMessage}");
                return null;
            }
        }

        public ApiResponse<T> SendDeteleRequest<T>(string resource, object body)
        {
            var request = new RestRequest(resource, Method.Delete);
            request.AddJsonBody(body);

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


        public ApiResponse<List<T>> SendDeleteListRequest<T>(string resource, List<T> entities)
        {
            var request = new RestRequest(resource, Method.Delete);
            request.AddJsonBody(entities);

            var response = _client.Execute(request);
            //var response = _client.Execute<ApiResponse<T>>(request);
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


        public ApiResponse<T> SendImageUploadRequest<T>(string resource, string restaurantId, byte[] imageData)
        {
            try
            {
                var request = new RestRequest(resource + "/" + restaurantId, Method.Post);

                // Đính kèm hình ảnh vào yêu cầu
                request.AddFile("file", imageData, "restaurant_image.jpg");

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }






    }
}
