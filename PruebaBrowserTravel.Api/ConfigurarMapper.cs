using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Api
{
    public class ConfigurarMapper
    {
        public static IMapper ConfiguraMapper()
        {
            var mapperConfug = new MapperConfiguration(x => {
                x.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfug.CreateMapper();
            return mapper;
        }
    }
}
