using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public interface IPeopleDataService
    {
        Task<IEnumerable<Character>> GetAllPeople(int page = 1, string NameFilter = "");
        Task<Character> GetCharacterByName(string CurrentPage, string Name);
    }
}