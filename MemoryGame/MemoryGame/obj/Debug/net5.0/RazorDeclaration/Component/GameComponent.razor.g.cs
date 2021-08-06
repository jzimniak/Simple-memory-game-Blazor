// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MemoryGame.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using MemoryGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using MemoryGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\_Imports.razor"
using MemoryGame.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class GameComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
       

    private int amount { get; set; }
    private bool[,] flipped { get; set; }
    private int[,] flippedindex { get; set; }
    private bool isfunctionrunning { get; set; }
    [Parameter]
    public string[,] names { get; set; }

    protected override void OnInitialized()
    {
        flippedindex = new int[2,2];
        flippedindex[0, 0] = -1;
        flippedindex[0, 1] = -1;
        flippedindex[1, 0] = -1;
        flippedindex[1, 1] = -1;
        amount = 2;
        flipped = new bool[amount, amount];
    }
    private async Task flip(string index,int i , int j)
    {
        if (!isfunctionrunning)
        {
            isfunctionrunning = true;
            if (!flipped[i, j])
            {
                if (flippedindex[0, 0] == -1)
                {
                    await JsRuntime.InvokeAsync<string>("flip", index);
                    flipped[i, j] = true;
                    flippedindex[0, 0] = i;
                    flippedindex[0, 1] = j;
                }
                else
                {
                    await JsRuntime.InvokeAsync<string>("flip", index);
                    System.Threading.Thread.Sleep(500);
                    flipped[i, j] = true;
                    flippedindex[1, 0] = i;
                    flippedindex[1, 1] = j;
                    if (names[flippedindex[0, 0], flippedindex[0, 1]]!=names[i,j])
                    {
                        await JsRuntime.InvokeAsync<string>("flipback", flippedindex[0, 0].ToString() + flippedindex[0, 1].ToString());
                        await JsRuntime.InvokeAsync<string>("flipback", flippedindex[1, 0].ToString() + flippedindex[1, 1].ToString());
                        flipped[i, j] = false;
                        flipped[flippedindex[0, 0], flippedindex[0, 1]] = false;
                    }

                    flippedindex[0, 0] = -1;
                    flippedindex[0, 1] = -1;
                    flippedindex[1, 0] = -1;
                    flippedindex[1, 1] = -1;
                }
            }
            isfunctionrunning = false;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591