#pragma checksum "D:\Projets\Blazor\FileManager\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6103b76334207defd621c8c721b097f33566306a"
// <auto-generated/>
#pragma warning disable 1591
namespace FileManager.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projets\Blazor\FileManager\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projets\Blazor\FileManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projets\Blazor\FileManager\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager.Helpers.DragAndDrop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projets\Blazor\FileManager\_Imports.razor"
using FileManager.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projets\Blazor\FileManager\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projets\Blazor\FileManager\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Projets\Blazor\FileManager\_Imports.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.AddAttribute(1, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 2 "D:\Projets\Blazor\FileManager\Shared\MainLayout.razor"
                          ToastPosition.TopCenter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<FileManager.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddContent(16, 
#nullable restore
#line 13 "D:\Projets\Blazor\FileManager\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
