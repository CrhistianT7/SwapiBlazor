#pragma checksum "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e573cdfeb217bbdcb34ca8fe60cc4d2c3d4603ce"
// <auto-generated/>
#pragma warning disable 1591
namespace StarWarsAPI5.Pages.People
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/people/{Name}/{CurrentPage}")]
    public partial class PeopleDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
 if (@Character != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "flex-container");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<span style=\"color: yellow;\">Name:</span>");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "style", "color: white;");
            __builder.AddContent(6, 
#nullable restore
#line 6 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                                                                                    Character.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "<span style=\"color: yellow;\">Birth Year:</span>");
            __builder.OpenElement(10, "span");
            __builder.AddAttribute(11, "style", "color: white;");
            __builder.AddContent(12, 
#nullable restore
#line 7 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                                                                                          Character.BirthYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "<span style=\"color: yellow;\">Films:</span>\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "color: white;");
#nullable restore
#line 11 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                 if (@Character.Films != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                     foreach (var film in @Character.Films)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 16 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                                      film

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "target", "_blank");
            __builder.AddAttribute(22, "style", "color: white;");
            __builder.AddContent(23, 
#nullable restore
#line 16 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                                                                                   film

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
}
else
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<StarWarsAPI5.Components.Loading>(24);
            __builder.CloseComponent();
#nullable restore
#line 27 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Pages\People\PeopleDetail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
