#pragma checksum "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "475ce7f77eeb9c8ed7a55f8eb08feb852b227df7"
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pagination justify-content-center");
#nullable restore
#line 3 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor"
         foreach(var link in links)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor"
                             () => SelectedPageInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "cursor: pointer;");
            __builder.AddAttribute(7, "class", "page-item" + " " + (
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor"
                                   link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor"
                                                                       link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "page-link");
            __builder.AddAttribute(10, "href", "#");
            __builder.AddContent(11, 
#nullable restore
#line 8 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 10 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Shared\Pagination.razor"
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
