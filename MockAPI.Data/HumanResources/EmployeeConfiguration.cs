using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockAPI.Domain;

namespace MockAPI.Data
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> modelBuilder)
        {
            modelBuilder.ToTable("Employee");
            modelBuilder
                .HasOne(employee => employee.BusinessEntity)
                .WithOne(businessEntity => businessEntity.Employee)
                .HasForeignKey("BusinessEntityId");
        }
    }
}