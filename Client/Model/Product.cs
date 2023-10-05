using DevExpress.XtraEditors.Repository;

namespace Client.Model
{

    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string RestaurantName { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSelected { get; set; }

        public System.Drawing.Image Image { get; set; }


    }
}
