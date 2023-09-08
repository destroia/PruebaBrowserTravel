using PruebaBrowserTravel.AccesData.Interfaces;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.AccesData.Data
{
    public class Autos_Has_LibroData : IAutos_Has_Libro
    {
        readonly ContextDBTravel DB;
        public Autos_Has_LibroData(ContextDBTravel db)
        {
            DB = db;
        }

        public async  Task<bool> Delete(Autor_has_libro autor_Has_Libro)
        {
            DB.Remove(autor_Has_Libro);
            await DB.SaveChangesAsync();
            return true;
        }

        public async Task<Autor_has_libro> Post(Autor_has_libro autor_Has_Libro)
        {
            await DB.Autor_Has_Libros.AddAsync(autor_Has_Libro);
            await DB.SaveChangesAsync();

            return autor_Has_Libro;
        }
    }
}
