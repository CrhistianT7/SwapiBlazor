using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Shared
{
    public partial class Searcher
    {
        [Parameter] 
        public string NameFilter { get; set; }
        [Parameter] 
        public EventCallback Filter { get; set; }
        [Parameter] 
        public EventCallback Clear { get; set; }
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
    }
}
