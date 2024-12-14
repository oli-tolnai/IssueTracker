using IssueTracker.Entities.Dtos.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Entities.Dtos.Project
{
    public class ProjectViewDto
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public IEnumerable<IssueViewDto> Issues { get; set; }

        public int IssueCount => Issues?.Count() ?? 0;

        public int NumberOfNewIssues => Issues?.Count(i => i.Status == "New") ?? 0; //TODO: ki kell találni jobban
    }
}
