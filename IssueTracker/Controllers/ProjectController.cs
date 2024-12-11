using IssueTracker.Data;
using IssueTracker.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        IssueTrackerContext ctx;
        public ProjectController(IssueTrackerContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpPost]
        public void AddProject(Project project)
        {
            ctx.Projects.Add(project);
            ctx.SaveChanges();
        }
    }
}
