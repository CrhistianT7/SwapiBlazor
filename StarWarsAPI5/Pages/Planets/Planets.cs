using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Planets
{
    public partial class Planets
    {
        private IEnumerable<Planet> _Planets { get; set; }
        [Inject]
        public IDataService<Planet> DataService { get; set; }
        public int CurrentPage = 1;
        private int TotalPageQuantity = 1;
        private string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await LoadData();
      
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            await LoadData();
        }
        private async Task OnInput(string newValue)
        {
            NameFilter = newValue;
            CurrentPage = 1;
            await LoadData();
        }
        private async Task LoadData()
        {
            var response = await DataService.GetAllData("planets", CurrentPage, NameFilter);
            TotalPageQuantity = (int)Math.Ceiling((decimal)response.Count / 10);
            _Planets = response.Results;
        }
    }
}
