#pragma checksum "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d77a8a027137bba285af2c9c6dc389397b7ec79"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication11
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using WebApplication11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\_Imports.razor"
using WebApplication11.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 4 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(11, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(13);
                    __builder3.AddAttribute(14, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 7 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(16, "\r\n                ");
                        __builder4.AddMarkupContent(17, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591