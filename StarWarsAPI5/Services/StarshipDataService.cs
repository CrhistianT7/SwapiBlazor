﻿using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Services
{
    public class StarshipDataService : IStarshipDataService
    {
        private readonly HttpClient _Http;
        public StarshipDataService(HttpClient Http)
        {
            _Http = Http;
        }
        public async Task<IEnumerable<Starship>> GetAllStarships(int page = 1, string NameFilter = "")
        {
            try
            {

                var response = await _Http.GetFromJsonAsync<SwapiListResponse<Starship>>(_Http.BaseAddress.ToString() + $"starships/?page={page}");
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