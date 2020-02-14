#pragma checksum "D:\Projets\Blazor\FileManager\FileManager\Components\DropTarget.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d8bbb1f807f222c990e3cfe105fc8d4500bdeb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FileManager.FileManager.Components
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
#line 1 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager.Helpers.DragAndDrop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using FileManager.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Projets\Blazor\FileManager\FileManager\_Imports.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class DropTarget<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Projets\Blazor\FileManager\FileManager\Components\DropTarget.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Zone { get; set; }

    [Parameter]
    public  Action<T,T> Drop { get; set; }

    [Parameter]
    public T DataDest { get; set; }

    void OnDrop()
    {
        if (Drop != null && DragAndDropHelper.Accepts(Zone))
        {
            Drop((T)DragAndDropHelper.Data, DataDest);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragAndDropHelper DragAndDropHelper { get; set; }
    }
}
#pragma warning restore 1591
