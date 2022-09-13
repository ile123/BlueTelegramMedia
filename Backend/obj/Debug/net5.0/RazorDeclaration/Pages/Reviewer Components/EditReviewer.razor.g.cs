// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Backend.Pages.Reviewer_Components
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
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\EditReviewer.razor"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\EditReviewer.razor"
using Backend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\EditReviewer.razor"
           [Authorize(Roles = "Admin, Employee")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditReviewer/{ReviewerId}")]
    public partial class EditReviewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\EditReviewer.razor"
       
    [Parameter]
    public string ReviewerId { get; set; }

    public Reviewer reviewer { get; set; }

    protected override async Task OnInitializedAsync()
    {
        reviewer = await _reviewerService.GetReviewerAsync(int.Parse(ReviewerId));
    }
    private async Task UpdateReviewerAsync()
    {
        await _reviewerService.UpdateReviewerAsync(reviewer);
        Close();
    }
    private void Close()
    {
        _navigationManager.NavigateTo("/reviewers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ReviewerService _reviewerService { get; set; }
    }
}
#pragma warning restore 1591
