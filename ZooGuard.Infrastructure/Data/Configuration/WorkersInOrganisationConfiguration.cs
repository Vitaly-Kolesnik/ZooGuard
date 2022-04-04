using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class WorkersInOrganisationConfiguration : IEntityTypeConfiguration<WorkersInOrganisation>
    {
        public void Configure (EntityTypeBuilder<WorkersInOrganisation> builder)
        {
            builder
                .HasKey(p => new { p.WorkerId, p.OrganisationId });

            builder
                .HasOne(m => m.Worker)
                .WithMany(u => u.WorkersInOrganisations)
                .HasForeignKey(m => m.WorkerId);

            builder
                .HasOne(m => m.Organisation)
                .WithMany(r => r.WorkersInOrganisations)
                .HasForeignKey(m => m.OrganisationId);
        }
    }
}
