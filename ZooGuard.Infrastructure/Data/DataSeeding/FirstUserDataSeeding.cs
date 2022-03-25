using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZooGuard.Infrastructure.Data.DataSeeding
{
    internal class FirstUserDataSeeding : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder
                .HasData(new IdentityUser
                {
                    Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "my@email.com",
                    NormalizedEmail = "MY@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                    SecurityStamp = string.Empty
                });
        }
    }
}
