using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BXDavies.Pages;

public partial class Home : ComponentBase
{
    [Inject] private IJSRuntime JS { get; set; }
    

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync("particlesStart");
        }
    }

}