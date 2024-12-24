

namespace LeiaJa.Ioc.DI;
public static class DependecyInjection
{
    public static IServiceCollection AddInfrastrusture(this IServiceCollection services, IConfiguration configuration)
    {
        #region CONTROLLERS & APIEXPLORER
            services.AddControllers();
            services.AddEndpointsApiExplorer();
        #endregion

        #region DBCONTEXT
            var connectionSQLServer = configuration.GetConnectionString(InfrastructureConfiguration.DefaultSQLServer);
            services.AddDbContext<AppDbContext>(options =>{
                options.UseSqlServer(connectionSQLServer,
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
                );
            });
        #endregion

        #region REPOSITORY
            services.AddScoped<IAutorRepository, AutorRepository>();
        #endregion

        #region SERVICE
        #endregion

        return services;
    }
}
