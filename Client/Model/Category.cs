namespace Client.Model
{
    public class Category : BaseModel
    {

        public string Id { get; set; }


        public string RestaurantId { get; set; }

        public string CategoryName { get; set; }


        public string Descriptions { get; set; }
        public void GenerateRandomId()
        {
            RandomString randomStringGenerator = new RandomString();
            Id = "CA" + randomStringGenerator.NextString(10); // Độ dài của ID
        }
    }
}
