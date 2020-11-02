using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YatVueApp.Repository;

namespace YatVueApp.Utilities
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
                {
                    options.AddPolicy("VueCorsPolicy", builder =>
                        builder.AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowCredentials()
                               .WithOrigins("http://localhost:8080"));
                });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => {});
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["DefaultMySqlConnection"];
            services.AddDbContext<RepositoryContext>(o =>
                o.UseMySql(connectionString));
        }
    }
}