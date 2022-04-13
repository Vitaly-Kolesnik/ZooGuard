using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class WorkersInCompaniesConfiguration : IEntityTypeConfiguration<WorkersInCompany>
    {
        public void Configure (EntityTypeBuilder<WorkersInCompany> builder)
        {
            builder
                .HasKey(p => new { p.WorkerId, p.CompanyId });

            builder
                .HasOne(m => m.Worker)
                .WithMany(u => u.WorkersInCompanies)
                .HasForeignKey(m => m.WorkerId);

            builder
                .HasOne(m => m.Company)
                .WithMany(r => r.WorkersInCompanies)
                .HasForeignKey(m => m.CompanyId);
        }
    }
}
