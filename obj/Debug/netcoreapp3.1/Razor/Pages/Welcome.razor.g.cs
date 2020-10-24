#pragma checksum "/Users/matia/ccBlazor/Pages/Welcome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5bcfa39fd5872e3a2826c553082ad1ea242eaba"
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
            __builder.AddMarkupContent(0, "<h4> Velkommen til CyberCoach</h4>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                  welcomeScheme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"age\" class=\"col-sm-2 col-form-label\">\n            Alder\n        </label>\n        ");
                __Blazor.ccBlazor.Pages.Welcome.TypeInference.CreateInputNumber_0(__builder2, 14, 15, "width:5%", 16, "age", 17, 
#nullable restore
#line 12 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                                            welcomeScheme.age

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => welcomeScheme.age = __value, welcomeScheme.age)), 19, () => welcomeScheme.age);
                __builder2.AddMarkupContent(20, "\n   \n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row");
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.AddMarkupContent(25, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">\n            Kjønn\n        </label>\n        ");
                __Blazor.ccBlazor.Pages.Welcome.TypeInference.CreateInputSelect_1(__builder2, 26, 27, 
#nullable restore
#line 19 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                  welcomeScheme.gender

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => welcomeScheme.gender = __value, welcomeScheme.gender)), 29, () => welcomeScheme.gender, 30, (__builder3) => {
                    __builder3.AddMarkupContent(31, "\n");
#nullable restore
#line 20 "/Users/matia/ccBlazor/Pages/Welcome.razor"
             foreach (var gender in Enum.GetValues(typeof(Gender)))
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(32, "                ");
                    __builder3.OpenElement(33, "option");
                    __builder3.AddAttribute(34, "value", 
#nullable restore
#line 22 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(35, 
#nullable restore
#line 22 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                         gender

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\n");
#nullable restore
#line 23 "/Users/matia/ccBlazor/Pages/Welcome.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(37, "        ");
                }
                );
                __builder2.AddMarkupContent(38, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row");
                __builder2.AddMarkupContent(42, "\n        ");
                __builder2.AddMarkupContent(43, "<label for=\"weight\" class=\"col-sm-2 col-form-label\">\n            Vekt\n        </label>\n        ");
                __Blazor.ccBlazor.Pages.Welcome.TypeInference.CreateInputNumber_2(__builder2, 44, 45, "width:5%", 46, "weight", 47, 
#nullable restore
#line 30 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                                              welcomeScheme.weight

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => welcomeScheme.weight = __value, welcomeScheme.weight)), 49, () => welcomeScheme.weight);
                __builder2.AddMarkupContent(50, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group row");
                __builder2.AddMarkupContent(54, "\n        ");
                __builder2.AddMarkupContent(55, "<label for=\"daysWeek\" class=\"col-sm-2 col-form-label\">\n            Antall økter i uken\n        </label>\n        ");
                __Blazor.ccBlazor.Pages.Welcome.TypeInference.CreateInputSelect_3(__builder2, 56, 57, "daysWeek", 58, 
#nullable restore
#line 36 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                                welcomeScheme.daysWeek

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => welcomeScheme.daysWeek = __value, welcomeScheme.daysWeek)), 60, () => welcomeScheme.daysWeek, 61, (__builder3) => {
                    __builder3.AddMarkupContent(62, "\n");
#nullable restore
#line 37 "/Users/matia/ccBlazor/Pages/Welcome.razor"
             for(int i = 1; i < 8; i++)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(63, "                ");
                    __builder3.OpenElement(64, "option");
                    __builder3.AddAttribute(65, "value", 
#nullable restore
#line 39 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(66, 
#nullable restore
#line 39 "/Users/matia/ccBlazor/Pages/Welcome.razor"
                                    i

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n");
#nullable restore
#line 40 "/Users/matia/ccBlazor/Pages/Welcome.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(68, "        ");
                }
                );
                __builder2.AddMarkupContent(69, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n    ");
                __builder2.AddMarkupContent(71, "<button type=\"submit\">Lag plan</button>\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\n");
#nullable restore
#line 45 "/Users/matia/ccBlazor/Pages/Welcome.razor"
 if(display == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "    ");
            __builder.OpenComponent<ccBlazor.Pages.GenerateExercise>(74);
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\n");
#nullable restore
#line 48 "/Users/matia/ccBlazor/Pages/Welcome.razor"
    display = false;
}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.ccBlazor.Pages.Welcome
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
