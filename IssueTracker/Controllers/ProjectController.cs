using IssueTracker.Data;
using IssueTracker.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    public class ProjectCreateDto
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }


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
        public void AddProject(ProjectCreateDto dto)
        {
            var m = new Project(dto.Name, dto.Description);
            repo.Create(m);
        }
    }
}
