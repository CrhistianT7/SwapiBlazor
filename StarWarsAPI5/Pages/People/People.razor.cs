using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.People
{
    public partial class People
    {
        public IEnumerable<Character> _People { get; set; }
        [Inject]
        public IPeopleDataService PeopleDataService { get; set; }
        [Inject]
        IDataService<Character> DataService { get; set; }

        private int TotalPageQuantity;
        public int CurrentPage = 1;
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
            NameFilter = string.Empty;
            await LoadData();
        }
        private async Task OnInput()
        {
            Console.WriteLine("On Input");
            await LoadData();
        }
        private async Task LoadData()
        {
            /*_People = await PeopleDataService.GetAllPeople(CurrentPage, NameFilter);*/
            var response = await DataService.GetAllData("people", CurrentPage, NameFilter);
            TotalPageQuantity = response.Count / 10 + 1;
            _People = response.Results;

        }
    }
}
