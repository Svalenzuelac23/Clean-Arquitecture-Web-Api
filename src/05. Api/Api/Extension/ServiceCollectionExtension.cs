using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Api.Extension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCustomController(this IServiceCollection services)
        {
            services.AddControllers()
               .AddFluentValidation(options =>
               {
                   options.RegisterValidatorsFromAssembly(Assembly.Load("Infraestructure"));
               });
            return services;
        }
    }
}
