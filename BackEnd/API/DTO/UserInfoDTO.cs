namespace API.DTO
{
    public class UserInfoDTO
    {

        public int Id { get; set; }
        public int ProductId { get; set; }

        public string UserName { get; set; }
        public string Title { get; set; }

        public int TotalQuantity { get; set; }
        public double TotalPrice { get; set; }


    }

}
