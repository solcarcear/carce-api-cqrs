using CARCE.Application.Interfaces;
using CARCE.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace CARCE.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddSingleton<MyDbContext>();
            return services;
        }
    }
}