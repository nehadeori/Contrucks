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

        public IEnumerable<NewJobPosts> GetAll()
        {
            return usertableRepository.GetAll();
        }

        public void AddData(RecentpostViewmodel usertables)
        {
            //ConTruckContext context = new ConTruckContext();
            NewJobPosts njp = new NewJobPosts
            {
                distance = usertables.distance,
                JobTitle = usertables.JobTitle,
                JobDescription = usertables.JobDescription,
                JobStartDate = usertables.JobStartDate,
                JobEndDate = usertables.JobEndDate,
                EstimatedTime = usertables.EstimatedTime,
                SourceAddress = usertables.SourceAddress,
                DestinationAddress = usertables.DestinationAddress,
                LoadWeight = usertables.LoadWeight,
                Budget = usertables.Budget
            };
            usertableRepository.Add(njp);
            unitOfWork.Commit();
        }

       
    }
}