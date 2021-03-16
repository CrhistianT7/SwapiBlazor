using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class PlanetDataService : IPlanetDataService
    {
        private readonly HttpClient _Http;
        public PlanetDataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<IEnumerable<Planet>> GetAllPlanets(int page = 1, string NameFilter = "")
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Planet>>(_Http.BaseAddress.ToString() + $"planets/?page={page}");
                return response.Results.Where(ch => ch.Name.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /*public async Task<Character> GetCharacterByName(string Name = "Luke Skywalker")
        {
            try
            {
                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Character>>(_Http.BaseAddress.ToString() + $"people/?page={1}"); 
                return response.Results.FirstOrDefault(character => character.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
                return null;
            }
        }*/
    }
}
