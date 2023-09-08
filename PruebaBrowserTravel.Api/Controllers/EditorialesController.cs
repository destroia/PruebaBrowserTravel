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
    public class EditorialesController : ControllerBase
    {
        readonly IEditorialBI BIEditorial;
        readonly IMapper Mapper;
        public EditorialesController(IEditorialBI ibEditorial, IMapper mapper)
        {
            BIEditorial = ibEditorial;
            Mapper = mapper;
        }
        ///<summary>
        /// Obtiene todas la editoriales
        ///</summary>        
        //[ResponseType(typeof(ActionResult<List<Editorial>>))]
        [HttpGet]
        public async Task<ActionResult<List<Editorial>>> Get()
        {
            return await BIEditorial.Get();
        }


        ///<summary>
        /// Crea un nueva  editorial
        ///</summary>        
        //[ResponseType(typeof(ActionResult<Editorial>))]

        [HttpPost]
        public async Task<ActionResult<Editorial>> Post(EditorialDto editorialDto)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var editor = Mapper.Map<Editorial>(editorialDto);
            return await BIEditorial.Post(editor);
            
        }

        ///<summary>
        /// Actualiza un  editorial
        ///</summary>        
        [ResponseType(typeof(ActionResult<Editorial>))]
        [HttpPut]
        public async Task<ActionResult<Editorial>> Update(EditorialDto editorialDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var editor = Mapper.Map<Editorial>(editorialDto);
            return await BIEditorial.Update(editor);
        }
    }
}
