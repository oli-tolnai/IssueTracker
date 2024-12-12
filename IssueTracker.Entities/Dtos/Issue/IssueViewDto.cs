using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Entities.Dtos.Issue
{
    public class IssueViewDto
    {
        public string Type { get; set; } = "";
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public int Priority { get; set; }
        public string Status { get; set; } = "";
    }
}
