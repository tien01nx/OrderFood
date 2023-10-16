using DataAccess.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using DataAccess.Utilis;

namespace API.DTO
{
    public class ProductDto 
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public string RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string CategoryName { get; set; }

        public void GenerateRandomId()
        {
            RandomString randomStringGenerator = new RandomString();
            Id = "Pro" + randomStringGenerator.NextString(10); // Độ dài của ID
        }
        public override string ToString()
        {
            return $"Id: {Id}, Product Name: {ProductName}, Description: {Description}, Images: {Images}, Price: {Price}, CategoryId: {CategoryId}, RestaurantId: {RestaurantId}, RestaurantName: {RestaurantName}, CategoryName: {CategoryName}";
        }


    }
}
