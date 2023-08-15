/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAPI.Data.Person
{
    internal class TerritoryConfiguration : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> modelBuilder)
        {
            modelBuilder.ToTable("Person", "StateProvince");
            modelBuilder
                .HasOne(territory => territory.RowGuid)
                .WithOne(person => person.RowGuid)
                .HasForeignKey<Territory>("BusinessEntityID");
        }
    }
}
*/