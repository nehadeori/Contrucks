using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class Ratings
    {
        [Key]
        public int PK_RatingId { get; set; }
        public int FK_ContractorId { get; set; }
        [ForeignKey("FK_ContractorId")]
        public Contractors Contractor { get; set; }
        public int FK_TruckerId { get; set; }
        [ForeignKey("FK_TruckerId")]
        public Truckers Trucker { get; set; }
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid Values")]
        public decimal Rating { get; set; }
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
