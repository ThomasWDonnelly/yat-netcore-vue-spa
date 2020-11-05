using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VueCliMiddleware;
using Yat.NetCore31.Spa.Extensions;

namespace Yat.NetCore31.Spa
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
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.ConfigureMySqlContext(Configuration);
            services.ConfigureRepositoryWrapper();

            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.UseSpaStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                    spa.UseVueCli(npmScript: "serve", port: 8080);
            });
        }
    }
}
