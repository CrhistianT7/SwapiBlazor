#pragma checksum "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac74584a5433100c92105ea78868d751853f4fb"
// <auto-generated/>
#pragma warning disable 1591
namespace StarWarsAPI5.Pages.Films
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
#line 3 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
using StarWarsAPI5.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/films")]
    public partial class Films : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<StarWarsAPI5.Shared.Searcher>(0);
            __builder.AddAttribute(1, "OnClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                   Clear

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnTextChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 5 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
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
#line 7 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                TotalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                                                CurrentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 7 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
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
#line 10 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
     if (_Films != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
         foreach (var film in @_Films)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "information-box");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "color: white;");
            __builder.AddMarkupContent(16, "<span style=\"color: yellow;\"> Title: </span> ");
            __builder.AddContent(17, 
#nullable restore
#line 15 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                                                                         film.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "color: white;");
            __builder.AddMarkupContent(21, "<span style=\"color: yellow;\"> Director: </span> ");
            __builder.AddContent(22, 
#nullable restore
#line 16 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                                                                            film.Director

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "color: white;");
            __builder.AddMarkupContent(26, "<span style=\"color: yellow;\"> Producer: </span> ");
            __builder.AddContent(27, 
#nullable restore
#line 17 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                                                                            film.Producer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "style", "color: white;");
            __builder.AddMarkupContent(31, "<span style=\"color: yellow;\"> Release Date: </span> ");
            __builder.AddContent(32, 
#nullable restore
#line 18 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                                                                                film.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenComponent<StarWarsAPI5.Components.MoreInformation>(34);
            __builder.AddAttribute(35, "reference", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
                                              $"films/{film.Title}/{CurrentPage}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, " More Information ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 21 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<StarWarsAPI5.Components.Loading>(38);
            __builder.CloseComponent();
#nullable restore
#line 26 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\Films\Films.razor"
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
