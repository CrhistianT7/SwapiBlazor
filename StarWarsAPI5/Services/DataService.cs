using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class DataService<T> : IDataService<T>
    {
        private readonly HttpClient _Http;
        public DataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<SwapiListResponse<T>> GetAllData(string entity = "people", int page = 1, string nameFilter = "")
        {
            return await _Http.GetFromJsonAsync<SwapiListResponse<T>>($"{entity}/?search={nameFilter}&page={page}");   
        }
    }
}
