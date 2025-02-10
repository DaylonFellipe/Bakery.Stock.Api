using Daylon.Bakery.Stock.Domain.Repositories;
using Daylon.Bakery.Stock.Domain.Repositories.Product;
using Daylon.Bakery.Stock.Infrastructure.DataAccess;
using Daylon.Bakery.Stock.Infrastructure.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Daylon.Bakery.Stock.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddRepositories(services);
            AddDbContext_SqlServer(services, configuration);
        }

        public static void AddDbContext_SqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BakeryDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}

