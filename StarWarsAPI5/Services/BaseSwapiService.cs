using StarWarsAPI5.Entities;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public abstract class BaseSwapiService<T>
        where T: ISearchableEntity
    {
        private readonly HttpClient _Http;


        public BaseSwapiService(HttpClient httpClient)
        {
            this._Http = httpClient;
        }

        protected async Task<IEnumerable<T>> GetAllEntities(string entity,int page = 1, string NameFilter = "")
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<T>>(_Http.BaseAddress.ToString() + $"{entity}/?search={NameFilter}&page={page}");
                return response.Results;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        protected async Task<T> GetEnitityByTitle(string entity,string currentPage, string title)
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<T>>(_Http.BaseAddress.ToString() + $"{entity}/?page={int.Parse(currentPage)}");
                return response.Results.FirstOrDefault(ch => ch.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }

    }
}
