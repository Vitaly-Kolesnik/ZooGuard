using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.PositionEntities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class PositionCategoryConfiguration : IEntityTypeConfiguration<PositionCategory>
    {
        public void Configure(EntityTypeBuilder<PositionCategory> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
               .Property(x => x.Description)
               .HasMaxLength(512)
               .IsRequired();
        }
    }
}
