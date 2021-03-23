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
    public partial class FilmDetail
    {
        [Inject] IDataService<Film> DataService { get; set; }
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string CurrentPage { get; set; }
        public Film Film { get; set; } = new Film();
        protected override async Task OnInitializedAsync()
        {
            var response = await DataService.GetAllData("films", 1, Title);
            Film = response.Results.First();
        }
    }
}
