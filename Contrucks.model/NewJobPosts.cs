using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
    public class NewJobPosts
    {
        public int PK_JobId { get; set; }
        [ForeignKey("FK_ContractorId")]
        public Contractor Contractor { get; set; }
        public virtual string JobTitle {get;set;}
        public virtual string JobDescription { get; set; }

        public DateTime JobStartDate  { get; set; }
        public DateTime EstimatedTime { get; set; }
        public virtual string SourceAddress { get; set; }
        public virtual string DestinationAddress { get; set; }
        [ForeignKey("FK_LoadTypeId")]
        public LoadType LoadType { get; set; }
        public virtual string TruckType { get; set; }
        public int LoadWeight { get; set; }
        public int Budget { get; set; }
        public DateTime PostedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }

    }
}
