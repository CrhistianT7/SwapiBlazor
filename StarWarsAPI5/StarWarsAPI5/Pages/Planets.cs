using Microsoft.AspNetCore.Components;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages
{
    public partial class Planets
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Planet> _Planets { get; set; }
        public int CurrentPage = 1;
        private int TotalPageQuantity;
        private string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await GetPlanets();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await GetPlanets(page);
        }
        private async void Clear()
        {
            NameFilter = "";
            await GetPlanets();
        }
        async Task GetPlanets(int page = 1)
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Planet>>(Http.BaseAddress.ToString() + $"planets/?page={page}");
                TotalPageQuantity = response.Count / 10 + 1;
                _Planets = response.Results;
                _Planets = _Planets.Where(film => film.Name.Contains(NameFilter));

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
