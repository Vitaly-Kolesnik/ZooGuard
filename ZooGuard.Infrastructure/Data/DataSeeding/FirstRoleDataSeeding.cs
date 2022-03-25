using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZooGuard.Infrastructure.Data.DataSeeding
{
    internal class FirstRoleDataSeeding
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder
            .HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
        }
    }
}
