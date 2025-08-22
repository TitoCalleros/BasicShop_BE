using BasicShopAPI.API.Mapping;
using BasicShopAPI.Infrastructure.Persistence;
using BasicShopAPI.Infrastructure.Repositories;
using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;

namespace BasicShopAPI
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var appAssembly = typeof(ProductsProfile).Assembly;

            services.AddAutoMapper(appAssembly);

            // Register all dependencies to classes whose name ends with "Handler"
            services.Scan(scan => scan
                .FromAssemblies(appAssembly)
                .AddClasses(c => c.Where(t => t.Name.EndsWith("Handler")))
                .AsSelf()
                .WithScopedLifetime());

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var cs = config.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(cs, sql => sql.UseCompatibilityLevel(120)));

            services.AddFluentMigratorCore()
                .ConfigureRunner(r => r.AddSqlServer2012()
                    .WithGlobalConnectionString(cs)
                    .ScanIn(typeof(ApplicationDbContext).Assembly).For.Migrations())
                .AddLogging(log => log.AddFluentMigratorConsole());

            // Inject all dependencies for Repositories
            services.Scan(scan => scan
                .FromAssemblyOf<ProductRepository>()
                .AddClasses(c => c.Where(t => t.Name.EndsWith("Repository")))
                .AsMatchingInterface()
                .WithScopedLifetime());

            return services;
        }

        public static IServiceCollection AddCorsPolicies(this IServiceCollection services, IConfiguration config)
        {
            var origins = config.GetSection("Cors:AllowedOrigins").Get<string[]>();

            services.AddCors(opt =>
            {
                // Política para desarrollo sin credenciales (simple)
                opt.AddPolicy("DevAll", p => p
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());

                //// Política con credenciales/orígenes explícitos
                //opt.AddPolicy("WithCreds", p =>
                //{
                //    if (origins is { Length: > 0 })
                //    {
                //        p.WithOrigins(origins)
                //         .AllowAnyHeader()
                //         .AllowAnyMethod()
                //         .AllowCredentials();
                //    }
                //});
            });

            return services;
        }
    }
}
