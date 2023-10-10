
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class Product : BaseModel
    {
 
        [Key] public string Id { get; set; }

        [Required(ErrorMessage = "ProductName không được để trống.")]
        [MaxLength(300)]
        [MinLength(3, ErrorMessage = "ProductName phải có ít nhất 3 ký tự")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "Description không được để trống.")]
        [MaxLength(500)]
        [MinLength(3, ErrorMessage = "Description phải có ít nhất 3 ký tự")]
        public string Description { get; set; }



        [MaxLength(300)]
        public string Images { get; set; }



        [Required(ErrorMessage = "Vui lòng chọn Giá tiền")]
        [Range(1000, 500000, ErrorMessage = "Giá sản phẩm nằm trong khoảng 1000 đến 500000")]
        public decimal Price { get; set; }


        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]
        [Required(ErrorMessage = "không được để trống  danh mục sản phẩm.")]
        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }




        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]
        [Required(ErrorMessage = "không được để trống  tên cửa hàng.")]
        public string RestaurantId { get; set; }
        [ForeignKey("RestaurantId")]
        [ValidateNever]
        public Restaurant Restaurant { get; set; }


        // các biến tạo thêm để lấy dự liệu từ sql
        //[NotMapped]
        //public string  OrderId { get; set; }


        //[NotMapped]


    }
}
