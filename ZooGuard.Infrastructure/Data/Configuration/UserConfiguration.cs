using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZooGuard.Core.Entities;

namespace ZooGuard.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            builder
                .Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired();
            
            builder
                .Property(x => x.Phone)
                .HasMaxLength(10)
                .IsRequired();

            builder
                .Property(x => x.Project)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Login)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasIndex(u => u.Login)
                .IsUnique();

            builder
                .Property(p => p.Password)
                .HasMaxLength(128)
                .IsFixedLength()
                .IsRequired();

            builder
                .Property(p => p.Salt)
                .HasMaxLength(128)
                .IsFixedLength()
                .IsRequired();
        }
    }
}
