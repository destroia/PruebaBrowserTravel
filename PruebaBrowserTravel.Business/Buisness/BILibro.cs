
using PruebaBrowserTravel.AccesData.Interfaces;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Buisness
{
    public class BILibro : PruebaBrowserTravel.Business.Interfaces.ILibroBI
    {
        readonly ILibro Repo;
        public BILibro(ILibro repo)
        {
            Repo = repo;
        }
        
        public async Task<Libro> Get(long id)
        {
            return await Repo.Get(id);
        }

        public async Task<List<Libro>> GetList(long id)
        {
            return await Repo.GetList( id);
        }

        public async  Task<Libro> Post(Libro libro)
        {
            libro.Titulo = libro.Titulo.Trim();
            libro.Sinopsis = libro.Sinopsis.Trim();

            return await Repo.Post(libro);
        }

        public async  Task<Libro> Update(Libro libro)
        {
            libro.Titulo = libro.Titulo.Trim();
            libro.Sinopsis = libro.Sinopsis.Trim();

            return await Repo.Update(libro);
        }
    }
}
