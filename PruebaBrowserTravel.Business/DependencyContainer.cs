using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaBrowserTravel.Business.Buisness;
using PruebaBrowserTravel.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBusiness(
            this IServiceCollection services)
        {
            services.AddTransient<IAutorBI, BIAutor>();
            services.AddTransient<IAutos_Has_LibroBI, BIAutos_Has_Libro>();
            services.AddTransient<ILibroBI, BILibro>();
            services.AddScoped<IEditorialBI, BIEditorial>();

            return services;
        }
    }
}
