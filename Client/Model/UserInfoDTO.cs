namespace Client.Model
{
    public class UserInfoDTO
    {
        public string OrderDetailID { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }

        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }

        public string ProductId { get; set; }


    }
}
