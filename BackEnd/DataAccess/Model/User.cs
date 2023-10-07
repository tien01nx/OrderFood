using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class User : IdentityUser<int>
    {


        public string FullName { get; set; }
        public string? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Avatar { get; set; }

        public string? Address { get; set; }
        public string? ApartmentNumber { get; set; }

        public string CreateBy { get; set; } = string.Empty;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }

        [ValidateNever]
        public List<Bank> Banks { get; set; }

        [NotMapped] public string? Role { get; set; }


        public ICollection<UserRole> UserRoles { get; set; }

        public List<Order> Orders { get; set; }

        public void onCreate()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public void onUpdate()
        {
            UpdateDate = DateTime.Now;
        }
    }
}