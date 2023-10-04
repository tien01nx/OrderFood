using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DataAccess.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Utilis
{
    public class Seed
    {
        public static async Task SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (await userManager.Users.AnyAsync()) return;         

            var userData = await File.ReadAllTextAsync("C:\\Users\\tien0\\Downloads\\OrderFood\\DataAccess\\Utilis\\UserSeedData.json");
       
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var users = JsonSerializer.Deserialize<List<User>>(userData);
            var roles = new List<Role>
        {
            new Role { Name = SD.Role_User },
            new Role { Name = SD.Role_Admin },
            new Role { Name = SD.Role_Employee }
        };
            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }


            foreach (var user in users)
            {
                user.UserName = user.UserName.ToLower();

                await userManager.CreateAsync(user, "hihiHiuy092@");
                await userManager.AddToRoleAsync(user, SD.Role_User);
            }

            var admin = new User()
            {
                UserName = "Admin",
                FullName = "David Smith",
                Gender = "male",
                Birthday = DateTime.Now,
                Avatar = "https://example.com/avatar/davidsmith.jpg",
                PhoneNumber = "2222222222",
                CreateBy = "admin",
                UpdateBy = "admin",
                Address = "666 Oak St",
                ApartmentNumber = "E101"
            };

            await userManager.CreateAsync(admin, "Admin1234");
            await userManager.AddToRolesAsync(admin, new[] { SD.Role_Admin, SD.Role_Employee });
        }
    }
}