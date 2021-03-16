using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages
{
    public partial class Starships
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Starship> _Starships { get; set; }
        [Inject]
        public IStarshipDataService StarshipDataService { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity = 4;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            _Starships = (await StarshipDataService.GetAllStarships());
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            _Starships = (await StarshipDataService.GetAllStarships());
        }
        private async void Clear()
        {
            NameFilter = "";
            _Starships = (await StarshipDataService.GetAllStarships());
        }
        /*async Task GetStarships(int page = 1)
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Starship>>(Http.BaseAddress.ToString() + $"starships/?page={page}");
                TotalPageQuantity = response.Count / 10 + 1;
                _Starships = response.Results.Where(ss => ss.Name.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}
