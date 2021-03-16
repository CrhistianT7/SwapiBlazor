using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class VehicleDataService : IVehicleDataService
    {
        private readonly HttpClient _Http;
        public VehicleDataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<IEnumerable<Vehicle>> GetAllVehicles(int page = 1, string NameFilter = "")
        {
            try
            {
                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Vehicle>>(_Http.BaseAddress.ToString() + $"vehicles/?page={page}");
                return response.Results.Where(ch => ch.Name.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public async Task<Vehicle> GetVehicleByName(string currentPage, string name)
        {
            try
            {
                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Vehicle>>(_Http.BaseAddress.ToString() + $"vehicles/?page={int.Parse(currentPage)}");
                return response.Results.FirstOrDefault(ch => ch.Name == name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
