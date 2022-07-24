using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using N5.Challenge.Application.Interfaces;
using N5.Challenge.Persistence.Context;
using N5.Challenge.Persistence.Repositories;

namespace N5.Challenge.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
         
               services.AddDbContext<DatabaseDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                   b => b.MigrationsAssembly(typeof(DatabaseDbContext).Assembly.FullName)));

            #region Repositories
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddTransient<IPermissionRepository, PermissionRepository>();
            services.AddTransient<IPermissionTypeRepository, PermissionTypeRepository>();
            #endregion
        }
    }
}
