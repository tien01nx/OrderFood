using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public class Category : BaseModel
    {
        public int Id { get; set; }
        public string  Name { get; set; }

    }
}
