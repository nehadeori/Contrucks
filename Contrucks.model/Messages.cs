using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
   public class Messages
    {
        public int PK_MessageId { get; set;}

         [ForeignKey("FK_JobApplicationId")]
         public JobApplications JobApplications { get; set; }
        public string SenderName { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
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
