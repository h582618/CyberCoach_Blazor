#pragma checksum "/Users/matia/ccBlazor/Components/Wizard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c3e49597f26581a36237587f7f83effed0d59c"
// <auto-generated/>
#pragma warning disable 1591
namespace ccBlazor.Components
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
    public partial class Wizard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.ccBlazor.Components.Wizard.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 1 "/Users/matia/ccBlazor/Components/Wizard.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "id", 
#nullable restore
#line 2 "/Users/matia/ccBlazor/Components/Wizard.razor"
              Id

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(5, "ul");
                __builder2.AddAttribute(6, "class", "nav nav-pills nav-justified");
#nullable restore
#line 4 "/Users/matia/ccBlazor/Components/Wizard.razor"
             foreach (var step in Steps)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(7, "li");
                __builder2.AddAttribute(8, "id", "step-" + (
#nullable restore
#line 6 "/Users/matia/ccBlazor/Components/Wizard.razor"
                               StepsIndex(step) + 1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "class", "nav-item");
                __builder2.OpenElement(10, "a");
                __builder2.AddAttribute(11, "class", "nav-link" + " " + (
#nullable restore
#line 7 "/Users/matia/ccBlazor/Components/Wizard.razor"
                                         (ActiveStep == step) ? "active" : ""

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "href", "javascript: void(0)");
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/matia/ccBlazor/Components/Wizard.razor"
                                   e=> SetActive(step)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(14, 
#nullable restore
#line 8 "/Users/matia/ccBlazor/Components/Wizard.razor"
                                                          step.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 10 "/Users/matia/ccBlazor/Components/Wizard.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "id", "container-fluid");
                __builder2.AddContent(18, 
#nullable restore
#line 13 "/Users/matia/ccBlazor/Components/Wizard.razor"
             ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "btns");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "class", "btn btn-primary btn-lg");
                __builder2.AddAttribute(24, "type", "button");
                __builder2.AddAttribute(25, "disabled", 
#nullable restore
#line 18 "/Users/matia/ccBlazor/Components/Wizard.razor"
                            ActiveStepIx == 0

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/matia/ccBlazor/Components/Wizard.razor"
                                                          GoBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(27, "\n            Tilbake\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "class", "btn btn-primary btn-lg");
                __builder2.AddAttribute(31, "type", 
#nullable restore
#line 22 "/Users/matia/ccBlazor/Components/Wizard.razor"
                        IsLastStep ? "submit" : "button"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/matia/ccBlazor/Components/Wizard.razor"
                                                                     GoNext

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, 
#nullable restore
#line 23 "/Users/matia/ccBlazor/Components/Wizard.razor"
              IsLastStep ? "Send inn" : "Neste"

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ccBlazor.Components.Wizard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
