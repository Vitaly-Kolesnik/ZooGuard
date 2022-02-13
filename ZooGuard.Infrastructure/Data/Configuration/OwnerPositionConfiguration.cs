using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entits;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class OwnerPositionConfiguration : IEntityTypeConfiguration<OwnerPosition>
    {
        public void Configure(EntityTypeBuilder<OwnerPosition> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
