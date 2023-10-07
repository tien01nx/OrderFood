using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class Category : BaseModel
    {
        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]
        public int Id { get; set; }

        [Required(ErrorMessage = "không được để trống  nhà hàng.")]
        public string RestaurantID { get; set; }
        [ForeignKey("RestaurantID")]
        [ValidateNever]
        public Restaurant Restaurant { get; set; }


        [MaxLength(50)]
        [MinLength(3, ErrorMessage = "Tên thể loại phải có ít nhất 3 ký tự")]
        [Required(ErrorMessage = "Yêu cầu nhập tên thể loại.")]

        public string CategoryName { get; set; }

        [MaxLength(500)]
        [MinLength(3, ErrorMessage = "Mô tả phải có ít nhất 3 ký tự")]
        [Required(ErrorMessage = "Yêu cầu nhập Mô tả.")]
        public string Descriptions { get; set; }
    }
}
