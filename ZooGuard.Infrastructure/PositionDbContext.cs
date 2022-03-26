using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Infrastructure.Data.Configuration;
using ZooGuard.Infrastructure.Data.DataSeeding;

namespace ZooGuard.Infrastructure
{
    public class PositionDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Position> Positions { get; set; } //Entity позиции
        public DbSet<Vender> Venders { get; set; } //Entity поставщика
        public DbSet<Storage> Storages { get; set; } 
        public DbSet<StatusLabel> StatusLabels { get; set; }
        public DbSet<FormOfOccurence> FormOfOccurences { get; set; }

        public PositionDbContext(DbContextOptions<PositionDbContext> options) : base(options)
        { }

        public PositionDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PositionConfiguration().Configure(modelBuilder.Entity<Position>());
            new InformationAboutPositionConfiguration().Configure(modelBuilder.Entity<InformationAboutPosition>());
            new VenderConfiguration().Configure(modelBuilder.Entity<Vender>());
            new StorageConfiguration().Configure(modelBuilder.Entity<Storage>());
            new StatusLabelConfiguration().Configure(modelBuilder.Entity<StatusLabel>());
            new FormOfOccurenceConfiguration().Configure(modelBuilder.Entity<FormOfOccurence>());

            #region SuperAdminDataSeeding
            base.OnModelCreating(modelBuilder);
            new FirstRoleDataSeeding().Configure(modelBuilder.Entity<IdentityRole>());
            new FirstUserDataSeeding().Configure(modelBuilder.Entity<IdentityUser>());
            new FirstIntegratorUserRoleDataSeeding().Configure(modelBuilder.Entity<IdentityUserRole<string>>());
            #endregion
        }
    }
}
