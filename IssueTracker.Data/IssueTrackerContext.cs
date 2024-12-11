using IssueTracker.Entities;
using Microsoft.EntityFrameworkCore;


namespace IssueTracker.Data
{
    public class IssueTrackerContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public IssueTrackerContext(DbContextOptions<IssueTrackerContext> ctx)
            :base(ctx)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Issues)
                .WithOne(i => i.Project)
                .HasForeignKey(i => i.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}
