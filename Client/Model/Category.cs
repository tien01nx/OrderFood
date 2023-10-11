using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Category : BaseModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public string RestaurantId { get; set; }


        public string Descriptions { get; set; }

    }
}
