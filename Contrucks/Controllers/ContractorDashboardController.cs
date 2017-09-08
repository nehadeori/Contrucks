using Contrucks.model.ViewModels;
using Contrucks.Repository.Repository;
using Contrucks.Service;
using Contrucks.Service.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace Contrucks.Controllers
{
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
            //var user = User.Identity.GetUserId();

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


    }


}


