using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model
{
    public class JobApplications
    {
        public int PK_JobApplicationId { get; set; }
        [ForeignKey("FK_TruckerId")]
        public Trucker Trucker { get; set; }

        [ForeignKey("FK_JobId")]
        public NewJobPosts NewJobPosts { get; set; }
        public string CoverLetter { get; set; }
        public int AskingPrice { get; set; }
        public DateTime TimeRequired { get; set; }
        public string JobApplicationStatus { get; set; }
        public bool IsJobAwarded { get; set; }
        public virtual string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
