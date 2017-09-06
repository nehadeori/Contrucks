using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class NewJobPosts
    {
        [Key]
        public int PK_JobId { get; set; }
        public int FK_ContractorId { get; set; }
        [ForeignKey("FK_ContractorId")]
        public virtual Contractors Contractor { get; set; }

        public int FK_LoadTypeId { get; set; }
        [ForeignKey("FK_LoadTypeId")]
        public virtual LoadTypes LoadType { get; set; }

        [Required]
        [Range(0,10000)]
        public int distance { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public int FK_TruckTypeId { get; set; }
        [ForeignKey("FK_TruckType")]
        public virtual TruckTypes TruckType { get; set; }

        [Required(ErrorMessage = "Please Mention a Title")]
        [MaxLength(255, ErrorMessage = "Word Limit Exceeded")]
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(3000, ErrorMessage = "Word Limit Exceeded")]
        public string JobDescription { get; set; }
        [Required(ErrorMessage = "Start date and time cannot be empty")]

        [DataType(DataType.DateTime)]
        public DateTime? JobStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? JobEndDate { get; set; }
        public DateTime? EstimatedTime { get; set; }
        [Required(ErrorMessage = "Please Mention a source Address")]
        [MaxLength(500, ErrorMessage = "Word Limit Exceeded")]
        public string SourceAddress { get; set; }
        [Required(ErrorMessage = "Please Mention a Destination Address")]
        [MaxLength(500, ErrorMessage = "Word Limit Exceeded")]
        public string DestinationAddress { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public int LoadWeight { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Budget { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? PostedDate { get; set; } = DateTime.Now;
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
