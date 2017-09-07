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
    public class UserTablesRepository : RepositoryBase<UserTables>, IUserTablesRepository
    {
        public UserTablesRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }

        public void Add(UserTablesViewModel usertables)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserTablesViewModel> IUserTablesRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
    public interface IUserTablesRepository : IRepositoryBase<UserTables>
    {
        IEnumerable<UserTablesViewModel> GetAll();
        void Add(UserTablesViewModel usertables);
    }

}
