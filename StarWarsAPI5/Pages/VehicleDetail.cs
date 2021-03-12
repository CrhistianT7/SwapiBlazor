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
    public partial class VehicleDetail
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Vehicle Vehicle { get; set; } = new Vehicle();
        protected override async Task OnInitializedAsync()
        {
            await GetStarship();
        }

        async Task GetStarship()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Vehicle>>(Http.BaseAddress.ToString() + $"vehicles/?page={int.Parse(CurrentPage)}");
                Vehicle = response.Results.FirstOrDefault(vehicle => vehicle.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
