using DataAccess.Model;

namespace Client.Model
{
    public class Order : BaseModel
    {


        public string Id { get; set; }
        public string RestaurantName { get; set; }
        public string Description { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime ShoopingDate { get; set; }
        public double OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }



        public Restaurant Restaurant { get; set; }






    }
}
