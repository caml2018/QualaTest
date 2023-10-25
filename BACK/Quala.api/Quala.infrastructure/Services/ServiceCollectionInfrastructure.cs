using Microsoft.Extensions.DependencyInjection;
using Quala.application.Interfaces;
using Quala.infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.infrastructure.Services
{
    public static class ServiceCollectionInfrastructure
    {
        public static IServiceCollection AddServiceCollectionInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISucursalRepository, SucursalRepository>();
            services.AddScoped<IMonedaRepository,MonedaRepository>();

            return services;
        }
    }
}
