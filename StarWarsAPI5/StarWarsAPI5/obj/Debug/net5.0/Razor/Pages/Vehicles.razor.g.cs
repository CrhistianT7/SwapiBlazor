#pragma checksum "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62b0c259fb14bcb02c16b20149fd7002973e392b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/vehicles")]
    public partial class Vehicles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-inline");
            __builder.AddAttribute(2, "style", "align-items: center;");
            __builder.AddMarkupContent(3, "<label class=\" sr-only\" for=\"filter-name\">Filter</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(7, "placeholder", "Filter by Name");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                        NameFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NameFilter = __value, NameFilter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                                                                Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, " Clear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenComponent<StarWarsAPI5.Shared.Pagination>(17);
            __builder.AddAttribute(18, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                                TotalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                                                                CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 12 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                                                                                                      SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "div");
#nullable restore
#line 15 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
     if (_Vehicles != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
         foreach (var vehicle in _Vehicles)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddContent(25, 
#nullable restore
#line 19 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                  vehicle.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 20 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
                       $"vehicles/{@vehicle.Name}/{CurrentPage}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, "More information");
            __builder.CloseElement();
#nullable restore
#line 21 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<div>\r\n            Loading ...\r\n        </div>");
#nullable restore
#line 28 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\StarWarsAPI5\Pages\Vehicles.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
