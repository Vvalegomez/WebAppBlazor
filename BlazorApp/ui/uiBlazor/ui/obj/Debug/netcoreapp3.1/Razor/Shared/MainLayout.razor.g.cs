#pragma checksum "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8109045150c6d674f7a851b5b48a84d78c216ed7"
// <auto-generated/>
#pragma warning disable 1591
namespace ui.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\_Imports.razor"
using ui.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3 class=\"d-flex justify-content-center\">Front WebApp Blazor</h3>\r\n\r\n    ");
            __builder.OpenElement(4, "nav");
            __builder.AddAttribute(5, "class", "navbar navbar-expand-sm bg-light navbar-dark");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "navbar-nav");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "nav-item");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "m-1 btn btn-light btn-outline-primary");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "href", "");
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n                        Inicio\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav-item");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "m-1 btn btn-light btn-outline-primary");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "href", "Departament");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                        Departament\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "m-1 btn btn-light btn-outline-primary");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "href", "Employee");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                        Employee\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n    ");
            __builder.AddContent(51, 
#nullable restore
#line 45 "C:\Users\Joaquin Auce\source\repos\BlazorApp\ui\uiBlazor\ui\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591