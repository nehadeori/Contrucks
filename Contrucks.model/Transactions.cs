using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
    public class Transactions
    {
        public int PK_TransactionId { get; set; }

        [ForeignKey("FK_ContractorId")]
        public Contractor Contractor { get; set; }

        [ForeignKey("FK_TruckerId")]
        public Trucker Trucker { get; set; }

        public string TransactionStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public virtual string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
