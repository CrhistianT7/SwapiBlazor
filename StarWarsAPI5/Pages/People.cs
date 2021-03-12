using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages
{
    public partial class People
    {
        [Inject] HttpClient Http { get; set; }
        public IEnumerable<Character> _People { get; set; }
        private int totalPageQuantity;
        public int currentPage = 1;
        private string nameFilter { get; set; } = "";
        protected override async Task OnInitializedAsync()
        {
            await GetPeople();
        }

        private async Task SelectedPage(int page)
        {
            currentPage = page;
            await GetPeople(page);
        }
        private async Task Clear()
        {
            nameFilter = string.Empty;
            await GetPeople();
        }
        async Task GetPeople( int page = 1)

        {
            var httpResponse = await Http.GetAsync($"people/?page={page}");
            if (httpResponse.IsSuccessStatusCode)
            {
                var responseString = await httpResponse.Content.ReadAsStringAsync();
                JObject responseJson = JObject.Parse(responseString);
                totalPageQuantity = int.Parse(JsonConvert.SerializeObject(responseJson["count"]))/10 + 1;
                responseString = JsonConvert.SerializeObject(responseJson["results"]);
                _People = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Character>>(responseString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true});
                _People = _People.Where(x => x.Name.Contains(nameFilter));
            }
            else
            {
                // error handle
            }
        }
        
    }
}
