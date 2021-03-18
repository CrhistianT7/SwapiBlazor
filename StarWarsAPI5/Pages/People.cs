using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages
{
    public partial class People
    {
        public IEnumerable<Character> _People { get; set; }
        [Inject]
        public IPeopleDataService PeopleDataService { get; set; }

        private int TotalPageQuantity = 9;
        public int CurrentPage = 1;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            _People = (await PeopleDataService.GetAllPeople());
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            _People = (await PeopleDataService.GetAllPeople(page, NameFilter));
        }
        private async Task Filter(string  newValue)
        {
            NameFilter = newValue;
            CurrentPage = 1;
            _People = await PeopleDataService.GetAllPeople(CurrentPage, NameFilter);
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            _People = (await PeopleDataService.GetAllPeople(CurrentPage, NameFilter));
        }
    }
}
