namespace Client.Model
{
    public class Order : BaseModel
    {


        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string Description { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime ShoopingDate { get; set; }
        public double OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }







    }
}
