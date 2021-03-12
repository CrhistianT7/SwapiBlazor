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
    public partial class Species
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Specie> _Species { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await GetSpecies();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await GetSpecies(page);
        }
        private async void Clear()
        {
            NameFilter = "";
            await GetSpecies();
        }
        async Task GetSpecies(int page = 1)
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Specie>>(Http.BaseAddress.ToString() + $"species/?page={page}");
                TotalPageQuantity = response.Count / 10 + 1;
                _Species = response.Results.Where(sp => sp.Name.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
