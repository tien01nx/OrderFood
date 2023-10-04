using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class Bank :BaseModel
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string ImageUrl { get; set; }


        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public User User { get; set; }
    }
}
