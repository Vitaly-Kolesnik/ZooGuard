using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure (EntityTypeBuilder<Worker> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.Patronymic)
                .HasMaxLength(100);

            builder
                .Property(x => x.Patronymic)
                .HasMaxLength(100);

            builder
                .Property(x => x.IsResponsibilityStorage)
                .IsRequired();

            builder
                .Property(x => x.IsResponsibilityServerRoom)
                .IsRequired();

            builder
                .HasOne(a => a.Place)
                .WithOne(b => b.Worker)
                .HasForeignKey<Place>(b => b.WorkerForeignKey);
        }
    }
}
