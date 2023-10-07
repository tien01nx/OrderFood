using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class Bank : BaseModel
    {
        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]
        public string Id { get; set; }


        [MaxLength(50)]
        [MinLength(3, ErrorMessage = "Tên ngân hàng phải có ít nhất 3 ký tự")]
        [Required(ErrorMessage = "Yêu cầu nhập tên ngân hàng.")]
        public string BankName { get; set; }


        [MaxLength(300)]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Chưa có id người dùng.")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public User User { get; set; }
    }
}
