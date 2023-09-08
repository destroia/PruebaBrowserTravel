using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Interfaces
{
    public interface IAutos_Has_LibroBI
    {
        Task<Autor_has_libro> Post(Autor_has_libro autor_Has_Libro);
        Task<bool> Delete(Autor_has_libro autor_Has_Libro);
    }
}
