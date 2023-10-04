using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class BaseModel
    {

        public string CreateBy { get; set; } = string.Empty;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }



        public void onCreate()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public void onUpdate()
        {
            UpdateDate = DateTime.Now;
        }


    }
}
