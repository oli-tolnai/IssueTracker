using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Entities
{
    public class Project
    {
        public Project(string name, string description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [NotMapped]
        public virtual ICollection<Issue>? Issues { get; set; }

    }
}
