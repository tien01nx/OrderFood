﻿
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class OrderDetail : BaseModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "UserId chưa có giá trị.")]
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public User User { get; set; }
        public string? OrderId { get; set; }
        [ForeignKey("OrderId")]
        [ValidateNever]
        public Order? Order { get; set; }

        [Required(ErrorMessage = "Product chưa có giá trị.")]
        public string? ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product? Product { get; set; }

        [Range(1, 100, ErrorMessage = "số lượng trong khoảng từ 1 đến 100.")]
        public int? Count { get; set; }

        public decimal? Price { get; set; }

        [NotMapped]
        public string? RestaurantId { get; set; }
    }
}
