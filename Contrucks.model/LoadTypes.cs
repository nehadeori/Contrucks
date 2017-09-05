using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class LoadTypes
    {
        [Key]
        public int PK_LoadTypeId { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(255, ErrorMessage = "Word limit Exceeded")]
        public string LoadType { get; set; }
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