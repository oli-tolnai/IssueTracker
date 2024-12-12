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

        public void AddProject(ProjectCreateUpdateDto dto)
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

        public IEnumerable<ProjectShortViewDto> GetAllProjects()
        {
            return repo.GetAll().Select(x =>
                new ProjectShortViewDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                });
        }

        public void DeleteProject(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateProject(string id, ProjectCreateUpdateDto dto)
        {
            Project oldp = repo.FindById(id);
            oldp.Name = dto.Name;
            oldp.Description = dto.Description;
            repo.Update(oldp);
        }
    }
}
