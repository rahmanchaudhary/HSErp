using HSErp.Application;
using HSErp.Infrastructure;
namespace HSErp.Api
   
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            // Register API related services here
            services.AddApplicationDI();
            services.AddInfrastructureDI();
            return services;
        }
    }
}
