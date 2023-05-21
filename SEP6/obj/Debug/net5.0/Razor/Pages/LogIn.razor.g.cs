#pragma checksum "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\LogIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89348820c42cd9e9e4cf8584ee6f21e4ca12e38"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LogIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "loginContainer");
            __builder.AddAttribute(2, "b-iwscbyh8bk");
            __builder.AddMarkupContent(3, "<div class=\"logo-container\" b-iwscbyh8bk><img src=\"images/Logo.jpg\" alt=\"Imperium Movie Logo\" class=\"logo-img\" b-iwscbyh8bk></div>\r\n\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "class", "formContainer");
            __builder.AddAttribute(6, "method", "POST");
            __builder.AddAttribute(7, "action", "/login");
            __builder.AddAttribute(8, "b-iwscbyh8bk");
            __builder.AddMarkupContent(9, "<div class=\"form-group\" b-iwscbyh8bk><label for=\"username\" b-iwscbyh8bk>Username</label>\r\n            <input type=\"text\" class=\"form-control custom-input\" name=\"username\" placeholder=\"Enter your username\" required b-iwscbyh8bk></div>\r\n        ");
            __builder.AddMarkupContent(10, "<div class=\"form-group\" b-iwscbyh8bk><label for=\"password\" b-iwscbyh8bk>Password</label>\r\n            <input type=\"password\" class=\"form-control custom-input\" name=\"password\" placeholder=\"Enter your password\" required b-iwscbyh8bk></div>\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "text-center");
            __builder.AddAttribute(13, "b-iwscbyh8bk");
            __builder.AddMarkupContent(14, "<button type=\"submit\" class=\"btn custom-button\" b-iwscbyh8bk>Log in</button>\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn custom-button ml-2");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\LogIn.razor"
                                                             ContinueAsGuest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-iwscbyh8bk");
            __builder.AddContent(19, "Continue as a guest");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n    ");
            __builder.AddMarkupContent(21, "<div class=\"text-center mt-3\" b-iwscbyh8bk>\r\n        Don\'t have an account? <a href=\"/register\" class=\"register-link\" b-iwscbyh8bk>Register here!</a></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\LogIn.razor"
       

    private void ContinueAsGuest()
    {
        Navigation.NavigateTo("/mainpage");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
