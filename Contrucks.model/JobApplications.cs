using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class JobApplications
    {
        [Key]
        public int PK_JobApplicationId { get; set; }
        [ForeignKey("FK_TruckerId")]
        public int FK_TruckerId { get; set; }    
        public virtual Truckers Truckers { get; set; }
        public int PK_JobId { get; set; }
       // [ForeignKey("FK_JobId")]
        public virtual NewJobPosts NewJobPosts { get; set; }




        [Required(ErrorMessage = "This Field is required")]

        public DateTime TimeRequired { get; set; }

        public string JobApplicationStatus { get; set; }
        public bool IsJobAwarded { get; set; }

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
