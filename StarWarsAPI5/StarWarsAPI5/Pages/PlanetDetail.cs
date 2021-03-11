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
    public partial class PlanetDetail
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Planet Planet { get; set; } = new Planet();
        protected override async Task OnInitializedAsync()
        {
            await GetFilm();
        }

        async Task GetFilm()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Planet>>(Http.BaseAddress.ToString() + $"planets/?page={int.Parse(CurrentPage)}");
                Planet = response.Results.FirstOrDefault(planet => planet.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
