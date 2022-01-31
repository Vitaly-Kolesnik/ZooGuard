using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entites.InfoAboutPos;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class StatusLabelConfigurationcs : IEntityTypeConfiguration<StatusLabelPos>
    {
        public void Configure(EntityTypeBuilder<StatusLabelPos> builder)
        {
        }
    }
}
