using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class Transactions
    {
        [Key]
        public int PK_TransactionId { get; set; }
        public int PK_ContractorId { get; set; }
        //[ForeignKey("FK_ContractorId")]
        public virtual Contractors Contractor { get; set; }
        public int PK_TruckerId { get; set; }
        //[ForeignKey("FK_TruckerId")]
        public virtual Truckers Trucker { get; set; }
        [MaxLength(15)]
        public string TransactionStatus { get; set; }
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
