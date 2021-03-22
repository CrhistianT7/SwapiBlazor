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
        public IPeopleDataService PeopleDataService { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string currentPage { get; set; }
        public Character Character { get; set; } = new Character();

        protected override async Task OnInitializedAsync()
        {
            Character = await PeopleDataService.GetCharacterByName(currentPage, Name);
        }
    }
}
