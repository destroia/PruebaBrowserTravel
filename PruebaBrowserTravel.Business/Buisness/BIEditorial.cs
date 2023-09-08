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
    public class BIEditorial : IEditorialBI
    {
        readonly IEditorial Repo;
        public BIEditorial(IEditorial repo)
        {
            Repo = repo;
        }

        public async  Task<List<Editorial>> Get()
        {
            return await Repo.Get();
        }

        public async Task<Editorial> Post(Editorial editorial)
        {
            return await Repo.Post(editorial);
        }

        public async Task<Editorial> Update(Editorial editorial)
        {
            return await Repo.Update(editorial);
        }
    }
}
