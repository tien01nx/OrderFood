using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Cart:BaseModel
    {

        // bao gồm thông tin sản phẩm, người dùng và số lượng sản phẩm người dùng mua 
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        public Product Product { get; set; }


        [Range(1, 1000, ErrorMessage = "Please enter a value between  1 and 1000")]
        public int Count { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]

        public User User { get; set; }

        [NotMapped]
        public double Price { get; set; }



        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        [ValidateNever]

        public Order Order { get; set; }




    }
}
