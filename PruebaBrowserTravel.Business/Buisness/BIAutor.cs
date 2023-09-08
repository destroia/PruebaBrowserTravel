using PruebaBrowserTravel.AccesData.Interfaces;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Buisness
{
    public class BIAutor : PruebaBrowserTravel.Business.Interfaces.IAutorBI
    {
        readonly IAutor Repo;
        public BIAutor(IAutor repo)
        {
            Repo = repo;
        }
        public async Task<Autor> Get(long id)
        {
            return await Repo.Get(id);
        }

        public async Task<List<Autor>> Get()
        {
            return await Repo.Get();
        }

        public async Task<Autor> Post(Autor autor)
        {
            autor.Nombre = autor.Nombre.Trim();
            autor.Apellido = autor.Apellido.Trim();

            return await Repo.Post(autor);
        }

        public async Task<Autor> Update(Autor autor)
        {
            autor.Nombre = autor.Nombre.Trim();
            autor.Apellido = autor.Apellido.Trim();

            return await Repo.Update(autor);
        }
    }
}
