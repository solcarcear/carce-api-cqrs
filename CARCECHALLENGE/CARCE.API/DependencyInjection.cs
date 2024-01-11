namespace CARCE.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            // Add services to the container.

            services.AddControllers();

            // Add swagger settings
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddLazyCache();
            return services;
        }
    }
}
