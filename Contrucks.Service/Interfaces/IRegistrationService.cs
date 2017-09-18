using Contrucks.model;
using Contrucks.model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Service.Interfaces
{
   public  interface IRegistrationService
    {
        IEnumerable<Contractors> GetAll();
        void AddData(ContractorsViewModel usertables);
       
    }
}
