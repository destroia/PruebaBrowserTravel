using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaBrowserTravel.AccesData.Interfaces;
using PruebaBrowserTravel.Business.Interfaces;
using PruebaBrowserTravel.DTO;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaBrowserTravel.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        readonly IAutorBI BIAutor;
        readonly IMapper Mapper;
        public AutoresController(IAutorBI biAutor,IMapper mapper)
        {
            BIAutor = biAutor;
            Mapper = mapper;
        }
        ///<summary>
        /// Obtiene un autor por el ID
        ///</summary>        
        //[ResponseType(typeof(ActionResult<Autor>))]
        [HttpGet("{id}")]
        public async Task<ActionResult< Autor>> Get(long id)
        {
            return await BIAutor.Get(id);
        }


        ///<summary>
        /// Obtiene todos los autores 
        ///</summary>    
        //[ResponseType(typeof(ActionResult<List<Autor>>))]
        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {
            return await BIAutor.Get();
        }

        ///<summary>
        /// crea un nuevo autor
        ///</summary> 
        //[ResponseType(typeof(ActionResult<Autor>))]
        [HttpPost]
        public async Task<ActionResult<Autor>> Post(AutorDto autorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var autor = Mapper.Map<Autor>(autorDto);
            return await BIAutor.Post(autor);
        }

        ///<summary>
        /// actualiza  un autor
        ///</summary> 
        //[ResponseType(typeof(ActionResult<Autor>))]
        [HttpPut]
        public async Task<ActionResult<Autor>> Update(AutorDto autorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var autor = Mapper.Map<Autor>(autorDto);
            return await BIAutor.Update(autor);
        }
    }
}
