using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Interfaces
{
    public interface  ILibroBI
    {

        Task<Libro> Post(Libro libro);
        Task<Libro> Update(Libro libro);
        Task<Libro> Get(long id);
        Task<List<Libro>> GetList(long id);
    }
}
