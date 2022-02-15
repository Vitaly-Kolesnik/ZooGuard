using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities;

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
                .HasMaxLength(100)
                .IsRequired();
            
            builder
                .Property(x => x.FirstNameRepresentative)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.LastNameRepresentative)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.PhoneRepresentative)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.EmailRepresentative)
                .HasMaxLength(100)
                .IsRequired();

            builder
               .Property(x => x.MailingAddress)
               .HasMaxLength(100)
               .IsRequired();

            builder
               .Property(x => x.Comment)
               .HasMaxLength(500)
               .IsRequired();
        }
    }
}
