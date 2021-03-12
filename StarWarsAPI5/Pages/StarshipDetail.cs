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
    public partial class StarshipDetail
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Starship Starship { get; set; } = new Starship();
        protected override async Task OnInitializedAsync()
        {
            await GetStarship();
        }

        async Task GetStarship()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Starship>>(Http.BaseAddress.ToString() + $"starships/?page={int.Parse(CurrentPage)}");
                Starship = response.Results.FirstOrDefault(starship => starship.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
