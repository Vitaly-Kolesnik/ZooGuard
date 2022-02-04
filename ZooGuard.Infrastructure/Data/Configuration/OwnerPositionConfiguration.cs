using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class OwnerPositionConfiguration : IEntityTypeConfiguration<OwnerPosition>
    {
        public void Configure(EntityTypeBuilder<OwnerPosition> builder)
        {
        }
    }
}
