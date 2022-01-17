using BusinessLogic;
using Contracts;
using Core;
using Core.Models;
using GenericRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Controllers.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureDataSource01Context(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<DataSource01Context>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("DatabaseConnection01")
                )
            );

        public static void ConfigureDataSource02Context(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<DataSource02Context>(opts =>
                opts.UseSqlServer(configuration.GetConnectionString("DatabaseConnection02")
                )
            );

        public static void ConfigureRepoManager(this IServiceCollection services) =>
           services.AddScoped<IRepoManager, RepoManager>();

        public static void ConfigureBusinessLogic(this IServiceCollection services) =>
           services.AddScoped<IProductLogic, ProductLogic>();

    }
}
