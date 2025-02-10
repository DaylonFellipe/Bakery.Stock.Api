using Daylon.Bakery.Stock.Application.Services.AutoMapper;
using Daylon.Bakery.Stock.Application.UseCases.Product.Register;
using Daylon.Bakery.Stock.Domain.Repositories;
using Daylon.Bakery.Stock.Domain.Repositories.Product;
using Daylon.Bakery.Stock.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Daylon.Bakery.Stock.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            AddAutoMapper(services);
            AddUserCases(services);
        }
        private static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddScoped(option => new AutoMapper.MapperConfiguration(options =>
            {
                options.AddProfile(new AutoMapping());
            }).CreateMapper());
        }

        private static void AddUserCases(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRegisterProductUseCase, RegisterProductUseCase>();
        }
    }
}
