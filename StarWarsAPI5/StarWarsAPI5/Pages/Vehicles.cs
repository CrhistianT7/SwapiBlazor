using Microsoft.AspNetCore.Components;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages
{
    public partial class Vehicles
    {
        [Inject] HttpClient Http { get; set; }
        private IEnumerable<Vehicle> _Vehicles { get; set; }
        private int CurrentPage = 1;
        private int TotalPageQuantity;
        public string NameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await GetVehicles();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await GetVehicles(page);
        }
        private async void Clear()
        {
            NameFilter = "";
            await GetVehicles();
        }
        async Task GetVehicles(int page = 1)
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Vehicle>>(Http.BaseAddress.ToString() + $"vehicles/?page={page}");
                TotalPageQuantity = response.Count / 10 + 1;
                _Vehicles = response.Results.Where(vh => vh.Name.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
