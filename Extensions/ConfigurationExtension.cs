using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yat.NetCore31.Spa.Contracts;
using Yat.NetCore31.Spa.Repository;

namespace Yat.NetCore31.Spa.Extensions
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
            // TODO: implement ConfigureIISIntegration()
            throw new NotImplementedException("This helper method is not implemented");
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            // TODO: implement ConfigureRepositoryWrapper()
            throw new NotImplementedException("This helper method is not implemented");
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            // TODO: implement ConfigureMySqlContext()
            throw new NotImplementedException("This helper method is not implemented");
        }
    }
}