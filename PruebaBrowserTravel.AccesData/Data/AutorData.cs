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
    public class AutorData : IAutor
    {
        readonly ContextDBTravel DB;
        public AutorData(ContextDBTravel db)
        {
            DB = db;
        }

        public async Task<Autor> Get(long id)
        {
            return await DB.Autores.FindAsync(id);
        }

        public async  Task<List<Autor>> Get()
        {
            return await DB.Autores.ToListAsync();
        }

        public async Task<Autor> Post(Autor autor)
        {
            await DB.Autores.AddAsync(autor);
            await DB.SaveChangesAsync();
            return autor;
        }

        public async Task<Autor> Update(Autor autor)
        {
            try
            {
                DB.Autores.Update(autor);
                await DB.SaveChangesAsync();
                return autor; 
            }
            catch (Exception es)
            {

                return null;
            }
            
        }
    }
}
