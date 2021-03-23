using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Films
{
    public partial class Films
    {
        public IEnumerable<Film> _Films { get; set; }
        [Inject] 
        public IDataService<Film> DataService { get; set; }
        public int CurrentPage = 1;
        public int TotalPageQuantity = 1;
        public string NameFilter { get; set; } = "";

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
            NameFilter = "";
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
            var response = await DataService.GetAllData("films", CurrentPage, NameFilter);
            TotalPageQuantity = (int)Math.Ceiling((decimal)response.Count / 10);
            _Films = response.Results;
        }
    }
}
