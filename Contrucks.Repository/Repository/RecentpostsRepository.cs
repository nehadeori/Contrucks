using Contrucks.model;
using Contrucks.Repository.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace Contrucks.Repository.Repository
{

    public class RecentpostsRepository : RepositoryBase<NewJobPosts>, IRecentpostsRepository
        {
            public RecentpostsRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
            {
            }
        public NewJobPosts GetAllById(int Id)
        {    
            return FindBy(x => x.ContractorId == Id).FirstOrDefault();
        }
        
    }
        public interface IRecentpostsRepository : IRepositoryBase<NewJobPosts>
        {
            IEnumerable<NewJobPosts> GetAll();
            void Add(NewJobPosts usertables);
            NewJobPosts GetAllById(int Id);
           
    }

    }

