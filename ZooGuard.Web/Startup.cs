using ZooGuard.Core.Interfaces;
using ZooGuad.Infrastructure.Data.Repositories;
using ZooGuard.Infrastructure;
using ZooGuard.Core.Services;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ZooGuard.Web.Filters;
using ZooGuard.Infrastructure.Data.UnitOfWork;
using ZooGuard.Core.Interfaces.ForPosition;
using ZooGuard.Core.Interfaces.InterfacesForVenderServicies;
using ZooGuard.Core.Services.PositionServices;
using ZooGuard.Core.Services.WorkerServices;
using ZooGuard.Core.Services.VenderServices;
using ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Core.Services.TeamServices;
using ZooGuard.Web.Interfaces.InterfacesForTeamViewModelServices;
using ZooGuard.Web.Interfaces.InterfacesForCompanyViewModelServices;

namespace ZooGuard.Web
{
    public class Startup 
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PositionDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PositionDb")));

            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<PositionDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompotAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); }); 
            });

            #region EfRepository
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            #endregion

            #region UnitOfWork
            services.AddScoped <IUnitOfWork,UnitOfWork>();
            #endregion

            #region PositionServicies
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IPositionCategoryService, PositionCategoryService>();
            #endregion

            #region WorkerServicies
            services.AddScoped<IWorkerService, WorkerService>();
            services.AddScoped<ISpecialityWorkerService, SpecialityWorkerService>();
            #endregion

            #region VenderServicies
            services.AddScoped<IVenderService, VenderService>();
            services.AddScoped<IFormOfOccurenceService, FormOfOccurenceService>();
            #endregion

            #region TeamServicies
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IProjectService, ProjectService>();
            #endregion

            #region BrokenService
            services.AddScoped<IBrokenService, BrokenService>();
            #endregion

            #region StoragiesServicesGen
            services.AddScoped(typeof(IAllStorageService<>), typeof(AllStorageService<>));
            #endregion

            //ViewModelServices
            services.AddScoped<IUserViewModelService, UserViewModelService>();
            services.AddScoped<IVenderViewModelService, VenderViewModelService>();
            services.AddScoped<IPositionViewModelService, PositionViewModelService>();
            services.AddScoped<IProjectViewModelService, ProjectViewModelService>();
            services.AddScoped<ICompanyViewModelService, CompanyViewModelService>();
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("admin", "AdminArea"));
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); 

            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "admin",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
