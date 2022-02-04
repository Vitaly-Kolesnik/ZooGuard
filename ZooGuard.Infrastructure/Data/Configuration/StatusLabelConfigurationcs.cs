using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class StatusLabelConfigurationcs : IEntityTypeConfiguration<StatusLabelPos>
    {
        public void Configure(EntityTypeBuilder<StatusLabelPos> builder)
        {
        }
    }
}
