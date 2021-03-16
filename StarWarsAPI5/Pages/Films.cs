using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages
{
    public partial class Films
    {
        [Inject] HttpClient Http { get; set; }
        public IEnumerable<Film> _Films { get; set; }
        [Inject]
        public IFilmDataService FilmDataService { get; set; }
        public int CurrentPage = 1;
        public int TotalPageQuantity = 1;
        public string NameFilter { get; set; } = "";

        protected override async Task OnInitializedAsync()
        {
            _Films = (await FilmDataService.GetAllFilms());
        }

        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            _Films = (await FilmDataService.GetAllFilms());
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            _Films = (await FilmDataService.GetAllFilms());
        }

        /*protected override async Task OnInitializedAsync()
        {
            await GetFilms();
        }
        private async Task SelectedPage(int page)
        {
            CurrentPage = page;
            await GetFilms(page);
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            await GetFilms();
        }
        async Task GetFilms(int page = 1)
        {
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Film>>(Http.BaseAddress.ToString() + $"films/?page={page}");
                TotalPageQuantity = response.Count / 10 + 1;
                _Films = response.Results.Where(film => film.Title.Contains(NameFilter));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}
