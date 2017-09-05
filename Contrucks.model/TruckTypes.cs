using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class TruckTypes
    {
        [Key]
        public int PK_TruckTypeId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Trucktype { get; set; }
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