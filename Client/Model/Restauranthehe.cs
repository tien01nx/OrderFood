﻿namespace Client.Model
{
    public class Restaurant : BaseModel
    {
        public string Id { get; set; }
        public string RestaurantName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }

        // số tài khoản

        public int BankAccount { get; set; }

        // chủ tài khoản
        public string BankNumber { get; set; }

        // tên ngân hàng
        public string BankName { get; set; }
        public byte FavoriteLevel { get; set; }
        public string Notes { get; set; }

        public Image Image { get; set; }

        public void GenerateRandomId()
        {
            RandomString randomStringGenerator = new RandomString();
            Id = "Res" + randomStringGenerator.NextString(10); // Độ dài của ID
        }
        public override string ToString()
        {
            return $"Restaurant ID: {Id}\n" +
                   $"Restaurant Name: {RestaurantName}\n" +
                   $"Phone Number: {PhoneNumber}\n" +
                   $"Image URL: {ImageUrl}\n" +
                   $"Open Time: {OpenTime}\n" +
                   $"Close Time: {CloseTime}\n" +
                   $"Bank Account: {BankAccount}\n" +
                   $"Bank Number: {BankNumber}\n" +
                   $"Bank Name: {BankName}\n" +
                   $"Favorite Level: {FavoriteLevel}\n" +
                   $"Notes: {Notes}";
        }
    }
}