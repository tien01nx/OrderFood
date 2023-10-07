
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class Order : BaseModel
    {

        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]

        public string Id { get; set; }

        [Required(ErrorMessage = "Chưa có id người dùng.")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]

        public User? User { get; set; }

        public DateTime OrderDate { get; set; }



        public double OrderTotal { get; set; }


        public string? OrderStatus { get; set; }


        public string? PaymentStatus { get; set; }

        [Required(ErrorMessage = "Chưa có id nhà hàng.")]
        public string RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]

        [ValidateNever]
        public Restaurant Restaurant { get; set; }


    }
}
