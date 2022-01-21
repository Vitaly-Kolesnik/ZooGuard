using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entits.StatusLabel;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class StatusLabelConfigurationcs : IEntityTypeConfiguration<StatusLabel>
    {
        public void Configure(EntityTypeBuilder<StatusLabel> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.IdStorage)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(x => x.NameStorage)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
