#pragma checksum "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Shared\Searcher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4db8362847bb73ae20dbd73842f177709db33457"
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
    public partial class Searcher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-inline");
            __builder.AddAttribute(2, "style", "display: flex; justify-content: center;");
            __builder.AddMarkupContent(3, "<label class=\" sr-only\" for=\"filter-name\">Filter</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 4 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Shared\Searcher.razor"
                      OnInputChange

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "placeholder", "Filter by Name");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "E:\Ravn\ravn-challenges\Christian\StarWarsAPI5\Shared\Searcher.razor"
                                                                 OnClear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, " Clear");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
