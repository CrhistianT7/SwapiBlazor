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
    public partial class FilmDetail
    {
        [Inject] HttpClient Http { get; set; }
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Film Film { get; set; } = new Film();
        protected override async Task OnInitializedAsync()
        {
            await GetFilm();
        }

        async Task GetFilm()
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Film>>(Http.BaseAddress.ToString() + $"films/?page={int.Parse(CurrentPage)}");
                Film = response.Results.FirstOrDefault(film => film.Title == Title);

            }
            catch (Exception ex)
            {
                //Handle Error
                Console.WriteLine(ex.Message);
            }
        }
    }
}
