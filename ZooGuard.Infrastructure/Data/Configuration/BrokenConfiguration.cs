using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class BrokenConfiguration : IEntityTypeConfiguration<Broken>
    {
        public void Configure(EntityTypeBuilder<Broken> builder)
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

            builder
                .Property(x => x.DateStart)
                .IsRequired();

            builder
                .Property(x => x.DateEnd)
                .IsRequired();
        }
    }
}
