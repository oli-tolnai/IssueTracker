using IssueTracker.Entities.Dtos.Issue;
using IssueTracker.Logic.Logic;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        IssueLogic logic;

        public IssueController(IssueLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddIssue(IssueCreateDto dto)
        {
            logic.AddIssue(dto);
        }
    }
}
