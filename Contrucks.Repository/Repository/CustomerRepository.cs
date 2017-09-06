using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
    public class CustomerRepository : RepositoryBase<UserTables>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface ICustomerRepository : IRepositoryBase<UserTables>
    {
        IEnumerable<UserTables> GetAll();
        void Add(UserTables usertables);
    }

}
