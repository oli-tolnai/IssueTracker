using IssueTracker.Data;
using IssueTracker.Entities;

namespace IssueTracker.Logic
{
    public class ProjectLogic
    {
        Repository<Project> repo;

        public ProjectLogic(Repository<Project> repo)
        {
            this.repo = repo;
        }

        public void AddProject()
        {

        }

    }
}
