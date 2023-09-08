using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaBrowserTravel.AccesData;
using PruebaBrowserTravel.Business;

namespace PruebaBrowserTravel.Api
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPruebaBrowserTravelDependency(
            this IServiceCollection  services, IConfiguration configuration)
        {
            services.AddAccesDatas(configuration);
            services.AddBusiness();
            return services;
        }
    }
}
