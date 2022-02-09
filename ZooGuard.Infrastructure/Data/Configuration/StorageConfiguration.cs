using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class StorageConfiguration : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder
              .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.ActualAddress)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
