using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class Extension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            //Add services to use in Persistence
            return services;
        }
    }
}
