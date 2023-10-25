using Microsoft.Extensions.DependencyInjection;
using Quala.application.Commands.SucursalC;
using Quala.application.Queries.MonedaQ;
using Quala.application.Queries.SucursalQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quala.application.Services
{
    public static class ServiceCollectionApplication
    {
        public static IServiceCollection AddServiceCollectionApplication(this IServiceCollection services)
        {
            services.AddScoped<ISucursalQuery, SucursalQuery>();
            services.AddScoped<ISucursalWrite,SucursalWrite>();
            services.AddScoped<IMonedaQuery, MonedaQuery>();

            return services;
        }
    }
}
