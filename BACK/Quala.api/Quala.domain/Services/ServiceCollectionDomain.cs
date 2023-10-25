using Microsoft.Extensions.DependencyInjection;
using Quala.domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.domain.Services
{
    public static class ServiceCollectionDomain
    {
        public static IServiceCollection AddServiceCollectionDomain(this IServiceCollection services)
        {
            services.AddScoped<Sucursal>();
            services.AddScoped<Monedum>();

            return services;
        }
    }
}
