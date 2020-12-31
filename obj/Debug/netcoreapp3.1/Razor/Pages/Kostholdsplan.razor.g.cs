#pragma checksum "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30d176b3e2545080e6eaa5dd5675ffba505c85f"
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
#line 2 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
using ccBlazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/kostholdsplan")]
    public partial class Kostholdsplan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddMarkupContent(1, "Måltidsplan for ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                     ViewModel.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "h4");
            __builder.AddMarkupContent(5, " Mål ");
            __builder.AddContent(6, 
#nullable restore
#line 5 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
          findGoal(ViewModel.weightLoss,ViewModel.fatLoss, ViewModel.muscleIncrease, ViewModel.maintenance)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenComponent<ccBlazor.Components.GenerateMealPlan>(8);
            __builder.AddAttribute(9, "weight", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 6 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                           ViewModel.weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 6 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                                                      ViewModel.height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "age", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                                                                              ViewModel.age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "gender", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                           ViewModel.gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "activityLevel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                                                             ViewModel.activityLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "weightLoss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                               ViewModel.weightLoss

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "muscleIncrease", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                                                                       ViewModel.muscleIncrease

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "maintenance", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                                ViewModel.maintenance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "fatLoss", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
                                                                    ViewModel.fatLoss

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "/Users/matia/ccBlazor/Pages/Kostholdsplan.razor"
  


    String findGoal(bool weightLoss, bool fatLoss, bool muscleIncrease, bool maintenance)
    {
        if (weightLoss)
        {
            return "Vektnedgang";
        } else if (fatLoss)
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
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonInf_Model ViewModel { get; set; }
    }
}
#pragma warning restore 1591
