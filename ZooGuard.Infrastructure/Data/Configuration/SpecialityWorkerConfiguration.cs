using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class SpecialityWorkerConfiguration : IEntityTypeConfiguration<SpecialityWorker>
    {
        public void Configure(EntityTypeBuilder<SpecialityWorker> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}
