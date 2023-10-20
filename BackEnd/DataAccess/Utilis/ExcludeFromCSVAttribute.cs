using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utilis
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ExcludeFromCSVAttribute : Attribute { }
}
