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
        [Route("GetAll")]
        public IHttpActionResult GetAllData()
        {
            //var user = User.Identity.GetUserId();

            var authors = recentPostService.GetAllCustomers();
            return Ok(authors);

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
