using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using System;
using System.Collections.Generic;

namespace Contrucks.Service
{
    public class RecentJobPostService : RecentJobPostService.IRecentJobPostService
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

        public void AddUser(RecentpostViewmodel usertables)
        {
            usertableRepository.Add(usertables);
            unitOfWork.Commit();
        }



        IEnumerable<RecentpostViewmodel> IRecentJobPostService.GetAll()
        {
            throw new NotImplementedException();
        }

        public interface IRecentJobPostService
        {
            IEnumerable<RecentpostViewmodel> GetAll();
            void AddUser(RecentpostViewmodel usertables);
        }

    }
}