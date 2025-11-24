using CarRentalManagement.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour { Id = 1, Name = "Black", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Colour { Id = 2, Name = "Blue", DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" }
            );
        }
    }
}
