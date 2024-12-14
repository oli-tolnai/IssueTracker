using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public void Register()
        {
            //var user = new IdentityUser("geza");


        }
    }
}
