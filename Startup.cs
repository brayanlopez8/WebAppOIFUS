
using BLL.Implememtation;
using BLL.Interface;
using DAL;
using DAL.Contract;
using DAL.DBContext;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Practices.Unity;

namespace WebApplicationOIFUS
{
    public class Startup
    {
        private static UnityContainer unityContainer = new UnityContainer();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            RegistrarUnity();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<MyDBContext>();
            services.AddScoped<DbContext, MyDBContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IPersonBLL, PersonBLL>();
            services.AddTransient<ICountryBLL, CountryBLL>();
            services.AddTransient<INotificaciones, NotificacionesBLL>();
            services.AddTransient<IPersonaBLL, PersonasBLL>();
            services.AddTransient(typeof(ITablaTipoBLL<>), typeof(TablaTipoBLL<>));
            services.AddTransient<IUsuarioBLL, UsuarioBLL>();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                                            .AddCookie(options =>
                                            {
                                                options.LoginPath = "/Login";
                                            });

            var section = Configuration.GetSection("ConnectionStrings");
            services.Configure<MyConfig>(section);

        }
        private static void RegistrarUnity()
        {
            unityContainer.RegisterType<IPersonBLL, PersonBLL>();
            unityContainer.RegisterType<ICountryBLL, CountryBLL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Inicio}/{id?}");
            });
        }
    }
}
