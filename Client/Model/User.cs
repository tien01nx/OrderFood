using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Model
{
    public class User : BaseModel
    {
      
        public int Id { get; set; }
        public  string UserName { get; set; }

        public  string Email { get; set; }

        public  string PhoneNumber { get; set; }

        public string FullName { get; set; }
        public string? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public  DateTimeOffset? LockoutEnd { get; set; }
        public string? Avatar { get; set; }
        public string? Address { get; set; }
        public string? ApartmentNumber { get; set; }

    }
}
