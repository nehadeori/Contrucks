using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
    public class TruckersRepository : RepositoryBase<Truckers>, ITruckersRepository
    {
        public TruckersRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface ITruckersRepository : IRepositoryBase<Truckers>
    {
        IEnumerable<Truckers> GetAll();
        void Add(Truckers truckers);
    }
}
