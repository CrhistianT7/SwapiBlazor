using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Starships
{
    public partial class StarshipDetail
    {
        [Inject]
        public IDataService<Starship> DataService { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Starship Starship { get; set; } = new Starship();
        protected override async Task OnInitializedAsync()
        {
            var response = await DataService.GetAllData("starships", 1, Name);
            Starship = response.Results.First();
        }
    }
}
