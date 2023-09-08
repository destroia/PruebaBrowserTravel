using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Interfaces
{
    public interface IAutorBI
    {
        Task<Autor> Post(Autor autor);
        Task<Autor> Update(Autor autor);
        Task<Autor> Get(long id);
        Task<List<Autor>> Get();

    }
}
