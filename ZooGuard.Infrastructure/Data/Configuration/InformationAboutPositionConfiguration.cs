using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class InformationAboutPositionConfiguration : IEntityTypeConfiguration<InformationAboutPosition>
    {
        public void Configure(EntityTypeBuilder<InformationAboutPosition> builder)
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
