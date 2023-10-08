using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Model
{
    public class BaseModel 
    {
        
        public string CreateBy { get; set; } = string.Empty;
        public string UpdateBy { get; set; } = string.Empty;
        [Column(TypeName = "Datetime")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Column(TypeName = "Datetime")]
        public DateTime? UpdateDate {   get; set; }



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
