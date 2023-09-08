using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaBrowserTravel.AccesData.Data;
using PruebaBrowserTravel.AccesData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.AccesData
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAccesDatas(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextDBTravel>(

             options => options.UseSqlServer(configuration.GetConnectionString("ConnectionMain")));

            services.AddScoped<IAutor, AutorData>();
            services.AddScoped<IAutos_Has_Libro, Autos_Has_LibroData>();
            services.AddScoped<ILibro, LibroData>();
            services.AddScoped<IEditorial, EditorialData>();

            return services;
        }
    }
}
