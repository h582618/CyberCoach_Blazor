#pragma checksum "/Users/matia/ccBlazor/Components/GenerateExercise.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137cfe4da3eaed39fb215b10e23514159320ee59"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/generateexercise")]
    public partial class GenerateExercise : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.ccBlazor.Components.GenerateExercise.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 3 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                           this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "\n");
#nullable restore
#line 4 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
           List<Data.Exercise> exercisesGen = Generateexercises(days);


            if (exercisesGen != null)
            {
                int v = 1;
                foreach (Data.Exercise t in exercisesGen)
                {
                    if (t.newDay != null)
                    {


#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, @"                        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
                        ");
                __builder2.AddMarkupContent(5, "<p style=\"width:100%\">               </p>\n                        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "style", "\n        text-align: center;\n        max-width: 100%;\n        display: inline-block;\n        ");
                __builder2.AddAttribute(8, "class", "container");
                __builder2.AddMarkupContent(9, "\n                            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.AddMarkupContent(12, "\n                                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col");
                __builder2.AddMarkupContent(15, "\n                                    ");
                __builder2.OpenElement(16, "h3");
                __builder2.AddContent(17, " Dag ");
                __builder2.AddContent(18, 
#nullable restore
#line 24 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                                              v

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(19, " :  ");
                __builder2.AddContent(20, 
#nullable restore
#line 24 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                                                    t.newDay

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(21, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n");
#nullable restore
#line 28 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                        v++;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, "                        ");
                __builder2.AddMarkupContent(27, "<p> </p>\n                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "exercisesTxt");
                __builder2.AddMarkupContent(30, "\n                            ");
                __builder2.OpenElement(31, "span");
                __builder2.AddAttribute(32, "class", "exercises");
                __builder2.AddMarkupContent(33, "\n\n                                ");
                __builder2.OpenElement(34, "p");
                __builder2.AddAttribute(35, "style", "font-weight: bold;");
                __builder2.AddContent(36, "  ");
                __builder2.AddContent(37, 
#nullable restore
#line 36 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                                                                 t.name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n                                ");
                __builder2.OpenElement(39, "p");
                __builder2.AddContent(40, " Muscle targeted : ");
                __builder2.AddContent(41, 
#nullable restore
#line 37 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                                                       t.muscle_Targeted

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n                                ");
                __builder2.OpenElement(43, "p");
                __builder2.AddContent(44, " Equipment type : ");
                __builder2.AddContent(45, 
#nullable restore
#line 38 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                                                      t.equipment_Type

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n                                ");
                __builder2.AddMarkupContent(47, "<p> 4 X 8</p>\n                                ");
                __builder2.OpenElement(48, "img");
                __builder2.AddAttribute(49, "src", 
#nullable restore
#line 40 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"
                                           t.src

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(50, "width", "200");
                __builder2.AddAttribute(51, "height", "200");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n                        ");
                __builder2.AddMarkupContent(55, "<p>   </p>\n");
#nullable restore
#line 45 "/Users/matia/ccBlazor/Components/GenerateExercise.razor"

                    }
                }
            }
        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(56, "    ");
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.ccBlazor.Components.GenerateExercise
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