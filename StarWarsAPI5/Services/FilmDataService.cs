using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class FilmDataService : IFilmDataService
    {
        private readonly HttpClient _Http;
        public FilmDataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<IEnumerable<Film>> GetAllFilms(int page = 1, string NameFilter = "")
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Film>>(_Http.BaseAddress.ToString() + $"films/?page={page}");
                return response.Results.Where(ch => ch.Title.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
