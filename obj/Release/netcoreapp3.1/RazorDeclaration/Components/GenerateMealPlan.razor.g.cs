// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 12 "/Users/matia/ccBlazor/_Imports.razor"
using ccBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/matia/ccBlazor/Components/GenerateMealPlan.razor"
using ccBlazor.Data;

#line default
#line hidden
#nullable disable
    public partial class GenerateMealPlan : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "/Users/matia/ccBlazor/Components/GenerateMealPlan.razor"
       

    List<Meal> meals = new List<Meal>();

    [Parameter]
    public double weight { get; set; }

    [Parameter]
    public double height { get; set; }

    [Parameter]
    public int age { get; set; }

    [Parameter]
    public String gender { get; set; }


    [Parameter]
    public int activityLevel { get; set; }

    [Parameter]
    public bool weightLoss { get; set; }

    [Parameter]
    public bool muscleIncrease { get; set; }

    [Parameter]
    public bool maintenance { get; set; }

    [Parameter]
    public bool fatLoss { get; set; }

    public double calories { get; set;}

    public double carbs  { get; set; }

    public double proteins { get; set; }

    public double fats { get; set; }

    public double sumCals { get; set; }

    public double sumProts { get; set; }

    public double sumCarbs { get; set; }

    public double sumFats { get; set; }



    protected override void OnInitialized()
    {
        meals.Add(new Meal("Frokost", "Torjes spesial",
            "100g havregryn 100g bær 30g peanøttsmør1 scoop proteinpulver" , 666, 45, 72, 22));
        meals.Add(new Meal("Lunsj", "Knekkebrød med pålegg",
            "4 Skiver(220g) fullkorn, med valgfritt pålegg. + proteinshake 1 scoops" , 685, 48, 94, 13));
        meals.Add(new Meal("Middag", "Kylling og ris",
            "200g Kylling, 120g ris, valgfri grønnsaker og ønsket saus. ", 631, 50, 101, 3));
        meals.Add(new Meal("Kvelds", "Brød med egg",
            "4 egg, 2 rundstykker (120g). Typ hatting eller tilsvarende.  + smør", 568, 42, 55, 20));

        meals.Add(new Meal("Middag", "Tortilla Pizza",
            "150-200g Karbonadedeig, 2 tortilla, ønsket grønnsaker, tomatsaus, ost, ønsket krydder", 761, 53, 72, 29));
        meals.Add(new Meal("Middag", "Hamburger",
            "2 valgfritt hamburgerbrød, 200 gram karbonadedeig,ketchup,salt og pepper,valgfri grønnsaker", 754, 60, 88, 18));
        meals.Add(new Meal("Middag", "Pasta",
        "200g Karbonadedeig, 150 gram pasta, 20 gram ost , tomatsaus, løk, valgfri grønnsaker.", 757, 52, 90, 21));



        double proteinb = 1.8;
        double carbob = 3.0;

        double proteinc = 2.4;
        double carboc = 2.0;

        double proteinm = 1.6;
        double carbom = 2.5;


        if (gender.ToUpper().Equals("MANN"))
        {
            calories = (88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age));
        }
        else
        {
            calories = (447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age));
        }

        switch (activityLevel)
        {
            case 1:
                calories = calories + 200;
                break;
            case 2:
                calories = calories + 400;
                break;
            case 3:
                calories = calories + 600;
                break;
            default:
                break;
        }



        if (weightLoss || fatLoss)
        {
            carbs = weight * carboc;
            proteins = weight * proteinc;
            calories = calories - 200;
        }
        else if (muscleIncrease)
        {
            carbs = weight * carbob;
            proteins = weight * proteinb;
            calories = calories + 500;
        }
        else
        {
            carbs = weight * carbom;
            proteins = weight * proteinm;
        }


        double fCals = calories * 0.30;

        calories = Math.Round(calories, 2);
        proteins = Math.Round(proteins, 2);
        carbs = Math.Round(carbs, 2);

        fats = Math.Round(fCals / 9, 2);



    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
