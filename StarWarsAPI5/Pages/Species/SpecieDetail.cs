using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Species
{
    public partial class SpecieDetail
    {
        [Inject] IDataService<Specie> DataService { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Specie Specie { get; set; } = new Specie();
        protected override async Task OnInitializedAsync()
        {
            var response = await DataService.GetAllData("species", 1, Name);
            Specie = response.Results.First();
        }
    }
}
