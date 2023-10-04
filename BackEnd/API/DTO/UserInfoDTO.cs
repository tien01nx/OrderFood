namespace API.DTO
{
    public class UserInfoDTO
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }

        public int TotalQuantity { get; set; }
        public double TotalPrice { get; set; }


    }

}
