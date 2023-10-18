using System.ComponentModel.DataAnnotations.Schema;

namespace Client.Model
{
    public class Cart : BaseModel
    {

        // bao gồm thông tin sản phẩm, người dùng và số lượng sản phẩm người dùng mua 
        public string Id { get; set; }
        public string ProductId { get; set; }

        public int Count { get; set; }

        public string UserId { get; set; }


        [NotMapped]
        public decimal Price { get; set; }



        public string OrderId { get; set; }


    }
}

