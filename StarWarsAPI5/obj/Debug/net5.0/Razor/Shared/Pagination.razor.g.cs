#pragma checksum "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f6cc0dac769e378d8e1bd1a4acfef8f29d8590"
// <auto-generated/>
#pragma warning disable 1591
namespace StarWarsAPI5.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using StarWarsAPI5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\_Imports.razor"
using StarWarsAPI5.Shared;

#line default
#line hidden
#nullable disable
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddAttribute(2, "b-2vaatjpyye");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddAttribute(5, "b-2vaatjpyye");
#nullable restore
#line 3 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor"
         foreach(var link in links)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor"
                             () => SelectedPageInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "cursor: pointer;");
            __builder.AddAttribute(9, "class", "page-item" + " " + (
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor"
                                   link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor"
                                                                       link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-2vaatjpyye");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "class", "page-link");
            __builder.AddAttribute(13, "href", "#");
            __builder.AddAttribute(14, "style", "color: black; margin: 3px;");
            __builder.AddAttribute(15, "b-2vaatjpyye");
            __builder.AddContent(16, 
#nullable restore
#line 8 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor"
                                                                                     link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Shared\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
