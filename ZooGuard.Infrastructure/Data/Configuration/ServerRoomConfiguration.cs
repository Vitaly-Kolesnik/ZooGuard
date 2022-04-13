using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.StorageEntities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class ServerRoomConfiguration : IEntityTypeConfiguration<ServerRoom>
    {
        public void Configure(EntityTypeBuilder<ServerRoom> builder)
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

            builder
                .Property(x => x.Characteristic)
                .HasMaxLength(10000)
                .IsRequired();
        }
    }
}
