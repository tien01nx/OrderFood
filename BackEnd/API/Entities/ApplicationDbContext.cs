﻿using API.DTO;
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
        //public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Bank> Banks { get; set; }


        public DbSet<UserInfoDTO> UserCartDetails { get; set; }



        // Sử dụng PROC

        //// Lấy danh sách sản phẩm theo ngày hiện tại
        public List<Product> GetProductsByOrderDate(string date)
        {
            return Products.FromSqlRaw("EXEC sp_GetProductsByOrderDate {0}", date).ToList();
        }

        public List<UserInfoDTO> GetUserCartDetails(string startDate,string endDate, string userName,string restaurants, string productName)
        {
            startDate = string.IsNullOrEmpty(startDate) ? null : startDate;
            endDate = string.IsNullOrEmpty(endDate) ? null : endDate;
            userName = string.IsNullOrEmpty(userName) ? null : userName;
            restaurants = string.IsNullOrEmpty(restaurants) ? null : restaurants;
            productName = string.IsNullOrEmpty(productName) ? null : productName;
            return UserCartDetails.FromSqlRaw("EXEC sp_GetUserOrderDetails @p0, @p1, @p2, @p3, @p4", startDate,endDate, userName, restaurants, productName).ToList();
        }




        //// Lấy danh sách sản người dùng đã đặt đồ ăn hay chưa, theo ngày truyền vào và id người dùng
        //public List<UserInfoDTO> GetUserCartDetailsByDateAndUserId(string userId, string date)
        //{
        //    return UserCartDetails.FromSqlRaw("EXEC sp_GetUserCartDetails {0}, {1}", userId, date).ToList();
        //}

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
