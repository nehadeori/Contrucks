using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddUser(UserTables usertables)
        {
            usertableRepository.Add(usertables);
            unitOfWork.Commit();
        }

        IEnumerable<UserTables> IRecentpostsRepository.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserTables> IRecentJobPostService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public interface IRecentJobPostService
        {
            IEnumerable<UserTables> GetAllCustomers();
            void AddUser(UserTables usertables);
        }

    }
