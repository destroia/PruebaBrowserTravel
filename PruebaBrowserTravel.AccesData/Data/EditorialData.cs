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
    public class EditorialData : IEditorial
    {
        readonly ContextDBTravel DB;
        public EditorialData(ContextDBTravel db)
        {
            DB = db;
        }
        public async Task<List<Editorial>> Get()
        {
            return await DB.Editoriales.ToListAsync();
        }

        public async Task<Editorial> Post(Editorial editorial)
        {
            await DB.Editoriales.AddAsync(editorial);
            await DB.SaveChangesAsync();

            return editorial;
        }

        public async Task<Editorial> Update(Editorial editorial)
        {
            DB.Editoriales.Update(editorial);
            await DB.SaveChangesAsync();

            return editorial;
        }
    }
}
