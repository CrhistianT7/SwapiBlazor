using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class SpecieDataService : ISpecieDataService
    {
        private readonly HttpClient _Http;
        public SpecieDataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<IEnumerable<Specie>> GetAllSpecies(int page = 1, string NameFilter = "")
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Specie>>(_Http.BaseAddress.ToString() + $"species/?page={page}");
                return response.Results.Where(ch => ch.Name.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
