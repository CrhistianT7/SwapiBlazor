using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public interface IVehicleDataService
    {
        Task<IEnumerable<Vehicle>> GetAllVehicles(int page = 1, string NameFilter = "");
        Task<Vehicle> GetVehicleByName(string currentPage, string name);
    }
}
