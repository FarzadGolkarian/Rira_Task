using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rira_Task.Application.Contracts.Persistence;
using Rira_Task.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rira_Task.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
    IConfiguration configuration)
        {
            services.AddDbContext<Rira_TaskDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("Rira_TaskConnectionString"));

            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IPersonRepository, PersonRepository>();

            return services;


        }
    }
}
