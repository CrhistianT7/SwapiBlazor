using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class FilmDataService : BaseSwapiService<Film>, IFilmDataService
    {
      
        public FilmDataService(HttpClient Http): base(Http)
        {
         
        }
        public  Task<IEnumerable<Film>> GetAllFilms(int page = 1, string NameFilter = "")
        {
            return GetAllEntities("films", page, NameFilter);
        }
        public Task<Film> GetFilmByTitle(string currentPage, string title)
        {
            return GetEnitityByTitle("films",currentPage, title);
        }
    }
}
