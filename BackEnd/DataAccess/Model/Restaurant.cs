using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public class Restaurant : BaseModel
    {
        [StringLength(10, ErrorMessage = "Id tối đa {1} ký tự")]
        public string Id { get; set; }

        [Required(ErrorMessage = "RestaurantName không được để trống.")]
        [MaxLength(300)]
        [MinLength(3, ErrorMessage = "RestaurantName phải có ít nhất 3 ký tự")]
        public string RestaurantName { get; set; }

        [StringLength(12, ErrorMessage = "PhoneNumber tối đa {1} ký tự")]
        [Required(ErrorMessage = "PhoneNumber không được để trống.")]
        [MinLength(3, ErrorMessage = "PhoneNumber phải có ít nhất 10 ký tự")]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }

        public TimeSpan OpenTime { get; set; }

        public TimeSpan CloseTime { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập số tài khoản")]
        public int BankAccount { get; set; }



        [StringLength(50, ErrorMessage = "BankNumber tối đa {1} ký tự")]
        [Required(ErrorMessage = "Vui lòng nhập số  tài khoản")]
        public string BankNumber { get; set; }



        [StringLength(50, ErrorMessage = "Tên chủ tài khoản tối đa {1} ký tự")]
        [Required(ErrorMessage = "Vui lòng nhập tên tài khoản")]
        public string BankName { get; set; }



        //[Required(ErrorMessage = "Vui lòng nhập cấp độ yêu thích")]
        public byte ?FavoriteLevel { get; set; }


        [StringLength(100, ErrorMessage = "Notes tối đa {1} ký tự")]
        [Required(ErrorMessage = "Notes không được để trống.")]
        public string Notes { get; set; }
        


    }
}
