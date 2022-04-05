using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Entities.MultipleConnections;
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
        public DbSet<StatusLabel> StatusLabels { get; set; }
        public DbSet<FormOfOccurence> FormOfOccurences { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ServerRoom> ServerRooms { get; set; } 
        public DbSet<SpecialityWorker> SpecialityWorkers { get; set; }
        public DbSet<Worker> Workers { get; set; }

        public DbSet<PositionCategory> PositionCategories { get; set; }
        #endregion

        #region DbSet Connections Entity For Many-To-Many Connection
        public DbSet<SpecialitiesOfWorkers> SpecialitiesOfWorkers { get; set; }
        public DbSet<WorkersInOrganisation> WorkersInOrganisations { get; set; }
        public DbSet<WorkersInProject> WorkersInProjects { get; set; }
        #endregion

        public PositionDbContext(DbContextOptions<PositionDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configure Basic Entity
            new PositionConfiguration().Configure(modelBuilder.Entity<Position>());
            new InformationAboutPositionConfiguration().Configure(modelBuilder.Entity<InformationAboutPosition>());
            new VenderConfiguration().Configure(modelBuilder.Entity<Vender>());
            new StorageConfiguration().Configure(modelBuilder.Entity<Storage>());
            new StatusLabelConfiguration().Configure(modelBuilder.Entity<StatusLabel>());
            new FormOfOccurenceConfiguration().Configure(modelBuilder.Entity<FormOfOccurence>());
            new OrganisationConfiguration().Configure(modelBuilder.Entity<Organisation>());
            new PlaceConfiguration().Configure(modelBuilder.Entity<Place>());
            new ProjectConfiguration().Configure(modelBuilder.Entity<Project>());
            new ServerRoomConfiguration().Configure(modelBuilder.Entity<ServerRoom>());
            new SpecialityWorkerConfiguration().Configure(modelBuilder.Entity<SpecialityWorker>());
            new WorkerConfiguration().Configure(modelBuilder.Entity<Worker>());
            new PositionCategoryConfiguration().Configure(modelBuilder.Entity<PositionCategory>());
            #endregion

            new SpecialitiesOfWorkersConfiguration().Configure(modelBuilder.Entity<SpecialitiesOfWorkers>());
            new WorkersInOrganisationConfiguration().Configure(modelBuilder.Entity<WorkersInOrganisation>());
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
