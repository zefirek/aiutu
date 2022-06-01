using aiutu.Models;
using aiutu.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aiutu.Domain.Interfaces;
using aiutu.Infrastructure.Repositories;
using aiutu.Application;
using FluentValidation.AspNetCore;
using FluentValidation;
using aiutu.Application.ViewModels.Kontrahent;
using Microsoft.Extensions.Logging;

namespace aiutu
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>();

            // asp 8.7 14:30
            // ADDTRANSIENT - za ka¿dym razem, przy ka¿dym u¿yciu podawany jest nowa instancja obiektu
            //services.AddTransient<IKontrahentRepository, KontrahentRepository>();
            // ADDSCOPED - obiekt tworzony jest jeden raz na ¿¹danie 
            //services.AddScoped<IKontrahentRepository, KontrahentRepository>(); 
            // ADDSINGLETON - raz wywo³ane posiada ca³y czas t¹ sam¹ formê - nigdy siê nie zmieni w czasie uruchomienia
            // nie u¿ywaæ
            //services.AddSingleton<IKontrahentRepository, KontrahentRepository>();
            // asp 8.7 15:30 
            //services.AddTransient<IKontrahentRepository, KontrahentRepository>();
            //services.AddTransient<IPojazdRepository, PojazdRepository>();

            // asp 8.7 18:00
            services.AddApplication();
            services.AddInfrastructure();

            services.AddControllersWithViews().AddFluentValidation();
            // asp 8.12 11:00
            //services.AddControllersWithViews().AddFluentValidation(fv => fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false);

            // validacja dodawania kontrahentów
            services.AddTransient<IValidator<NewKontrahentVm>, NewKontrahentValidation>();


            services.AddRazorPages();

            //services.AddDatabaseDeveloperPageExceptionFilter();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            // asp 8.16 6:00
            // œcie¿ka do pliku z logami
            //loggerFactory.AddFile("Logs/myLog-{Date}.txt");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
