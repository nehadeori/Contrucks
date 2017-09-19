using Contrucks.model.ViewModels;
using Contrucks.Service.Interfaces;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Contrucks.Controllers
{
    [EnableCors("*","*", "*")]
    public class ContractorDashboardController : ApiController
    {
        
        IRecentJobPostService recentPostService;
        public ContractorDashboardController()
        {

        }
        public ContractorDashboardController(IRecentJobPostService rec)
        {
            recentPostService = rec;
        }
        // GET: /Details/

        [Route("api/ContractorDashboard/GetAllData")]
        public IHttpActionResult GetAllData()
        {
          

            var authors = recentPostService.GetAll();
            return Ok(authors);

        }

        //Post
        [Route("api/ContractorDashboard/SetData")] 
        public IHttpActionResult SetData(RecentpostViewmodel recentVM)
        {
            recentPostService.AddData(recentVM);
            return Ok();
        }


        //Get recently added job posts
        [Route("api/ContractorDashboard/RecentJobPosts")]
        public IHttpActionResult GetRecentJobPosts(int Id)
        {
            var result= recentPostService.GetAllById(Id);
           return Ok(result);
        }

        [Route("api/ContractorDashboard/GetAllFulfilledPostsData")]
        public IHttpActionResult GetFulfilledPostsData()
        {
            var data = recentPostService.GetFulfilledPostsData();
            return Ok(data);
        }
    }


}


