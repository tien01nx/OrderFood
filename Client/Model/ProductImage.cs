namespace Client.Model
{
    public class ProductImage : BaseModel
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        public int ProductId { get; set; }

    }
}
