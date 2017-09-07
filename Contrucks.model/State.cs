using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class State
    {
        [Key]
        public int PK_StateId { get; set; }
        [Required]
        public string StateName { get; set; }
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
