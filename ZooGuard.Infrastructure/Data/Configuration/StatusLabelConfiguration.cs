using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class StatusLabelConfiguration : IEntityTypeConfiguration<StatusLabel>
    {
        public void Configure(EntityTypeBuilder<StatusLabel> builder)
        {
        }
    }
}
