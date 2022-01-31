using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Entites;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {

        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder
                .HasKey(p => new { p.UserId, p.RoleId });

            builder
                .HasOne(m => m.User)
                .WithMany(u => u.Members)
                .HasForeignKey(m => m.UserId);

            builder
                .HasOne(m => m.Role)
                .WithMany(r => r.Members)
                .HasForeignKey(m => m.RoleId);
        }
    }
}
