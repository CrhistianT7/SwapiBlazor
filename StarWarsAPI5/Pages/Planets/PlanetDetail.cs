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
    public partial class PlanetDetail
    {
        [Inject]
        public IDataService<Planet> DataService{ get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Planet Planet { get; set; } = new Planet();
        protected override async Task OnInitializedAsync()
        {
            var response = await DataService.GetAllData("planets", 1, Name);
            Planet = response.Results.First();
        }
    }
}
