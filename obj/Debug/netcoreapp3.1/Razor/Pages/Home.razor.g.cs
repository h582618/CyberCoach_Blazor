#pragma checksum "/Users/matia/ccBlazor/Pages/Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb68790afa92d80aa3f99020422b909e75a7c1f5"
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
#nullable restore
#line 13 "/Users/matia/ccBlazor/_Imports.razor"
using ccBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/matia/ccBlazor/_Imports.razor"
using ccBlazor.Data.Splits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/matia/ccBlazor/_Imports.razor"
using ccBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matia/ccBlazor/Pages/Home.razor"
using ccBlazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h5");
            __builder.AddAttribute(1, "class", "card-title");
            __builder.AddContent(2, 
#nullable restore
#line 6 "/Users/matia/ccBlazor/Pages/Home.razor"
                         ViewModel.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "h5");
            __builder.AddAttribute(5, "class", "card-title");
            __builder.AddMarkupContent(6, " Nåværende vekt ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "/Users/matia/ccBlazor/Pages/Home.razor"
                                        ViewModel.weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.OpenElement(9, "h5");
            __builder.AddAttribute(10, "class", "card-title");
            __builder.AddMarkupContent(11, " Mål ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "/Users/matia/ccBlazor/Pages/Home.razor"
                             findGoal(ViewModel.weightLoss, ViewModel.fatLoss, ViewModel.muscleIncrease, ViewModel.maintenance)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/matia/ccBlazor/Pages/Home.razor"
       
    protected override async Task OnInitializedAsync()
    {
        if (!ViewModel.submitted)
        {
            Navigation.NavigateTo("/om_deg");
        }

    }
    String findGoal(bool weightLoss, bool fatLoss, bool muscleIncrease, bool maintenance)
    {
        if (weightLoss)
        {
            return "Vektnedgang";
        }
        else if (fatLoss)
        {
            return "Fett reduksjon";
        }
        else if (muscleIncrease)
        {
            return "Muskeløkning";
        }
        else
        {
            return "Vedlikehold";
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonInf_Model ViewModel { get; set; }
    }
}
#pragma warning restore 1591
