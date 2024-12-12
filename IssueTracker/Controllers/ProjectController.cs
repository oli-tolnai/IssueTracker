using IssueTracker.Data;
using IssueTracker.Entities;
using IssueTracker.Entities.Dtos.Project;
using IssueTracker.Logic;
using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectLogic logic;

        public ProjectController(ProjectLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddProject(ProjectCreateDto dto)
        {
            logic.AddProject(dto);
        }

        [HttpGet]
        public IEnumerable<ProjectShortViewDto> GetAllProjects()
        {
            return logic.GetAllProjects();
        }

        [HttpDelete("{id}")]
        public void DeleteProject(string id)
        {
            logic.DeleteProject(id);
        }
    }
}
