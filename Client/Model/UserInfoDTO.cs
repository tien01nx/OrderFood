﻿namespace Client.Model
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }

        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }

        public int ProductId { get; set; }


    }
}
