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
        public async Task<SwapiListResponse<T>> GetAllData(string entity, int page, string nameFilter)
        {
            return await _Http.GetFromJsonAsync<SwapiListResponse<T>>(_Http.BaseAddress.ToString() + $"{entity}/?Search={nameFilter}");   
        }
        /*public async Task<T> GetDataByName(string entity, string currentPage, string name)
        {

            var response = await _Http.GetFromJsonAsync<SwapiListResponse<T>>(_Http.BaseAddress.ToString() + $"{entity}/?page={int.Parse(currentPage)}");
            return response.Results.FirstOrDefault(ch => ch.Name == name);
        }*/
    }
}
