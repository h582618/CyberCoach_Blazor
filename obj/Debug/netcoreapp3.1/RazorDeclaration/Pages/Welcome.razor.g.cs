#pragma checksum "/Users/matia/ccBlazor/Pages/Welcome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310377fa707c21170c00a561f93b1026a6b65328"
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
#line 3 "/Users/matia/ccBlazor/Pages/Welcome.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/welcome")]
    public partial class Welcome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/Users/matia/ccBlazor/Pages/Welcome.razor"
       

    private WeclomeScheme welcomeScheme = new WeclomeScheme();
    private Boolean display { get; set; } = false;
    private void HandleValidSubmit()
    {
        display = true;
    }
    public class WeclomeScheme
    {
        //[StringLength(10, ErrorMessage = "Name is too long.")]
        [Required]
        public Gender gender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public double weight { get; set; }
        [Required]
        public String daysWeek { get; set; }



    }
    public enum Gender
    {
        Mann,
        Dame,
        Annet
    };
    public enum Goal
    {
        Vektnedgang,
        Muskeløkning,
        Vedlikehold
        
    };



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
