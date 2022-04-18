using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class WorkersInProjectConfiguration : IEntityTypeConfiguration<WorkersInProject>
    {
        public void Configure(EntityTypeBuilder<WorkersInProject> builder)
        {
            builder
                .HasKey(p => new { p.WorkerId, p.ProjectId });

            builder
                .HasOne(m => m.Worker)
                .WithMany(u => u.WorkersInProjects)
                .HasForeignKey(m => m.WorkerId);

            builder
                .HasOne(m => m.Project)
                .WithMany(r => r.WorkersInProjects)
                .HasForeignKey(m => m.ProjectId);
        }
    }
}
