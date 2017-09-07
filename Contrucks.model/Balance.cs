using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contrucks.model
{
    public class Balance
    {
        [Key]
        public int PK_BalanceId { get; set; }
        public int PK_UserTableId { get; set; }
       // [ForeignKey("FK_UserTableId ")]
        public UserTables UserTables { get; set; }

        [Required]
        public int Amount { get; set; }
        [Required]
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
