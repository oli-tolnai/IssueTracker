using IssueTracker.Entities.Dtos.Issue;
using IssueTracker.Entities.Dtos.Project;
using IssueTracker.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public void AddIssue(IssueCreateDto dto)
        {
            logic.AddIssue(dto);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void UpdateIssueStatus(string id, [FromBody] IssueStatusUpdateDto dto)
        {
            logic.UpdateIssueStatus(id, dto);
        }
    }
}
