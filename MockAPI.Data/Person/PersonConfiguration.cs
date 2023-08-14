using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MockAPI.Domain;

namespace MockAPI.Data
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> modelBuilder)
        {
            modelBuilder.ToTable("Person", "Person");
            modelBuilder
                .HasOne(person => person.BusinessEntity)
                .WithOne(businessEntity => businessEntity.Person)
                .HasForeignKey<Person>("BusinessEntityID");
        }
    }
}