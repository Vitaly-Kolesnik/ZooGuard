using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class VenderConfiguration : IEntityTypeConfiguration<Vender>
    {
        public void Configure(EntityTypeBuilder<Vender> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            builder
                .Property(x => x.FirstNameRepresentative)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.LastNameRepresentative)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.PhoneRepresentative)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.PhoneRepresentative)
                .HasMaxLength(12)
                .IsRequired();

            builder
                .Property(x => x.EmailRepresentative)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
