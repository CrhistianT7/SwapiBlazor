using Microsoft.AspNetCore.Components;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI5.Components
{
    public partial class DataContainer
    {
        [Parameter]
        public int CurrentPage { get; set; }
        [Parameter]
        public IEnumerable<Character> Entity { get; set; }
    }
}
