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
    public class ContractorsRepository : RepositoryBase<ContractorsViewModel>, IContractorsRepository
    {
        public ContractorsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

        public void Add(Contractors contractors)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Contractors> IContractorsRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
    public interface IContractorsRepository : IRepositoryBase<Contractors>
    {
        IEnumerable<Contractors> GetAll();
        void Add(Contractors contractors);
    }
}
