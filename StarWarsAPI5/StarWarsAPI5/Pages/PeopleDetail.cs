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
    public partial class PeopleDetail
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string currentPage { get; set; }
        public Character Character { get; set; } = new Character();

        protected override async Task OnInitializedAsync()
        {
            await GetCharacter();
        }

        async Task GetCharacter()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Character>>(Http.BaseAddress.ToString() + $"people/?page={int.Parse(currentPage)}");
                Character = response.Results.FirstOrDefault(character => character.Name == Name);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
