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
    public partial class SpecieDetail
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Specie Specie { get; set; } = new Specie();
        protected override async Task OnInitializedAsync()
        {
            await GetSpecie();
        }

        async Task GetSpecie()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Specie>>(Http.BaseAddress.ToString() + $"species/?page={int.Parse(CurrentPage)}");
                Specie = response.Results.FirstOrDefault(specie => specie.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
