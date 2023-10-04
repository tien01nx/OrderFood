namespace Client.Model
{
    public class OrderDetail
    {

        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public int? Count { get; set; }

    }
}
