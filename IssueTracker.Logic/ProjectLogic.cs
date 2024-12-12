using IssueTracker.Data;
using IssueTracker.Entities;
using IssueTracker.Entities.Dtos.Project;

namespace IssueTracker.Logic
{
    public class ProjectLogic
    {
        Repository<Project> repo;

        public ProjectLogic(Repository<Project> repo)
        {
            this.repo = repo;
        }

        public void AddProject(ProjectCreateDto dto)
        {
            Project p = new Project(dto.Name, dto.Description);
            repo.Create(p);
        }

    }
}
