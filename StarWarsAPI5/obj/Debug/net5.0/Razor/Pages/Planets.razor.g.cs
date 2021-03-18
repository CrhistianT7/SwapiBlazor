#pragma checksum "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe7e4561463c3bc7b1294d76571e7a76b8133a5b"
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
#line 1 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using StarWarsAPI5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\_Imports.razor"
using StarWarsAPI5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
using StarWarsAPI5.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/planets")]
    public partial class Planets : Microsoft.AspNetCore.Components.ComponentBase
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
#line 8 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
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
            __builder.AddAttribute(13, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                 Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, " Filter");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, " Clear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenComponent<StarWarsAPI5.Shared.Pagination>(23);
            __builder.AddAttribute(24, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                TotalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 15 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                                                      SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "flex-container");
#nullable restore
#line 18 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
     if (_Planets != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
         foreach (var planet in _Planets)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "information-box");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "style", "color: white;");
            __builder.AddMarkupContent(35, "<span style=\"color: yellow;\">Name: </span> ");
            __builder.AddContent(36, 
#nullable restore
#line 23 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                                   planet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "style", "color: white;");
            __builder.AddMarkupContent(40, "<span style=\"color: yellow;\">Rotation Period: </span> ");
            __builder.AddContent(41, 
#nullable restore
#line 24 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                                              planet.RotationPeriod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "color: white;");
            __builder.AddMarkupContent(45, "<span style=\"color: yellow;\">Gravity: </span> ");
            __builder.AddContent(46, 
#nullable restore
#line 25 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                                      planet.Gravity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "style", "color: white;");
            __builder.AddMarkupContent(50, "<span style=\"color: yellow;\">Population: </span> ");
            __builder.AddContent(51, 
#nullable restore
#line 26 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                                                                         planet.Population

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenComponent<StarWarsAPI5.Components.MoreInformation>(53);
            __builder.AddAttribute(54, "reference", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
                                          $"planets/{@planet.Name}/{CurrentPage}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(56, " More Information");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 29 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<div>\r\n            Loading ...\r\n        </div>");
#nullable restore
#line 36 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Planets.razor"
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
