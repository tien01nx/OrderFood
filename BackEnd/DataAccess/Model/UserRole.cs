using Microsoft.AspNetCore.Identity;

namespace DataAccess.Model;


public class UserRole : IdentityUserRole<int>
{
    public User User { get; set; }

    public Role Role { get; set; }

}
