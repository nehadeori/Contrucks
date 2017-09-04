using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
    public class CustomerRepository : RepositoryBase<Person>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface ICustomerRepository : IRepositoryBase<Person>
    {

    }
}
