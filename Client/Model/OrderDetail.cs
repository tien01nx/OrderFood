namespace Client.Model
{
    public class OrderDetail
    {

        public string Id { get; set; }

        public string OrderId { get; set; }

        public string ProductId { get; set; }

        public int UserId { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public string RestaurantId { get; set; }




    }
}
