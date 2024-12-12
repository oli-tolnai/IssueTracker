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
            if (repo.GetAll().FirstOrDefault(p => p.Name == dto.Name) == null)
            {
                repo.Create(p);
            }
            else
            {
                throw new System.Exception("Project with this name already exists");
            }
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return repo.GetAll();
        }

    }
}
