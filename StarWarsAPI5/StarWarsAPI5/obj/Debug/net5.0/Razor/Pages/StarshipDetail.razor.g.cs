#pragma checksum "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\StarshipDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf293654cd152f8aae77d3f32c2d7afdc04579a"
// <auto-generated/>
#pragma warning disable 1591
namespace StarWarsAPI5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using StarWarsAPI5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\_Imports.razor"
using StarWarsAPI5.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/starships/{Name}/{CurrentPage}")]
    public partial class StarshipDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 3 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\StarshipDetail.razor"
     Starship.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
