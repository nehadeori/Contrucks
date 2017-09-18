using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Repository.Infrastructure;
using Contrucks.Repository.Repository;
using Contrucks.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Service
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository usertableRepository;
        //private readonly INewJobPostRepository newJobPostsRepository;
        private readonly IUnitOfWork unitOfWork;

        public RegistrationService(IRegistrationRepository usertableRepository, IUnitOfWork unitOfWork)
        {
            this.usertableRepository = usertableRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Contractors> GetAll()
        {
            return usertableRepository.GetAll();
        }




        public void AddData(ContractorsViewModel usertables)
        {
            //ConTruckContext context = new ConTruckContext();
            
            Contractors ct = new Contractors
           
            {
                ContractorName = usertables.ContractorFirstName,
                ContractorAge = usertables.ContractorAge,
                ContractorPhone = usertables.ContractorPhone,
             


            };

            usertableRepository.Add(ct);
            unitOfWork.Commit();

        }



    }
    }


