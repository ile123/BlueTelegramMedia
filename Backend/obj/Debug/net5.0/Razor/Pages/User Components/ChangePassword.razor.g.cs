#pragma checksum "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7740542b89ca988dcb3cda5638653bec8fd0f0f"
// <auto-generated/>
#pragma warning disable 1591
namespace Backend.Pages.User_Components
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
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
using Backend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
using Backend.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChangePassword/{UserId}")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Change Password</h3>");
#nullable restore
#line 12 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
 if(user == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div>Loading........</div>");
#nullable restore
#line 15 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
                                        UpdateUserAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "userFields");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "mb-3");
                __builder2.AddMarkupContent(10, "<label for=\"password\" class=\"form-label\">Password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "password");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "@bind", "password");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "mb-3");
                __builder2.AddMarkupContent(18, "<label for=\"repeatPassword\" class=\"form-label\">Repeat Password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "repeatPassword");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "@bind", "repeatPassword");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n     ");
                __builder2.AddMarkupContent(24, "<button type=\"submit\"><span class=\"bi bi-prescription\"></span>\r\n                Change Password\r\n     </button>\r\n     ");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "type", "button");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
                                     Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-media-skip-backward\"></span>\r\n                Close\r\n     ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 40 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
       
    [Parameter]
    public string UserId { get; set; }

    public User user { get; set; }
    private Encryption encryption { get; set; }

    public string password { get; set; } = string.Empty;
    public string repeatPassword { get; set; } = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        encryption = new Encryption();
        user = await _userService.GetUserAsync(int.Parse(UserId));
        user.Username = string.Empty;
        user.Firstname = string.Empty;
        user.Lastname = string.Empty;
        user.Email = string.Empty;
        user.Password = string.Empty;
        user.Role = string.Empty;
    }

    private async Task UpdateUserAsync()
    {
        string temp = encryption.EncodePasswordToBase64(password);
        user.Password = temp;
        await _userService.UpdateUserAsync(user);
        Close();
    }
    private void Close()
    {
        _navigationManager.NavigateTo("/users");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService _userService { get; set; }
    }
}
#pragma warning restore 1591