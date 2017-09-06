using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model.ViewModels
{
  public   class NewJobPostViewModel
    {
        public string JobTitle { get; set; }
       
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string JobDescription { get; set; }

        public DateTime? EstimatedTime { get; set; }
       
        public string SourceAddress { get; set; }
       
        public string DestinationAddress { get; set; }
       
        public int LoadWeight { get; set; }
       
        public int Budget { get; set; }

        public int PK_LoadTypeId { get; set; }
        public int PK_TruckTypeId { get; set; }

    }
}
