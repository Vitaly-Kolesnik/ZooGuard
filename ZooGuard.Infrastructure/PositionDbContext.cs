using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.VenderEntities;
using ZooGuard.Core.Entities.WorkerEntities;
using ZooGuard.Infrastructure.Data.Configuration;
using ZooGuard.Infrastructure.Data.DataSeeding;

namespace ZooGuard.Infrastructure
{
    public class PositionDbContext : IdentityDbContext<IdentityUser>
    {
        #region DbSet Basic Entity
        public DbSet<Position> Positions { get; set; }
        public DbSet<Vender> Venders { get; set; }
        public DbSet<Storage> Storages { get; set; } 
        public DbSet<FormOfOccurence> FormOfOccurences { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ServerRoom> ServerRooms { get; set; } 
        public DbSet<SpecialityWorker> SpecialityWorkers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Broken> Brokens { get; set; }
        public DbSet<PositionCategory> PositionCategories { get; set; }
        #endregion

        #region DbSet Connections Entity For Many-To-Many Connection
        public DbSet<SpecialitiesOfWorkers> SpecialitiesOfWorkers { get; set; }
        public DbSet<WorkersInCompany> WorkersInCompany { get; set; }
        public DbSet<WorkersInProject> WorkersInProjects { get; set; }
        #endregion

        public PositionDbContext(DbContextOptions<PositionDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configure Basic Entity
            new PositionConfiguration().Configure(modelBuilder.Entity<Position>());
            new VenderConfiguration().Configure(modelBuilder.Entity<Vender>());
            new StorageConfiguration().Configure(modelBuilder.Entity<Storage>());
            new FormOfOccurenceConfiguration().Configure(modelBuilder.Entity<FormOfOccurence>());
            new CompanyConfiguration().Configure(modelBuilder.Entity<Company>());
            new PlaceConfiguration().Configure(modelBuilder.Entity<Place>());
            new ProjectConfiguration().Configure(modelBuilder.Entity<Project>());
            new ServerRoomConfiguration().Configure(modelBuilder.Entity<ServerRoom>());
            new SpecialityWorkerConfiguration().Configure(modelBuilder.Entity<SpecialityWorker>());
            new WorkerConfiguration().Configure(modelBuilder.Entity<Worker>());
            new PositionCategoryConfiguration().Configure(modelBuilder.Entity<PositionCategory>());
            new BrokenConfiguration().Configure(modelBuilder.Entity<Broken>());
            #endregion

            new SpecialitiesOfWorkersConfiguration().Configure(modelBuilder.Entity<SpecialitiesOfWorkers>());
            new WorkersInCompaniesConfiguration().Configure(modelBuilder.Entity<WorkersInCompany>());
            new WorkersInProjectConfiguration().Configure(modelBuilder.Entity<WorkersInProject>());

            #region SuperAdminDataSeeding
            base.OnModelCreating(modelBuilder);
            new FirstRoleDataSeeding().Configure(modelBuilder.Entity<IdentityRole>());
            new FirstUserDataSeeding().Configure(modelBuilder.Entity<IdentityUser>());
            new FirstIntegratorUserRoleDataSeeding().Configure(modelBuilder.Entity<IdentityUserRole<string>>());
            #endregion
        }
    }
}
