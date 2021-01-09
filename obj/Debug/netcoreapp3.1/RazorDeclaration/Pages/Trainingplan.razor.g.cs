// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "/Users/matia/ccBlazor/Pages/Trainingplan.razor"
using ccBlazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/treningsplan")]
    public partial class Trainingplan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/Users/matia/ccBlazor/Pages/Trainingplan.razor"
               
            public int currentDayInt { get; set; } = 1;

            public String currentDay { get; set; }

            public int week { get; set; } = 1;

            protected override void OnInitialized()
            {
                if (ViewModel.submitted) {
                    this.currentDay = ViewModel.preferedDays[0];
                }
            }


            public void setCurrentDay(String t, int i)
            {
                this.currentDay = t;
                this.currentDayInt = i;
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
            public String dayToNorwegian(String day)
            {
                switch (day)
                {
                    case "monday":
                        return "Mandag";
                    case "tuesday":
                        return "Tirsdag";
                    case "wednesday":
                        return "Onsdag";
                    case "thursday":
                        return "Torsdag";
                    case "friday":
                        return "Friday";
                    case "saturday":
                        return "Lørdag";
                    case "sunday":
                        return "Sunday";
                    default:
                        return " ";
                }
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonInf_Model ViewModel { get; set; }
    }
}
#pragma warning restore 1591