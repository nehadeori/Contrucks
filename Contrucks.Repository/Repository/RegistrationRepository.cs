using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
    public class RegistrationRepository : RepositoryBase<Contractors>, IRegistrationRepository
    {
        public RegistrationRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

        public void Add(ContractorsViewModel usertables)
        {
            throw new NotImplementedException();
        }

       
    }
    public interface IRegistrationRepository : IRepositoryBase<Contractors>
    {
        IEnumerable<Contractors> GetAll();
        void Add(Contractors usertables);
    }

}
