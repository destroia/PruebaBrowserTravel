using PruebaBrowserTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBrowserTravel.Business.Interfaces
{
    public interface IEditorialBI
    {
        Task<Editorial> Post(Editorial editorial);
        Task<Editorial> Update(Editorial editorial);
        Task<List<Editorial>> Get();
    }
}
