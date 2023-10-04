using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Cart : BaseModel
    {

        // bao gồm thông tin sản phẩm, người dùng và số lượng sản phẩm người dùng mua 
        public int Id { get; set; }
        public int ProductId { get; set; }
       
        public int Count { get; set; }

        public int UserId { get; set; }
      

        [NotMapped]
        public double Price { get; set; }



        public int OrderId { get; set; }


    }
}

