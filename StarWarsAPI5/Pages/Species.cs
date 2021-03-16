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
    public partial class Species
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Specie> _Species { get; set; }
        [Inject]
        public ISpecieDataService SpecieDataService { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity = 4;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            _Species = (await SpecieDataService.GetAllSpecies());
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            _Species = (await SpecieDataService.GetAllSpecies());
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            _Species = (await SpecieDataService.GetAllSpecies());
        }
        /*async Task GetSpecies(int page = 1)
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
        }*/
    }
}
