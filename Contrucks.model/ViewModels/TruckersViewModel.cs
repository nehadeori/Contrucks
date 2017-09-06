using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model.ViewModels
{
   public class TruckersViewModel
    {
        public int PK_UserTableId { get; set; }
        public string TruckerName { get; set; }
        public int TruckerAge { get; set; }
        public string TruckerLicensePlate { get; set; }
        public string TruckerPhone { get; set; }
        public int PK_StateId { get; set; }
        public int PK_CityId { get; set; }
    }
}
