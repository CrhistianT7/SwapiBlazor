using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.People
{
    public partial class PeopleDetail
    {
        [Inject]
        public IDataService<Character> DataService { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Character Character { get; set; } = new Character();

        protected override async Task OnInitializedAsync()
        {
            var response = await DataService.GetAllData("people", 1, Name);
            Character = response.Results.First();
        }
    }
}
