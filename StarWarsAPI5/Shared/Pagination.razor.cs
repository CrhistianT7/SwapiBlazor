using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Shared
{
    public partial class Pagination
    {
        [Parameter] public int CurrentPage { get; set; } = 1;
        [Parameter] public int TotalPagesQuantity { get; set; }
        [Parameter] public int Radius { get; set; } = 3;
        [Parameter] public EventCallback<int> SelectedPage { get; set; }

        List<LinkModel> links;

        protected override void OnParametersSet()
        {
            LoadPages();
            base.OnParametersSet();
        }

        private async Task SelectedPageInternal(LinkModel link)
        {
            if (link.Page == CurrentPage) return;
            if (!link.Enabled) return;
            CurrentPage = link.Page;
            await SelectedPage.InvokeAsync(link.Page);
        }
        private void LoadPages()
        {
            links = new List<LinkModel>();
            var isPreviousPageLinkEnabled = CurrentPage != 1;
            var previousPage = CurrentPage - 1;
            links.Add(new LinkModel(previousPage, isPreviousPageLinkEnabled, "<"));

            for (int i = 1; i <= TotalPagesQuantity; i++ )
            {
                if( i >= CurrentPage - Radius && i <= CurrentPage + Radius)
                {
                    links.Add(new LinkModel(i) { Active = CurrentPage == i });
                }
            }
            var isNextPageLinkEnabled = CurrentPage != TotalPagesQuantity;
            var nextPage = CurrentPage + 1;
            links.Add(new LinkModel(nextPage, isNextPageLinkEnabled, ">"));
        }
        class LinkModel
        {
            public string Text { get; set; }
            public int Page { get; set; }
            public bool Enabled { get; set; }
            public bool Active { get; set; }

            public LinkModel(int page)
                :this(page, true) { }

            public LinkModel(int page, bool enabled)
                : this(page, enabled, page.ToString()) { }

            public LinkModel(int page, bool enabled, string text)
            {
                Page = page;
                Enabled = enabled;
                Text = text; 
            }
        }
    }
}
