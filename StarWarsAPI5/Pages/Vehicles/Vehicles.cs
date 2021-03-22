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
    public partial class Vehicles
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Vehicle> _Vehicles { get; set; }
        [Inject]
        public IVehicleDataService VehicleDataService { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity = 4;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            _Vehicles = await VehicleDataService.GetAllVehicles();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            _Vehicles = await VehicleDataService.GetAllVehicles(page, NameFilter);
        }
        private async Task Filter()
        {
            _Vehicles = await VehicleDataService.GetAllVehicles(CurrentPage, NameFilter);
        }
        private async Task Clear()
        {
            NameFilter = "";
            _Vehicles = await VehicleDataService.GetAllVehicles(CurrentPage, NameFilter);
        }
    }
}
