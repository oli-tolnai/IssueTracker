using IssueTracker.Entities.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IssueTracker.Entities
{
    public class Issue : IIdEntity
    {
        public Issue(string projectId, string title, string description, string status, int priority, string type)
        {
            Id = Guid.NewGuid().ToString();
            ProjectId = projectId;
            Title = title;
            Description = description;
            Status = status;
            Priority = priority;
            Type = type;
            //CreatedDate = createdDate;
            //ResolvedDate = resolvedDate;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string ProjectId { get; set; }

        [StringLength(50)]
        public string Title { get; set; } // e.g. "CART - Unable to add new item to the cart"

        [StringLength(400)]
        public string Description { get; set; } // e.g. "When I click the 'Add to Cart' button, nothing happens."

        [StringLength(20)]
        public string Status { get; set; } // e.g. "Open", "In Progress", "Resolved"

        [Range(1, 3)]
        public int Priority { get; set; } // 1 = "Low", 2 = "Medium", 3 = "High"

        [StringLength(20)]
        public string Type { get; set; } // e.g. "Bug", "Feature", "Improvement", "Task"

        //public DateTime CreatedDate { get; set; }

        //public DateTime ResolvedDate { get; set; }

        [NotMapped]
        public virtual Project? Project { get; set; }
    }
}
