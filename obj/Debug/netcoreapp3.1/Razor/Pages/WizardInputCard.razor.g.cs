#pragma checksum "/Users/matia/ccBlazor/Pages/WizardInputCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7c09518190556995053e9b14a38f74eb10a6f3"
// <auto-generated/>
#pragma warning disable 1591
namespace ccBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/matia/ccBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matia/ccBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matia/ccBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/matia/ccBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/matia/ccBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/matia/ccBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/matia/ccBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/matia/ccBlazor/_Imports.razor"
using ccBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/matia/ccBlazor/_Imports.razor"
using ccBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/matia/ccBlazor/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/matia/ccBlazor/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class WizardInputCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
 if (WizardStep == CurrentStep)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card text-center w-50");
            __builder.AddMarkupContent(5, "\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.AddMarkupContent(8, "\n                ");
            __builder.AddContent(9, 
#nullable restore
#line 6 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
                 CardHeader

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "card-title");
            __builder.AddContent(17, 
#nullable restore
#line 9 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
                                        CardTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-text");
            __builder.AddContent(21, 
#nullable restore
#line 10 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
                                      CardText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n\n                ");
            __builder.AddContent(23, 
#nullable restore
#line 12 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n            ");
            __builder.AddMarkupContent(26, "<div class=\"card-footer\">\n            </div>\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 19 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/Users/matia/ccBlazor/Pages/WizardInputCard.razor"
           

    [Parameter]
    public int WizardStep { get; set; }

    [Parameter]
    public int CurrentStep { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string CardHeader { get; set; }

    [Parameter]
    public string CardTitle { get; set; }

    [Parameter]
    public string CardText { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
