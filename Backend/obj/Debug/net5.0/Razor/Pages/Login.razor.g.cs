#pragma checksum "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67ecd813b02c1eae5b52249a28ca6fde4105155a"
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
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
using Backend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
using Backend.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-4 offset-lg-4 pt-4 pb-4 border");
            __builder.AddMarkupContent(4, "<div class=\"mb-3 text-center\"><h3>Login</h3></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mb-3");
            __builder.AddMarkupContent(7, "<label>User Name</label>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "User Name....");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
                          model.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Username = __value, model.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "mb-3");
            __builder.AddMarkupContent(16, "<label>Password</label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "password");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "Password....");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
                          model.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Password = __value, model.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "mb-3 d-grid gap-2");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
                              Authenticate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddContent(29, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Login.razor"
       
    private class Model
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    IEnumerable<User> users { get; set; }
    private Model model = new Model();
    private Encryption encryption = new Encryption();

    protected override async Task OnInitializedAsync()
    {
        users = await _userService.GetUsers();
    }

    private async Task Authenticate()
    {   
        var userAcount = users.First(x => x.Username.Equals(model.Username));
        string password = encryption.DecodeFrom64(userAcount.Password);
        if(userAcount is null || password != model.Password)
        {
            await js.InvokeVoidAsync("alert","Invalid Username or password");
            return;
        }
        var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
        await customAuthStateProvider.UpdateAuthenticationState(new UserSession {
                Username = userAcount.Username,
                Role = userAcount.Role
        });
        _navigationManager.NavigateTo("/",true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService _userService { get; set; }
    }
}
#pragma warning restore 1591
