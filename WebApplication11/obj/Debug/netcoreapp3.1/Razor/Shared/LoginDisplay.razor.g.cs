#pragma checksum "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c17282c921b163ee2af0e6f58f9123a71bce645c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication11.Shared
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
    public partial class LoginDisplay : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "Identity/Account/Manage");
                __builder2.AddContent(5, "Hello, ");
#nullable restore
#line 3 "C:\Users\Anastasiia.Posulikhi\RiderProjects\SmokeBundledMSBuild\WebApplication11\Shared\LoginDisplay.razor"
__builder2.AddContent(6, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<form method=\"post\" action=\"Identity/Account/LogOut\">\r\n            <button type=\"submit\" class=\"nav-link btn btn-link\">Log out</button>\r\n        </form>\r\n    ");
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<a href=\"Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(13, "<a href=\"Identity/Account/Login\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
