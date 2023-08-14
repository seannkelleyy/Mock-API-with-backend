using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockAPI.Domain;

namespace MockAPI.Data
{
    internal class PayHistoryConfiguration : IEntityTypeConfiguration<PayHistory>
    {
        public void Configure(EntityTypeBuilder<PayHistory> modelBuilder)
        {
            modelBuilder.ToTable("EmployeePayHistory", "HumanResources");
            modelBuilder
                .HasOne(departmentHistory => departmentHistory.BusinessEntity)
                .WithMany(businessEntity => businessEntity.PayHistories)
                .HasForeignKey("BusinessEntityID");
        }
    }
}