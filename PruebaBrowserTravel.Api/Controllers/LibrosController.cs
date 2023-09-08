using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaBrowserTravel.Business.Interfaces;
using PruebaBrowserTravel.DTO;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaBrowserTravel.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        readonly IMapper Mapper;
        readonly ILibroBI BILibros;
        public LibrosController(ILibroBI biLibro,IMapper mapper)
        {
            BILibros = biLibro;
            Mapper = mapper;
        }
        ///<summary>
        /// Obtiene todos los libros 
        ///</summary>        
        [ResponseType(typeof(ActionResult<List<Libro>>))]
        [HttpGet("{id}")]
        public async Task<List<Libro>> GetList(long id)
        {
            return await BILibros.GetList( id);
        }

        ///<summary>
        /// Obtiene un libro por el Id 
        ///</summary>        
        //[ResponseType(typeof(ActionResult<Libro>))]
        [HttpGet("{id}")]
        public async Task<Libro> Get(int id)
        {
            return await BILibros.Get(id);
        }

        ///<summary>
        /// Crea un nuevo libro
        ///</summary>        
        [ResponseType(typeof(LibroDto))]
        [HttpPost]
        public async Task<ActionResult<Libro>> Post(LibroDto libroDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var libro = Mapper.Map<Libro>(libroDto);
            return await BILibros.Post(libro);
        }

        ///<summary>
        /// Actualiza un  libro
        ///</summary>        
        [ResponseType(typeof(ActionResult<Libro>))]
        [HttpPut]
        public async Task<ActionResult<Libro>> Update(LibroDto libroDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var libro = Mapper.Map<Libro>(libroDto);
            return await BILibros.Update(libro);
        }
    }
}
