using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Repository
{
  
        public class RecentpostsRepository : RepositoryBase<Recentpostviewmodel>, IRecentpostsRepository
        {
            public RecentpostsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
            {
            }
        }
        public interface IRecentpostsRepository : IRepositoryBase<Recentpostviewmodel>
        {
            IEnumerable<Recentpostviewmodel> GetAll();
            void Add(Recentpostviewmodel usertables);
        }

    }

