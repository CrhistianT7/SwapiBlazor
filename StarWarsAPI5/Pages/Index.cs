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
    public partial class Index
    {
        [Inject] HttpClient Http { get; set; }
        public IEnumerable<Character> Peoples { get; set; }

        private async Task GetCharacters()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Character>>(Http.BaseAddress.ToString() + "people/");
                Peoples = response.Results;
                Console.WriteLine(Peoples);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
