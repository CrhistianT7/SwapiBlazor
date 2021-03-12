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
    public partial class Starships
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Starship> _Starships { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await GetStarships();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await GetStarships(page);
        }
        private async void Clear()
        {
            NameFilter = "";
            await GetStarships();
        }
        async Task GetStarships(int page = 1)
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
        }
    }
}
