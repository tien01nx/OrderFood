﻿namespace Client.Model
{

    public class Product : BaseModel
    {

        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }

        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public string RestaurantId { get; set; }
        public int Quantity { get; set; }




        public Image Image { get; set; }

        public bool IsSelected { get; set; }
      
        public string OrderId { get; set; }


        public Image ImageProduct { get; set; }

    }
}
