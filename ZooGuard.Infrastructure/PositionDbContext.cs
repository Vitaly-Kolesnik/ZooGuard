using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Entits;
using ZooGuard.Core.Entits.StatusLabel;
using ZooGuard.Infrastructure.Data.Configuration;

namespace ZooGuard.Infrastructure
{
    public class PositionDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; } //DbContext для миграций
        public DbSet<User> Users { get; set; } //DbContext для юзеров
        public DbSet<Member> Members {get; set;}
        public DbSet<Position> Positions { get; set; } //Entity позиции
        public DbSet<OwnerPosition> OwnerPositions { get; set; } //Entity поставщика
        public DbSet<Storage> Storages { get; set; } //
        public DbSet<StatusLabel> StatusLabels { get; set; }
        public DbSet<FormOfOccurence> FormOfOccurences { get; set; }

        public PositionDbContext(DbContextOptions<PositionDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration()); //создание моделей конфигураций классов DbContext для создания миграций

            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
            new MemberConfiguration().Configure(modelBuilder.Entity<Member>());
            new PositionConfiguration().Configure(modelBuilder.Entity<Position>());
            new OwnerPositionConfiguration().Configure(modelBuilder.Entity<OwnerPosition>());
            new StorageConfiguration().Configure(modelBuilder.Entity<Storage>());
            new StatusLabelConfigurationcs().Configure(modelBuilder.Entity<StatusLabel>());
            new FormOfOccurenceConfiguration().Configure(modelBuilder.Entity<FormOfOccurence>());
        }
    }
}
