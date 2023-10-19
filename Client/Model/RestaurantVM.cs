namespace Client.Model
{
    public class RestaurantVM : Restaurant
    {
        public RestaurantVM()
        {
        }

        public RestaurantVM(Restaurant restaurant)
        {
            this.Id = restaurant.Id;
            this.RestaurantName = restaurant.RestaurantName;
            this.PhoneNumber = restaurant.PhoneNumber;
            this.ImageUrl = restaurant.ImageUrl;
            this.OpenTime = restaurant.OpenTime;
            this.CloseTime = restaurant.CloseTime;
            this.BankAccount = restaurant.BankAccount;
            this.BankNumber = restaurant.BankNumber;
            this.BankName = restaurant.BankName;
            this.FavoriteLevel = restaurant.FavoriteLevel;
            this.Notes = restaurant.Notes;
            this.Image = restaurant.Image;
        }

        public Image Image { get; set; }


    }
}
