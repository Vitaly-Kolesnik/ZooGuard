using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entits;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.Date)
                .HasMaxLength(10)
                .IsRequired();

            builder
                .Property(x => x.RegistrationDocument)
                .HasMaxLength(256)
                .IsRequired();

            builder
                .Property(x => x.AccountingNumber)
                .HasMaxLength(10)
                .IsRequired();

            builder
                .Property(x => x.RealityFlag)
                .HasMaxLength(1)
                .IsRequired();

            builder
                .Property(x => x.Information)
                .HasMaxLength(256)
                .IsRequired();

            builder
                .Property(x => x.IdOwnerPosition)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.NameOwnerPosition)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.IdFormOfOccurence)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.NameFormOfOccurence)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.IdUser)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.IdStatusLabel)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(x => x.NameStatusLabel)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
