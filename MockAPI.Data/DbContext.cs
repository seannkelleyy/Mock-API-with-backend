using Microsoft.EntityFrameworkCore;
using MockAPI.Domain;

namespace SnackTrack.Data
{
    public class MockAPIContext : DbContext
    {
        public DbSet<DepartmentHistory> DepartmentHistories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobCandidate> JobCandidates { get; set; }
        public DbSet<PayHistory> PayHistories { get; set; }
        public DbSet<Person> People { get; set; }

        public MockAPIContext(DbContextOptions<MockAPIContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<DepartmentHistory>().ToTable("DepartmentHistories");
            modelBuilder.Entity<JobCandidate>().ToTable("JobCandidates");
            //modelBuilder.ApplyConfiguration(new SnackConfiguration());
        }
    }
}
