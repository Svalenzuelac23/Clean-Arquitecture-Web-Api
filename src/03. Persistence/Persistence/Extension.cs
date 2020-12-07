using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using Persistence.Repositories;

namespace Persistence
{
    public static class Extension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            //Add services to use in Persistence
            IConfiguration configuration;
            using (var serviceProvider = services.BuildServiceProvider())
            {
                configuration = serviceProvider.GetService<IConfiguration>();
            }

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("{your-conection-string}"));
            });

            //services.AddDbContext<ContextTest>(option =>
            //{
            //    option.UseSqlServer(configuration.GetConnectionString("ConnectionsString:Cn"));
            //});

            services.AddTransient<IPersonRepository, PersonRepository>();
            return services;
        }
    }
}
