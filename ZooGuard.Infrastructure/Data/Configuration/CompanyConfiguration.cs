using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.TeamEntities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(x => x.OrgForm)
                .HasMaxLength(5)
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.UNP)
                .HasMaxLength(9)
                .IsRequired();

            builder
                .Property(x => x.Adress)
                .HasMaxLength(512)
                .IsRequired();
        }
    }
}
