#pragma checksum "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\LogIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d334d3fac49d7f2992e4bcc2d2be3142faa350"
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
            __builder.AddMarkupContent(0, @"<div class=""loginContainer"" b-iwscbyh8bk><h3 class=""text-center font-style"" b-iwscbyh8bk>Imperium Movie</h3>

    <form class=""formContainer"" method=""POST"" action=""/login"" b-iwscbyh8bk><div class=""form-group"" b-iwscbyh8bk><label for=""username"" b-iwscbyh8bk>Username</label>
            <input type=""text"" class=""form-control custom-input"" name=""username"" placeholder=""Enter your username"" required b-iwscbyh8bk></div>
        <div class=""form-group"" b-iwscbyh8bk><label for=""password"" b-iwscbyh8bk>Password</label>
            <input type=""password"" class=""form-control custom-input"" name=""password"" placeholder=""Enter your password"" required b-iwscbyh8bk></div>
        <div class=""text-center"" b-iwscbyh8bk><button type=""submit"" class=""btn custom-button"" b-iwscbyh8bk>Log in</button></div></form></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591