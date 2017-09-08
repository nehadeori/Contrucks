using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using Contrucks.Service.Interfaces;
using System.Collections.Generic;

namespace Contrucks.Service
{
    public class RecentJobPostService : IRecentJobPostService
    {
        private readonly IRecentpostsRepository usertableRepository;
        private readonly IUnitOfWork unitOfWork;

        public RecentJobPostService(IRecentpostsRepository usertableRepository, IUnitOfWork unitOfWork)
        {
            this.usertableRepository = usertableRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<RecentpostViewmodel> GetAll()
        {
            return usertableRepository.GetAll();
        }

        public void AddData(RecentpostViewmodel usertables)
        {
            //usertableRepository.Add(usertables);
            ConTruckContext context = new ConTruckContext();
            NewJobPosts njp = new NewJobPosts
            {
                Budget = usertables.Budget,

                
            }; 
            unitOfWork.Commit();
        }

       
    }
}