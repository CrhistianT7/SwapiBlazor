#pragma checksum "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487d6f13b73c6c7a85f49a7bdb7858bcb648b7f2"
// <auto-generated/>
#pragma warning disable 1591
namespace StarWarsAPI5.Pages.Vehicles
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
#nullable restore
#line 3 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
using StarWarsAPI5.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vehicles")]
    public partial class Vehicles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<StarWarsAPI5.Shared.Searcher>(0);
            __builder.AddAttribute(1, "OnClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                   Clear

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnTextChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 5 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                        OnInput

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<StarWarsAPI5.Shared.Pagination>(4);
            __builder.AddAttribute(5, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                TotalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                                                CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 7 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                                                                                      SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "flex-container");
#nullable restore
#line 10 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
     if (_Vehicles != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
         foreach (var vehicle in _Vehicles)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "information-box");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "color: white;");
            __builder.AddMarkupContent(16, "<span style=\"color: yellow;\"> Name:</span> ");
            __builder.AddContent(17, 
#nullable restore
#line 15 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                                                                       vehicle.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "color: white;");
            __builder.AddMarkupContent(21, "<span style=\"color: yellow;\"> Model:</span> ");
            __builder.AddContent(22, 
#nullable restore
#line 16 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                                                                        vehicle.Model

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "color: white;");
            __builder.AddMarkupContent(26, "<span style=\"color: yellow;\"> Length:</span> ");
            __builder.AddContent(27, 
#nullable restore
#line 17 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                                                                         vehicle.Length

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenComponent<StarWarsAPI5.Components.MoreInformation>(29);
            __builder.AddAttribute(30, "reference", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
                                              $"vehicles/{@vehicle.Name}/{CurrentPage}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(32, " More Information");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 20 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<StarWarsAPI5.Components.Loading>(33);
            __builder.CloseComponent();
#nullable restore
#line 25 "E:\Ravn\BootCamp\Repository\SwapiBlazor\StarWarsAPI5\Pages\Vehicles\Vehicles.razor"
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
