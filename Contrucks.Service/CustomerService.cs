using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Person> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }

        public void AddUser(Person person)
        {
            customerRepository.Add(person);
            unitOfWork.Commit();
        }
        public interface ICustomerService
        {
            IEnumerable<Person> GetAllCustomers();
            void AddUser(Person person);
        }

    }
}
