using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
    public class TruckerDetail
    {
        [Key]
        public int PK_TruckId { get; set; }

        public int PK_TruckerId { get; set; }
        //[ForeignKey("FK_TruckerId")]
        public virtual Truckers Truckers { get; set; }

        public int PK_TruckTypeId { get; set; }
        //[ForeignKey("FK_TruckTypeId")]
        public virtual TruckTypes TruckType { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "Invalid Registration Number")]
        public string TruckNumber { get; set; }

        [Required, Range(1, 300)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid Values")]
        public decimal TruckMileage { get; set; }

        [Required, Range(1, 1000)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid Values")]
        public decimal MaximumWeightBearable { get; set; }

        [Required, Range(4, 20)]
        public int NumberOfWheels { get; set; }

        public DateTime TruckBoughtIn { get; set; }

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
