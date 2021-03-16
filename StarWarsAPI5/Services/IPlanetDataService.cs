using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public interface IPlanetDataService
    {
        Task<IEnumerable<Planet>> GetAllPlanets(int page = 1, string NameFilter = "");
        Task<Planet> GetPlanetByName(string currentPage, string name);
    }
}

