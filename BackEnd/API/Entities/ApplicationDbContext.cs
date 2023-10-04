using API.DTO;
using DataAccess.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int,
       IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
       IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        // Tạo bảng
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<UserInfoDTO> UserCartDetails { get; set; }



        // Sử dụng PROC

        //// Lấy danh sách sản người dùng đã đặt đồ ăn hay chưa, theo ngày truyền vào
        //public List<UserInfoDTO> GetUserCartDetails(string date,string userName,string title)
        //{
        //    return UserCartDetails.FromSqlRaw("EXEC sp_GetOrderUser {0},{1},{2}", date, userName, title).ToList();
        //}

        public List<UserInfoDTO> GetUserCartDetails(string date, string userName, string title)
        {
            date = string.IsNullOrEmpty(date) ? null : date;
            userName = string.IsNullOrEmpty(userName) ? null : userName;
            title = string.IsNullOrEmpty(title) ? null : title;

            return UserCartDetails.FromSqlRaw("EXEC sp_GetOrderUser @p0, @p1, @p2", date, userName, title).ToList();
        }




        // Lấy danh sách sản người dùng đã đặt đồ ăn hay chưa, theo ngày truyền vào và id người dùng
        public List<UserInfoDTO> GetUserCartDetailsByDateAndUserId(string userId, string date)
        {
            return UserCartDetails.FromSqlRaw("EXEC sp_GetUserCartDetails {0}, {1}", userId, date).ToList();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserInfoDTO>().HasNoKey();

            modelBuilder.Entity<User>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();


            modelBuilder.Entity<Role>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();



            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany()
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
