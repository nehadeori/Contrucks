using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
   public class RecentpostsRepository
    {
        public class RecentpostsRepository : RepositoryBase<Recentpost>, IRecentpostsRepository
        {
            public UserTablesRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
            {
            }
        }
        public interface IRecentpostsRepository : IRepositoryBase<UserTables>
        {
            IEnumerable<UserTables> GetAll();
            void Add(UserTables usertables);
        }

    }
}
