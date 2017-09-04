using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Contrucks.Controllers
{
    public class CustomerController : ApiController
    {
      
            private readonly ICustomerService customerRepository;

            public CustomerController(ICustomerService userRepo)
            {
                this.customerRepository = userRepo;
            }

            [HttpGet]
            public IEnumerable<Person> Get()
            {
                try
                {
                    return customerRepository.GetAllCustomers();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }
    }
}
