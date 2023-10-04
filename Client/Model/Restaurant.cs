using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Restaurant : BaseModel
    {

        public int Id { get; set; }
        public string RestaurantName { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public DateTime OpenTime { get; set; }

        public DateTime CloseTime { get; set; }

        public int UserId { get; set; }
       

    }
}
