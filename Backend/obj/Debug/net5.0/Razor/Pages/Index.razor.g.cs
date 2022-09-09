#pragma checksum "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a920267abb35663cfef55dfa56df2426456840e"
// <auto-generated/>
#pragma warning disable 1591
namespace Backend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Backend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor"
using Backend.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "<h3>BTM</h3>\r\n    &nbsp;&nbsp;&nbsp;\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse");
            __builder.AddAttribute(7, "id", "navbarSupportedContent");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "navbar-nav me-auto mb-2 mb-lg-0");
            __builder.AddMarkupContent(10, "<li class=\"nav-item\"><button type=\"button\" class=\"btn btn-secondary\" disabled>Main Page</button>\r\n            &nbsp;&nbsp;&nbsp;\r\n        </li>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Roles", "Admin");
            __builder.AddAttribute(13, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(14, "li");
                __builder2.AddAttribute(15, "class", "nav-item");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "type", "button");
                __builder2.AddAttribute(18, "class", "btn btn-primary");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor"
                                                                            openUsers

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(20, "Users");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                &nbsp;&nbsp;&nbsp;\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
            __builder.AddAttribute(24, "Roles", "Admin,Employee");
            __builder.AddAttribute(25, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(26, "li");
                __builder2.AddAttribute(27, "class", "nav-item");
                __builder2.OpenElement(28, "button");
                __builder2.AddAttribute(29, "type", "button");
                __builder2.AddAttribute(30, "class", "btn btn-success");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor"
                                                                            openMovies

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(32, "Movies");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                &nbsp;&nbsp;&nbsp;\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(35);
            __builder.AddAttribute(36, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor"
                                  Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "href", "javascript:void(0)");
                __builder2.AddContent(40, "Logout");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(41, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor"
                                  openLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "class", "btn btn-success");
                __builder2.AddContent(45, "Login");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Index.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }

    private async Task DisplayGreetingAlert()
    {
        var authState = await authenticationState;
        var message = $"Hello {authState.User.Identity.Name}";
        await js.InvokeVoidAsync("alert", message);
    }

    private async Task Logout()
    {
        var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
        await customAuthStateProvider.UpdateAuthenticationState(null);
        _navigationManager.NavigateTo("/", true);
    }

    private void openUsers()
    {
        _navigationManager.NavigateTo("/users");
    }

    private void openMovies()
    {
        _navigationManager.NavigateTo("/movies");
    }

    private void openLogin()
    {
        _navigationManager.NavigateTo("/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
