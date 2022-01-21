using ZooGuard.Core.Interfaces;
using ZooGuad.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ZooGuard.Infrastructure;
using Microsoft.AspNetCore.Authentication.Cookies;
using ZooGuard.Infrastructure.Security;
using ZooGuard.Core.Services;
using Microsoft.AspNetCore.Http;

namespace ZooGuard.Web
{
    public class Startup //����� ������ ���������� c ����������� ���������
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //������������ ������������, ��� �� ��������� �������� ������ �� ����� ���������� 
        {
            // DbContext
            services.AddDbContext<PositionDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PositionDb")));  //����������� � ������� ����� appsettings.json

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            //Services
            IServiceCollection serviceCollection = services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();

            // MVC services
            services.AddControllersWithViews(); //��������� ������������ � �������������

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Index");
                    options.AccessDeniedPath = new PathString("/Account/Index");
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //������� �������������� ��, �� ������������ ��, ��� ���������� �������� �� �������
        {
            //app.UseStatusCodePagesWithReExecute("{controller=Home}/{action=Index}/{id?}"); //��������� ������ 404 � 500
            
            //��� ������������ ������, �������� �������� ���������� �� ������ ��������� ���������� ���� ����������, ��� ������ � ���� ������� ��� ���� ����� ���������� ��� �������� HTTPContext
            //����� ������� ����������� middleware+ ��� ��� ������� ���������� ���������������
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //�������� �� ������� ���������� ��� ������� � ������ ������������
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); //�������� �� ������� ���������� �� ������� � ������ ������������//������������� ����������//���� ����� ���������� -  ���������� �� �� �������� �� �����, � ��� ������ ��� ������� ���� ������� �� ���������� ��� 500. ��� ������� ���������, ��� ������������ ������� ������� HTML
                //������������� ������ �������� ������ ��� ����� �����, ��� �� � ������ ���� ������ ����� � ���������� UI �� ��������� ���������� ������ (����� ������� ����� �� �������� �� ���������� ������ 500 ������ ������������)
                //������������� ����� ���� ��������

            }
            app.UseHttpsRedirection(); //�������� �� ���������� ������ �������� HTTP ��������, ������ HTTPS

            app.UseStaticFiles(); //��������� �������� � ����������� ������, ����� ������ ��������� � ���������, �� ��������� ��������� �� ���� ������ � ������������� �����. �� - ���������� ����, ��� - ����������

            app.UseRouting(); //�������������, ��� ����� ���������

            app.UseAuthentication(); //�������� ����������

            app.UseAuthorization(); //�������� ����������

            app.UseEndpoints(endpoints => //�������� ������������� ������������ endpoints � �������� �������������
            {
                endpoints.MapControllerRoute( //�� ����� ����� �� �������� ������ �� �������� �� ����� �������� �������������� �� � �������� ����������, ���������� �� ��������� ������ ���������� ������
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); //� ����� ����� ����� �������������� Home ���������� ����� Index, ����������� ������ ��������� ��� ������ ����������� � �������������
                    //����� ������ ����������� (�����������) => �������� �����������. �������� ������ � ������� ���������!
            });
        }
    }
}
