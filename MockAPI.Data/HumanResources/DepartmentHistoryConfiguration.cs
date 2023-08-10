using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockAPI.Domain;
namespace MockAPI.Data
{
    internal class DepartmentHistory : IEntityTypeConfiguration<DepartmentHistory>
    {
        public void Configure(EntityTypeBuilder<DepartmentHistory> modelBuilder)
        {
            modelBuilder.ToTable("DeparmentHistories");
            modelBuilder
                .HasOne(departmentHistory => departmentHistory.BusinessEntityID)
                .WithMany(snack => snack.Purchases)
                .HasForeignKey("SnackId");
        }
    }
}