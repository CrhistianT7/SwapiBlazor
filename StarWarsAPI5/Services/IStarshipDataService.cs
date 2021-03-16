using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public interface IStarshipDataService
    {
        Task<IEnumerable<Starship>> GetAllStarships(int page = 1, string NameFilter = "");
    }
}
