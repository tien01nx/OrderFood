using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Model
{
    public class User
    {
      
        public int Id { get; set; }
        public  string UserName { get; set; }

        public  string NormalizedUserName { get; set; }

        public  string Email { get; set; }

        public  string NormalizedEmail { get; set; }

        public  bool EmailConfirmed { get; set; }

        public  string PasswordHash { get; set; }

        public  string SecurityStamp { get; set; }

        public  string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        public  string PhoneNumber { get; set; }

        public  bool PhoneNumberConfirmed { get; set; }

        public  bool TwoFactorEnabled { get; set; }

        public  DateTimeOffset? LockoutEnd { get; set; }

        public  bool LockoutEnabled { get; set; }

        public  int AccessFailedCount { get; set; }
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
