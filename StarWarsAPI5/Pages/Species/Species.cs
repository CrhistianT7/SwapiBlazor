using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Species
{
    public partial class Species
    {
        private IEnumerable<Specie> _Species { get; set; }
        [Inject]
        public ISpecieDataService SpecieDataService { get; set; }
        [Inject]
        public IDataService<Specie> DataService { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity = 4;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }
        private async Task SelectedPage(int page)

        {
            CurrentPage = page;
            _Species = (await SpecieDataService.GetAllSpecies(page, NameFilter));
        }
        private async Task Filter()
        {
            Console.WriteLine("NameFilter Filter:");
            Console.WriteLine(NameFilter);
            var response = await DataService.GetAllData("species", CurrentPage, NameFilter);
            _Species = response.Results.Where( sp => sp.Name.Contains(NameFilter));
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            await LoadData();
        }
        private async Task OnInput()
        {
            Console.WriteLine("NameFilter OnInput:");
            Console.WriteLine(NameFilter);
            var response = await DataService.GetAllData("species", CurrentPage, NameFilter);
            _Species = response.Results.Where(sp => sp.Name.Contains(NameFilter));
        }
        private async Task LoadData()
        {
            var response = await DataService.GetAllData("species", CurrentPage, NameFilter);
            _Species = response.Results;
        }
    }
}
