#pragma checksum "C:\Users\user\source\repos\BlazorDependencyInjection\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8866e7ac3cd23841b6e8d0668a5f20bf263bb5bf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDependencyInjection.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using BlazorDependencyInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\BlazorDependencyInjection\_Imports.razor"
using BlazorDependencyInjection.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorDependencyInjection.Pages.Counter.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorDependencyInjection\Pages\Counter.razor"
                       currentCount

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddMarkupContent(3, "<h1>Counter</h1>\r\n\r\n    ");
                __builder2.OpenElement(4, "p");
                __builder2.AddContent(5, "Current count: ");
                __builder2.AddContent(6, 
#nullable restore
#line 7 "C:\Users\user\source\repos\BlazorDependencyInjection\Pages\Counter.razor"
                       currentCount.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "button");
                __builder2.AddAttribute(9, "class", "btn btn-primary");
                __builder2.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\user\source\repos\BlazorDependencyInjection\Pages\Counter.razor"
                                              currentCount.Increment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(11, "Click me");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenComponent<BlazorDependencyInjection.Shared.CountChild>(13);
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\user\source\repos\BlazorDependencyInjection\Pages\Counter.razor"
       
    private CountModel currentCount = new CountModel();
    
    protected override void OnInitialized()
    {
        currentCount.PropertyChanged += (sender, args) => StateHasChanged();
    }
    
    public void Dispose()
    {
        currentCount.PropertyChanged -= (sender, args) => StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorDependencyInjection.Pages.Counter
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
