using AutoMapper;
using PruebaBrowserTravel.DTO;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EditorialDto,Editorial >();
            CreateMap<AutorDto, Autor>();
            CreateMap<LibroDto, Libro>();
            CreateMap<Autor_has_libroDto, Autor_has_libro>(); 
        }
       
    }
}
