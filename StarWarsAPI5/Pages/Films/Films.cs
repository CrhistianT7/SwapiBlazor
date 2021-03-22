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
            var response = await DataService.GetAllData("films", CurrentPage, NameFilter);
            TotalPageQuantity = response.Count / 10 + 1;
            _Films = response.Results;
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await LoadData();
        }
        private async Task Filter()
        {
            await LoadData();
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            await LoadData();
        }
        private async Task LoadData()
        {
            var response = await DataService.GetAllData("films", CurrentPage, NameFilter);
            _Films = response.Results;
        }
    }
}
