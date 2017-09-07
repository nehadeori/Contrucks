using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class Messages
    {
        [Key]
        public int PK_MessageId { get; set; }
        public int PK_JobApplicationId { get; set; }
       // [ForeignKey("FK_JobApplicationId")]
        public JobApplications JobApplications { get; set; }
        [Required]
        [MaxLength(255)]
        public string SenderName { get; set; }
        [MaxLength(300)]
        public string MessageSubject { get; set; }
        [MaxLength(3000)]
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        [MaxLength(255)]
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}
