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
#line 2 "/Users/matia/ccBlazor/Pages/WizardDemo.razor"
using ccBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 358 "/Users/matia/ccBlazor/Pages/WizardDemo.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/om_deg")]
    public partial class WizardDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 358 "/Users/matia/ccBlazor/Pages/WizardDemo.razor"
                             

    private static string[] bodyParts = {  "Img/Skulder.jpg", "Img/Rygg.jpg",
                        "Img/Bryst.jpg", "Img/Armer.jpg", "Img/Kjernen.jpg",
                        "Img/Rumpe.jpg", "Img/Bein.jpg",
                        "Img/Neutral.jpg" };

    private String allergy;

    public String dislike;

    public bool allergies { get; set; } = false;

    public bool foodDislikes { get; set; } = false;

    public void addAllergy()
    {
        if (!string.IsNullOrWhiteSpace(allergy))
        {
            ViewModel.addAllergy(char.ToUpper(allergy[0]) + allergy.Substring(1));
            allergy = String.Empty;
        }

    }

    public void addDislikes()
    {
        if (!string.IsNullOrWhiteSpace(dislike))
        {
            ViewModel.addDislikes(char.ToUpper(dislike[0]) + dislike.Substring(1));
            dislike = String.Empty;
        }

    }


    private string bodyPart = bodyParts[7];
    public void skuldre()
    {
        this.bodyPart = bodyParts[0];
    }
    public void rygg()
    {
        this.bodyPart = bodyParts[1];
    }
    public void bryst()
    {
        this.bodyPart = bodyParts[2];
    }
    public void armer()
    {
        this.bodyPart = bodyParts[3];
    }
    public void kjernen()
    {
        this.bodyPart = bodyParts[4];
    }

    public void rumpe()
    {
        this.bodyPart = bodyParts[5];
    }

    public void bein()
    {
        this.bodyPart = bodyParts[6];
    }
    public void neutral()
    {
        this.bodyPart = bodyParts[7];
    }

    public void checkDays(EventArgs eventArgs)
    {

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PersonInf_Model ViewModel { get; set; }
    }
}
#pragma warning restore 1591
