
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class OrderDetail : BaseModel
    {
        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]

        public string Id { get; set; }

        [Required(ErrorMessage = "OrderId chưa có giá trị.")]

        public string OrderId { get; set; }
        [ForeignKey("OrderId")]
        [ValidateNever]
        public Order Order { get; set; }

        [Required(ErrorMessage = "Product chưa có giá trị.")]
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }

        [Range(1, 100, ErrorMessage = "số lượng trong khoảng từ 1 đến 100.")]
        public int Count { get; set; }

        public decimal Price { get; set; }
    }
}
