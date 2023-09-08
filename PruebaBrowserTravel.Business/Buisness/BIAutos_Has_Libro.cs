using PruebaBrowserTravel.AccesData.Interfaces;
using PruebaBrowserTravel.Business.Interfaces;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Buisness
{
    public class BIAutos_Has_Libro : IAutos_Has_LibroBI
    {
        readonly IAutos_Has_Libro Repo;
        public BIAutos_Has_Libro(IAutos_Has_Libro repo)
        {
            Repo = repo;
        }

        public async Task<bool> Delete(Autor_has_libro autor_Has_Libro)
        {
            return await Repo.Delete(autor_Has_Libro);
        }

        public async Task<Autor_has_libro> Post(Autor_has_libro autor_Has_Libro)
        {
            return await Repo.Post(autor_Has_Libro);
        }
    }
}
