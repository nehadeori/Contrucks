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

        public IEnumerable<Recentpostviewmodel> GetAllCustomers()
        {
            return usertableRepository.GetAll();
        }

        public void AddUser(Recentpostviewmodel usertables)
        {
            usertableRepository.Add(usertables);
            unitOfWork.Commit();
        }

     

        IEnumerable<Recentpostviewmodel> IRecentJobPostService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public interface IRecentJobPostService
        {
            IEnumerable<Recentpostviewmodel> GetAllCustomers();
            void AddUser(Recentpostviewmodel usertables);
        }

    }
