using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Vehicles
{
    public partial class VehicleDetail
    {
        [Inject] IDataService<Vehicle> DataService { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Vehicle Vehicle { get; set; } = new Vehicle();
        protected override async Task OnInitializedAsync()
        {
            var response = await DataService.GetAllData("vehicles", 1, Name);
            Vehicle = response.Results.First();
        }
    }
}
