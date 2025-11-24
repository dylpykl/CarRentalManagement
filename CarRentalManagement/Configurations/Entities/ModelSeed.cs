using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Configurations.Entities
{
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model { Id = 1, Name = "i4", ModelId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Model { Id = 2, Name = "X5", ModelId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Model { Id = 3, Name = "Prius", ModelId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Model { Id = 4, Name = "C-HR", ModelId = 4, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" }
            );
        }
    }
}
