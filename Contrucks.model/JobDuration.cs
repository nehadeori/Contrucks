using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class JobDuration
    {
        [Key]
        public int PK_JobDurationId { get; set; }
        public int PK_ContractorId { get; set; }
      //  [ForeignKey("FK_ContractorId")]
        public Contractors Contractor { get; set; }
        public DateTime JobStartTime { get; set; }
        public DateTime JobStopTime { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        [MaxLength(255)]
        public virtual string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        [MaxLength(255)]
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}
