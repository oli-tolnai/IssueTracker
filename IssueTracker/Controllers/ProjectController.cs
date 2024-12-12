using IssueTracker.Data;
using IssueTracker.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        Repository<Project> repo;

        public ProjectController(Repository<Project> repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public void AddProject(Project project)
        {
            repo.Create(project);
        }
    }
}
