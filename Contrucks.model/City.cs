using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class City
    {
        [Key]
        public int PK_CityId { get; set; }
        public int PK_StateId { get; set; }
        //[ForeignKey("FK_StateId")]
       
        public string CityName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }


        public virtual State State { get; set; }
    }
}
