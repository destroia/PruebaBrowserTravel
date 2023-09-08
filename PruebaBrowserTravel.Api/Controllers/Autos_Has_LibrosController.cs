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
    public class Autos_Has_LibrosController : ControllerBase
    {
        readonly IAutos_Has_LibroBI BIAutos_Has_Libros;
        readonly IMapper Mapper;
        public Autos_Has_LibrosController(IAutos_Has_LibroBI biAutos_Has_Libros,IMapper mapper)
        {
            BIAutos_Has_Libros = biAutos_Has_Libros;
            Mapper = mapper;
        }


        ///<summary>
        /// Crea un nuevo Autor_has_libro
        ///</summary>        
        [ResponseType(typeof(Autor_has_libroDto))]
        [HttpPost]
        public async Task<ActionResult<Autor_has_libro>> Post(Autor_has_libroDto autor_Has_LibroDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var autor_has_libro = Mapper.Map<Autor_has_libro>(autor_Has_LibroDto);
            return await BIAutos_Has_Libros.Post(autor_has_libro);
        }

        ///<summary>
        /// Actualiza un  Autor_has_libro
        ///</summary>        
        [ResponseType(typeof(Autor_has_libroDto))]
        [HttpDelete("{autorId}/{libroId}")]
        public async Task<ActionResult<bool>> Delete(long autorId,long libroId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var autor_has_libro = Mapper.Map<Autor_has_libro>(new Autor_has_libroDto() { AutorId = autorId, LibroId = libroId });
            return await BIAutos_Has_Libros.Delete(autor_has_libro);
            
        }
    }
}
