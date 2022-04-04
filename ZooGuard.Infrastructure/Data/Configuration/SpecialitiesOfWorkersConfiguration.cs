using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class SpecialitiesOfWorkersConfiguration : IEntityTypeConfiguration<SpecialitiesOfWorkers>
    {
        public void Configure(EntityTypeBuilder<SpecialitiesOfWorkers> builder)
        {
            builder
                .HasKey(p => new { p.SpecialityWorkerId, p.WorkerId });

            builder
                .HasOne(m => m.SpecialityWorker)
                .WithMany(u => u.SpecialitiesOfWorkers)
                .HasForeignKey(m => m.SpecialityWorkerId);

            builder
                .HasOne(m => m.Worker)
                .WithMany(r => r.SpecialitiesOfWorkers)
                .HasForeignKey(m => m.WorkerId);
        }
    }
}
