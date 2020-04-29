#pragma checksum "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/BCell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11e351139843dd37cf51855ee1c537373045646"
// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
    public partial class BCell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/BCell.razor"
             uscita

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 3 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/BCell.razor"
                             stile

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 4 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/BCell.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/daviderusso1984/Desktop/progetti_nuget/BlazorFlex/Test/BCell.razor"
      
    [Parameter]
    public int Order { get; set; } = 0;

    [Parameter]
    public string Width { get; set; } = "";

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private string uscita { get; set; }

    private string stile { get; set; }

    protected override void OnInitialized()
    {
        uscita = "cell_base ";
        stile = "";
        ordine();
        dimensione();
    }

    private void dimensione()
    {
        if (string.IsNullOrWhiteSpace(Width))
        {
            return;
        }
        if (Width.Contains("px"))
        {
            stile += "flex-basis: " + Width + ";";
            return;
        }
        if (Width.Contains("%"))
        {
            stile += "flex: " + Width + ";";
            return;
        }
        int num = 0;
        try
        {
            num = Convert.ToInt32(Width);
        }
        catch (System.Exception)
        {

            throw;
        }
        stile += "flex: " + Width.ToString() + ";";
    }

    private void ordine()
    {
        stile += "order: " + Order.ToString() + ";";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
