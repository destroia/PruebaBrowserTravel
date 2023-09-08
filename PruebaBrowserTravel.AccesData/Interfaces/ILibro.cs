using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.AccesData.Interfaces
{
    public interface ILibro
    {
        Task<Libro> Post(Libro libro);
        Task<Libro> Update(Libro libro);
        Task<Libro> Get(long id);
        Task<List<Libro>> GetList(long id);
    }
}
