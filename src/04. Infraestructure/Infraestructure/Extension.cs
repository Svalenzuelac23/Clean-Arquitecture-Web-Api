using AutoMapper;
using Infraestructure.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class Extension
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            //Add services to use in Infraestructure        
            services.AddAutoMapper(config =>
            {
                config.AddProfile<MapperProfile>();
            });
            return services;
        }
    }
}
