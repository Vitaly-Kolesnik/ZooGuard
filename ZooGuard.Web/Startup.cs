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
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Services;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Web
{
    public class Startup //вызов класса происходит c приминением рефлексии
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //регистрирует завистимости, что бы правельно вызывать классы во время выполнения 
        {
            // DbContext
            services.AddDbContext<PositionDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PositionDb")));  //Подключение к серверу через appsettings.json

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>)); //typeof получает экземпляр System.Type для указанного типа на этапе компиляции (рефлексия), так как классы находяся в разных проектах

            // Регистрация зависимостей Services
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IVenderService, VenderService>();
            services.AddScoped<IStorageService, StorageService>();
            services.AddScoped(typeof(IPositionInformationService<StatusLabelPos>), typeof(PositionInformationService<StatusLabelPos>));

            // регистрация зависимостей ViewModelServices
            services.AddScoped<IUserViewModelService, UserViewModelService>();
            services.AddScoped<IVenderViewModelService, VenderViewModelService>();
            services.AddScoped<IStorageViewModelService, StorageViewModelService>();
            services.AddScoped<IStatusViewModelService, StatusViewModelService> ();

            // ModelServices
            services.AddScoped<IRoleModelService, RoleModelService>();

            // MVC services
            services.AddControllersWithViews(); //Поддержка контроллеров и представлений

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Index");
                    options.AccessDeniedPath = new PathString("/Account/Index");
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //Конвеер промежуточного ПО, он контролирует то, как приложение отвечает на запросы
        {
            app.UseStatusCodePagesWithReExecute("{controller=Home}/{action=Index}/{id?}"); //обработка ошибок 404 и 500
            
            //Все используемые методы, являются методами расширения их классы реализуют интерфейсы типа параметров, под коотом у этих методов еще один метод расширения для передачи HTTPContext
            //Важен порядок регистрации middleware+ так как команды вызываются последовательно
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //Отвечает за возврат информации обо ошибках в режиме разработчика
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); //Отвечает за возврат информации об ошибках в режиме Пользователя//перехватывает исключение//если ловит исключение -  отправляет их по конвееру по новой, и как только они пройдут весь конвеер им присвоится код 500. Это говорит программе, что пользователь получит удобный HTML
                //рекомендовано делать страницы ошибок как можно проще, что бы в случае если ошибка будет в загружамом UI не отключить обработчик ошибок (после первого круга по конвееру он пропускает ошибку 500 наружу пользователю)
                //рекомендовано иметь стат страницу

            }
            app.UseHttpsRedirection(); //Отвечает за обратботку только надежных HTTP запросов, тоесть HTTPS

            app.UseStaticFiles(); //обработка запросов к статическим файлам, когда запрос поступает в компонент, он проверяет относится ли этот запрос к существующему файлу. Да - возвращает файл, Нет - игнорирует

            app.UseRouting(); //Маршрутизация. Установление компонента маршрутизации endpoints

            app.UseAuthentication(); //проверка валидности

            app.UseAuthorization(); //проверка валидности

            app.UseEndpoints(endpoints => //компонет маршрутизации используются endpoints и выбирает представление (регистрация), по факту здесь мы регистрируем правило маршрутизации
            {
                endpoints.MapControllerRoute( //По факту когда мы получаем запрос он проходил по всему конвееру промежуточного ПО и вызывает контроллер, контроллер на основании модели возвращает вьюшку (выбор конечной точки)
                    name: "default", 
                    pattern: "{controller=Position}/{action=Index}/{id?}"); //В корне сайта будет использоваться Home контроллер метод Index, регистрация списка паттернов для вызова контролеера и представлений
                                                                        //После выбора обработчика (контроллера) => создание контроллера. Привязка модели с помощью атрибутов!
                                                                        //Регистрация конечных точек
                //ASP.NET Core может привязывать в Razor Pages:
                //aгументы метода – если у обработчика страницы есть аргументы етода, значения из запроса используются для создания необходимых параметров;
                //свойства, отмеченные атрибутом[BindProperty],  – любые свойства, отмеченные этим атрибутом, будет привязаны. По умолчанию
            });
        }
    }
}
