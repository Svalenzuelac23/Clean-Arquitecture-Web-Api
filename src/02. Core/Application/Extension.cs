using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class Extension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //Add services to use in Application
            services.AddMediatR(Assembly.Load("Application"));
            return services;
        }
    }
}
