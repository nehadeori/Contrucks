using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model.ViewModels
{
   public class ContractorsViewModel
    {
        public int PK_UserTableId { get; set; }
        public string ContractorName { get; set; }
        public int ContractorAge { get; set; }
        public int ContractorPhone { get; set; }
        public int PK_StateId { get; set; }
        public int PK_CityId { get; set; }
    }
}
