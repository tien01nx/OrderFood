using Microsoft.AspNetCore.Identity;

namespace DataAccess.Model;

  public class Role:IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
