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
            _Species = (await SpecieDataService.GetAllSpecies(page, NameFilter));
        }
        private async Task Filter()
        {
            _Species = (await SpecieDataService.GetAllSpecies(CurrentPage, NameFilter));
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            _Species = (await SpecieDataService.GetAllSpecies(CurrentPage, NameFilter));
        }
    }
}
