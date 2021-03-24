using Microsoft.AspNetCore.Components;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Components
{
    public partial class SwapiListDisplayer<TItem>
    {

        [Parameter]
        public string EntityName { get; set; }

        [Parameter]
        public RenderFragment<ListContext> ItemTemplate { get; set; }


        [Inject]
        private IDataService<TItem> DataService { get; set; }

        private IEnumerable<TItem> Data { get; set; }
        private int CurrentPage { get; set; }
        private int TotalPageQuantity { get; set; }
        private string Q { get; set; }


        public SwapiListDisplayer()
        {
            CurrentPage = 1;
            TotalPageQuantity = 1;
            Q = string.Empty;
        }


        protected override async Task OnInitializedAsync()
        {
            await LoadData(); 
        }


        private async Task OnPageSelected(int page)
        {
            CurrentPage = page;
            await LoadData();

        }
        private async Task OnClear()
        {
            Q = string.Empty;
            await LoadData();
        }
        private async Task OnInput(string newValue)
        {
            Q = newValue;
            CurrentPage = 1;
            await LoadData();
        }


        private async Task LoadData()
        {
            var response = await DataService.GetAllData(EntityName, CurrentPage, Q);
            TotalPageQuantity = (int)Math.Ceiling((decimal)response.Count / 10);
            Data = response.Results;
        }


        public class ListContext
        {
            public TItem Item { get; set; }
            public int CurrentPage { get; set; }
        }
    }
}
