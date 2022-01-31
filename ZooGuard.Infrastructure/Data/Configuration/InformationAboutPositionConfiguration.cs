using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entites.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class InformationAboutPositionConfiguration : IEntityTypeConfiguration<_InformationAboutPosition>
    {
        public void Configure(EntityTypeBuilder<_InformationAboutPosition> builder)
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
