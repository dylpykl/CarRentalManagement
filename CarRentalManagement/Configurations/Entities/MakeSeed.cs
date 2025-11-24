using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Configurations.Entities
{
    public class MakeSeed : IEntityTypeConfiguration<Make>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make { Id = 1, Name = "BMW", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Make { Id = 2, Name = "Toyota", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" }
            );
        }
    }
}
