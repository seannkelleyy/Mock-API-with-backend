using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockAPI.Domain;

namespace MockAPI.Data
{
    internal class JobCandidateConfiguration : IEntityTypeConfiguration<JobCandidate>
    {
        public void Configure(EntityTypeBuilder<JobCandidate> modelBuilder)
        {
            modelBuilder.ToTable("HumanResources.JobCandidate");
            modelBuilder
                .HasOne(jobCandidate => jobCandidate.BusinessEntity)
                .WithOne(businessEntity => businessEntity.JobCandidate)
                .HasForeignKey<JobCandidate>("BusinessEntityID");
        }
    }
}