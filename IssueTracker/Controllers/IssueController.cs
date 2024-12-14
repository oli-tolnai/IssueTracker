using IssueTracker.Entities.Dtos.Issue;
using IssueTracker.Entities.Dtos.Project;
using IssueTracker.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        IssueLogic logic;

        UserManager<IdentityUser> userManager;

        public IssueController(IssueLogic logic, UserManager<IdentityUser> userManager)
        {
            this.logic = logic;
            this.userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        public async Task AddIssue(IssueCreateDto dto)
        {
            var user = await userManager.GetUserAsync(User);

            logic.AddIssue(dto, user.Id);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void UpdateIssueStatus(string id, [FromBody] IssueStatusUpdateDto dto)
        {
            logic.UpdateIssueStatus(id, dto);
        }
    }
}
