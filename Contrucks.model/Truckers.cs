using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
   public class Truckers
    {

        [Key]
        public int PK_TruckerId { get; set; }

        public int FK_UserTableId { get; set; }
        [ForeignKey("FK_UserTableId")]
        public virtual UserTables UserTable { get; set; }

        public int FK_StateId { get; set; }
        [ForeignKey("FK_StateId")]
        public virtual State State { get; set; }

        public int FK_CityId { get; set; }
        [ForeignKey("FK_CityId")]
        public virtual City City { get; set; }

        [Required(ErrorMessage = "Trucker's Name is Required")]
        [MaxLength(255, ErrorMessage = "Word limit Exceeded")]
        public string TruckerName { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [Range(18, 110)]
        public int TruckerAge { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(20, ErrorMessage = "Limit Exceeded")]

        public string TruckerLicensePlate { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(15, ErrorMessage = "Invalid Phone Number")]
        public string TruckerPhone { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
