using API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class ProductVM :ProductDto
    {
        public Image ImageProduct { get; set; }
    }
}
