using CARCE.Application.Interfaces;
using CARCE.Infrastructure.Repositories;
using CARCE.Infrastructure.ThirdPartyApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace CARCE.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            var seccion= configuration.GetSection(DiscountApiSetting.SectionName);
            

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddSingleton<MyDbContext>();
            services.AddHttpClient<IDiscountService, DiscountService>(client =>
            {
                client.BaseAddress = new Uri(seccion[DiscountApiSetting.BaseApiUrl]);
                client.Timeout= TimeSpan.FromSeconds(10);
            });


            return services;
        }
    }
}