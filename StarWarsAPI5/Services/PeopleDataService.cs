using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class PeopleDataService : IPeopleDataService
    {
        private readonly HttpClient _Http;
        public PeopleDataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<IEnumerable<Character>> GetAllPeople(int page = 1, string nameFilter = "")
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Character>>(_Http.BaseAddress.ToString() + $"people/?search={nameFilter}&page={page}");
                return response.Results;
            }
            catch (Exception ex)
            {
                // Handle Error
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Character> GetCharacterByName(string CurrentPage, string Name)
        {
            try
            {
                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Character>>(_Http.BaseAddress.ToString() + $"people/?page={int.Parse(CurrentPage)}"); 
                return  response.Results.FirstOrDefault(character => character.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
