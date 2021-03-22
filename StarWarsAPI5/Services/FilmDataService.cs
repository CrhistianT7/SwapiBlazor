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
            var response = await _Http.GetFromJsonAsync<SwapiListResponse<Film>>(_Http.BaseAddress.ToString() + $"films/?page={page}");
            return response.Results.Where(ch => ch.Title.Contains(NameFilter));
        }
        public async Task<Film> GetFilmByTitle(string currentPage, string title)
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Film>>(_Http.BaseAddress.ToString() + $"films/?page={int.Parse(currentPage)}");
                return response.Results.FirstOrDefault(ch => ch.Title == title);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
