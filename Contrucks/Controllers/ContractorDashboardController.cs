using Contrucks.model;
using Contrucks.model.ViewModels;
using Contrucks.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Contrucks.Controllers
{
    public class ContractorDashboardController : ApiController
    {
        RecentJobPostService recentPostService;
        public ContractorDashboardController()
        {

        }
        public ContractorDashboardController(RecentJobPostService rec)
        {
            recentPostService = rec;
        }
        // GET: /Details/

        [Route("api/ContractorDashboard/GetAllData")]
        public IHttpActionResult GetAllData()
        {
            //var user = User.Identity.GetUserId();

            var authors = recentPostService.GetAll();
            return Ok(authors);

        }

        //Post
        [Route("api/ContractorDashboard/SetData")]
        public async Task<IHttpActionResult> SetData(RecentpostViewmodel recentVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            NewJobPosts nw = new NewJobPosts
            {
                JobTitle = recentVM.JobTitle,
                JobStartDate = recentVM.JobStartDate,
                JobEndDate = recentVM.JobEndDate,
                JobDescription = recentVM.JobDescription,
                EstimatedTime = recentVM.EstimatedTime,
                SourceAddress = recentVM.SourceAddress,
                DestinationAddress = recentVM.DestinationAddress,
                distance = recentVM.distance,
                LoadWeight = recentVM.LoadWeight,
                Budget = recentVM.Budget,
                PK_LoadTypeId = recentVM.PK_LoadTypeId,
                PK_TruckTypeId = recentVM.PK_TruckTypeId
                
            };
            
            if(nw== null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            recentPostService.AddData(nw);
            return Ok();
        }


    }


}
//// GET api/Account/UserInfo
//[HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
//[Route("UserInfo")]
//public UserInfoViewModel GetUserInfo()
//{
//    ExternalLoginData externalLogin = ExternalLoginData.FromIdentity(User.Identity as ClaimsIdentity);

//    return new UserInfoViewModel
//    {
//        Email = User.Identity.GetUserName(),
//        HasRegistered = externalLogin == null,
//        LoginProvider = externalLogin != null ? externalLogin.LoginProvider : null
//    };
//}



//IList<RecentpostViewmodel> posts = null;

//using (var ctx = new SchoolDBEntities())
//{
//    posts = recentPostService..Include("StudentAddress").Select(s => new StudentViewModel()
//    {
//        Id = s.StudentID,
//        FirstName = s.FirstName,
//        LastName = s.LastName,
//        Address = s.StudentAddress == null || includeAddress == false ? null : new AddressViewModel()
//        {
//            StudentId = s.StudentAddress.StudentID,
//            Address1 = s.StudentAddress.Address1,
//            Address2 = s.StudentAddress.Address2,
//            City = s.StudentAddress.City,
//            State = s.StudentAddress.State
//        }
//    }).ToList<StudentViewModel>();
//}
