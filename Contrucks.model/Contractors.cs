using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
    public class Contractors
    {
        [Key]
        public int PK_ContractorId { get; set; }
        public int FK_UserTableId { get; set; }
        [ForeignKey("FK_UserTableId")]
        public virtual UserTables UserTables { get; set; }

        public int FK_StateId { get; set; }
        [ForeignKey("FK_StateId")]
        public virtual State State { get; set; }

        public int FK_CityId { get; set; }
        [ForeignKey("FK_CityId")]
        public virtual City City { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(255)]
        public string ContractorName { get; set; }

        [Required(ErrorMessage = "Valid Age is Required")]
        [Range(18, 120)]
        public int ContractorAge { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(15)]
        public int ContractorPhone { get; set; }

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
