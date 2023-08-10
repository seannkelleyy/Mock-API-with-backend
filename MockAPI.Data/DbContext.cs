using Microsoft.EntityFrameworkCore;
using MockAPI.Data;
using MockAPI.Domain;

namespace SnackTrack.Data
{
    public class MockAPIContext : DbContext
    {
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
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
            modelBuilder.Entity<BusinessEntity>().ToTable("BusinessEntities");
            modelBuilder.ApplyConfiguration(new DepartmentHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new JobCandidateConfiguration());
            modelBuilder.ApplyConfiguration(new PayHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());



        }
    }
}
