#pragma checksum "C:\Users\user\source\repos\BlazorDependencyInjection\Shared\CountChild.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7644c10924cbed90dc0825ad17a5600db152c978"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDependencyInjection.Shared
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
    public partial class CountChild : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Count child</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count is : ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\user\source\repos\BlazorDependencyInjection\Shared\CountChild.razor"
                       myCounter.MyCounterValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\user\source\repos\BlazorDependencyInjection\Shared\CountChild.razor"
                                           IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n    +1 from\r\n    child\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\user\source\repos\BlazorDependencyInjection\Shared\CountChild.razor"
       
    private void IncrementCount()
    {
        myCounter.MyCounterValue++;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonCounter myCounter { get; set; }
    }
}
#pragma warning restore 1591
