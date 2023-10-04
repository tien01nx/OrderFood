
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DataAccess.Model
{
    public class Restaurant : BaseModel
    {

        public int Id { get; set; }
        public string RestaurantName { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public DateTime OpenTime { get; set; }

        public DateTime CloseTime { get; set; }


        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public User? User { get; set; }

    }
}
