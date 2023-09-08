using Microsoft.EntityFrameworkCore;
using PruebaBrowserTravel.AccesData.Interfaces;
using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.AccesData.Data
{
    public class LibroData : ILibro
    {
        readonly ContextDBTravel DB;
        public LibroData(ContextDBTravel db)
        {
            DB = db;
        }
        public async Task<Libro> Get(long id)
        {
            return await DB.Libros.FindAsync(id);
        }

        public async  Task<List<Libro>> GetList(long id)
        {
            return await DB.Libros.Join(DB.Autor_Has_Libros,l => l.Id ,h => h.LibroId,(l,h) => new { l, h })
                .Where(x => x.h.AutorId == id)
                .Select(x => new Libro()
                {
                    EditorialId = x.l.EditorialId,
                    Id =x.l.Id,
                    NumeroPaginas = x.l.NumeroPaginas,
                    Sinopsis =x.l.Sinopsis,
                    Titulo =x.l.Titulo
                })
                .ToListAsync();
        }

        public async Task<Libro> Post(Libro libro)
        {
            await DB.Libros.AddAsync(libro);
            await DB.SaveChangesAsync();

            return libro;
        }

        public async Task<Libro> Update(Libro libro)
        {
            DB.Libros.Update(libro);
            await DB.SaveChangesAsync();

            return libro;
        }
    }
}
