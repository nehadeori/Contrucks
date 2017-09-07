using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using System;
using System.Collections.Generic;

namespace Contrucks.Service
{
    public class UserTablesService : UserTablesService.IUserTablesService
    {
        private readonly IUserTablesRepository usertableRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserTablesService(IUserTablesRepository usertableRepository, IUnitOfWork unitOfWork)
        {
            this.usertableRepository = usertableRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<UserTablesViewModel> GetAllCustomers()
        {
            return usertableRepository.GetAll();
        }

        public void AddUser(UserTablesViewModel usertables)
        {
            usertableRepository.Add(usertables);
            unitOfWork.Commit();
        }



        IEnumerable<UserTablesViewModel> IUserTablesService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public interface IUserTablesService
        {
            IEnumerable<UserTablesViewModel> GetAllCustomers();
            void AddUser(UserTablesViewModel usertables);
        }
    }
}
