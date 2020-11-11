// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FileManager.Components
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
#line 1 "D:\Projets\Blazor\FileManager\Components\Upload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class Upload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Projets\Blazor\FileManager\Components\Upload.razor"
       
    [Parameter] public string filePath { get; set; }
    [Parameter] public EventCallback<List<string>> onUploadFinished { get; set; }
    ElementReference inputTypeFileElement;
    long lastAnnounce = 0;
    List<string> filesList = new List<string>();
    int BufferSize { get; set; } = 20480;
    int? progress;
    bool uploadStarted { get; set; }
    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        uploadStarted = true;
        StateHasChanged();
        long totalCountSize = 0;
        int countSize = 0;
        lastAnnounce = 0;
        var chunkSize = Configuration.buffferMax;
        foreach (var file in e.GetMultipleFiles(10))
        {
            totalCountSize += file.Size;
        }
        foreach (var file in e.GetMultipleFiles(10))
        {
            var fileName = Path.Combine(filePath, file.Name);
            filesList.Add(fileName);
            using (var fs = file.OpenReadStream(long.MaxValue))
            {
                var buffer = new byte[chunkSize];
                int count;
                while ((count = await fs.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    using (var fsWrite = new FileStream(fileName, (count == 0 ? FileMode.Create : FileMode.Append)))
                    {
                        await fsWrite.WriteAsync(buffer, 0, count);
                        countSize += count;
                        progress = (int)(((decimal)countSize / totalCountSize) * 100);
                        if (progress > (lastAnnounce + 10))
                        {
                            this.StateHasChanged();
                            lastAnnounce = progress.Value;
                        }
                    }
                }
            }
        }

        progress = null;
        await onUploadFinished.InvokeAsync(filesList);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
