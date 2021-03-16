using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public interface ISpecieDataService
    {
        Task<IEnumerable<Specie>> GetAllSpecies(int page = 1, string NameFilter = "");
        Task<Specie> GetSpecieByName(string currentPage, string name);
    }
}
