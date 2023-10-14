using DataAccess.Utilis;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public class Restaurant : BaseModel
    {

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
        public string? ImageUrl { get; set; }

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
        public byte? FavoriteLevel { get; set; }


        [StringLength(100, ErrorMessage = "Notes tối đa {1} ký tự")]
        [Required(ErrorMessage = "Notes không được để trống.")]
        public string Notes { get; set; }

        public void GenerateRandomId()
        {
            RandomString randomStringGenerator = new RandomString();
            Id = "Res" + randomStringGenerator.NextString(10); // Độ dài của ID
        }
        public override string ToString()
        {
            return $"Restaurant ID: {Id}\n" +
                   $"Restaurant Name: {RestaurantName}\n" +
                   $"Phone Number: {PhoneNumber}\n" +
                   $"Image URL: {ImageUrl}\n" +
                   $"Open Time: {OpenTime}\n" +
                   $"Close Time: {CloseTime}\n" +
                   $"Bank Account: {BankAccount}\n" +
                   $"Bank Number: {BankNumber}\n" +
                   $"Bank Name: {BankName}\n" +
                   $"Favorite Level: {FavoriteLevel}\n" +
                   $"Notes: {Notes}";
        }



    }
}
