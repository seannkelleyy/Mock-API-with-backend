using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockAPI.Domain;

namespace MockAPI.Data
{
    internal class DepartmentHistoryConfiguration : IEntityTypeConfiguration<DepartmentHistory>
    {
        public void Configure(EntityTypeBuilder<DepartmentHistory> modelBuilder)
        {
            modelBuilder.ToTable("DeparmentHistory");
            modelBuilder
                .HasOne(departmentHistory => departmentHistory.BusinessEntity)
                .WithMany(businessEntity => businessEntity.DepartmentHistories)
                .HasForeignKey("BusinessEntityID");
        }
    }
}