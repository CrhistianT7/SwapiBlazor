using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Pages.Films
{
    public partial class Films
    {
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
            _Films = (await FilmDataService.GetAllFilms(page, NameFilter));
        }
        private async Task Filter()
        {
            _Films = (await FilmDataService.GetAllFilms(CurrentPage, NameFilter));
        }
        private async Task Clear()
        {
            NameFilter = string.Empty;
            _Films = (await FilmDataService.GetAllFilms(CurrentPage, NameFilter));
        }
    }
}
