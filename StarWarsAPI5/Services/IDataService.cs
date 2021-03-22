using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public interface IDataService<T>
    {
        Task<SwapiListResponse<T>> GetAllData(string entity, int page, string nameFilter);
        /*Task<T> GetDataByName(string entity, string currentPage, string name);*/
    }
}