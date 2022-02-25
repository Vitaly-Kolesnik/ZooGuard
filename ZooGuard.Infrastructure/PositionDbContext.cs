using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Infrastructure.Data.Configuration;

namespace ZooGuard.Infrastructure
{
    public class PositionDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; } //DbContext для миграций
        public DbSet<User> Users { get; set; } //DbContext для юзеров
        public DbSet<Member> Members { get; set; } //класс связывающий Roles and User
        public DbSet<Position> Positions { get; set; } //Entity позиции
        public DbSet<Vender> Venders { get; set; } //Entity поставщика
        public DbSet<Storage> Storages { get; set; } 
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
            new InformationAboutPositionConfiguration().Configure(modelBuilder.Entity<InformationAboutPosition>());
            new VenderConfiguration().Configure(modelBuilder.Entity<Vender>());
            new StorageConfiguration().Configure(modelBuilder.Entity<Storage>());
            new StatusLabelConfiguration().Configure(modelBuilder.Entity<StatusLabel>());
            new FormOfOccurenceConfiguration().Configure(modelBuilder.Entity<FormOfOccurence>());
        }
    }
}
