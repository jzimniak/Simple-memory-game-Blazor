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
#nullable restore
#line 2 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

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
#line 81 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
       
    [Parameter]
    public string[,] iconsPathMatrix { get; set; }

    private bool isGameOver { get; set; }
    private bool isFlipCardRunning { get; set; }

    private bool[,] flippedCardsMatrix { get; set; }
    private int[,] flippeCardPairIndex { get; set; }

    private double timeSEC  = 0;
    private double difficultyTime { get; set; }

    private string bestTime { get; set; }
    private string gameOverStyle { get; set; }

    private System.Timers.Timer timer { get; set; }

    protected async override Task OnInitializedAsync()
    {
        componentsService.gameComponent = this;
        var score = await BrowserStorage.GetAsync<string>("Score_" + settings.amount + "_" + settings.difficulty);
        if (score.Success)
        {
            bestTime = score.Value;
        }

        timer = new System.Timers.Timer(100);
        switch (settings.difficulty)
        {
            case 0:
                timer.Elapsed += TimeUPEvent;
                timer.Enabled = true;
                break;
            case 1:
                switch (settings.amount)
                {
                    case 2:
                        timeSEC = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        timeSEC = 40;
                        difficultyTime = 40;
                        break;
                    case 6:
                        timeSEC = 90;
                        difficultyTime = 90;
                        break;
                    case 8:
                        timeSEC = 160;
                        difficultyTime = 160;
                        break;
                    default:
                        break;
                }
                timer.Elapsed += TimeDOWNEvent;
                timer.Enabled = true;
                break;
            case 2:
                switch (settings.amount)
                {
                    case 2:
                        timeSEC = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        timeSEC = 80;
                        difficultyTime = 80;
                        break;
                    case 6:
                        timeSEC = 180;
                        difficultyTime = 180;
                        break;
                    case 8:
                        timeSEC = 320;
                        difficultyTime = 320;
                        break;
                    default:
                        break;
                }
                timer.Elapsed += TimeDOWNEvent;
                timer.Enabled = true;
                break;
            default:
                break;
        }

        flippeCardPairIndex = new int[2, 2];
        flippeCardPairIndex[0, 0] = -1;
        flippeCardPairIndex[0, 1] = -1;
        flippeCardPairIndex[1, 0] = -1;
        flippeCardPairIndex[1, 1] = -1;
        flippedCardsMatrix = new bool[settings.amount, settings.amount];
    }

    private string ConvertTime(double seconds)
    {
        return string.Format(@"{0:mm\:ss\.f}", TimeSpan.FromSeconds(seconds));
    }

    private void TimeUPEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        timeSEC += 0.1;
        InvokeAsync(StateHasChanged);

    }

    private void TimeDOWNEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        timeSEC -= 0.1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 192 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
         if (timeSEC <= 0)
        {
            timer.Stop();
            isGameOver = true;
            gameOverStyle = "pointer-events: none;";
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 197 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
         
        InvokeAsync(StateHasChanged);
    }

    private async Task ResetGame()
    {
        timer.Stop();
        isGameOver = false;
        gameOverStyle = "pointer-events: none;";
        StateHasChanged();

        for (int i = 0; i < flippedCardsMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < flippedCardsMatrix.GetLength(1); j++)
            {
                if (flippedCardsMatrix[i, j])
                {
                    await JsRuntime.InvokeAsync<string>("flipback", i.ToString() + j.ToString());
                }
            }
        }
        await Task.Delay(500);

        iconsPathMatrix = new string[settings.amount, settings.amount];
        var random = new Random();
        var randomOrderOfNumbers = Enumerable.Range(0, settings.amount * settings.amount / 2).Select(x => x).Concat(Enumerable.Range(0, settings.amount * settings.amount / 2).Select(x => x)).OrderBy(x => random.Next()).Take(settings.amount * settings.amount).ToList();
        int index = 0;

        for (int i = 0; i < settings.amount; i++)
        {
            for (int j = 0; j < settings.amount; j++)
            {
                iconsPathMatrix[i, j] = "\\icons\\" + randomOrderOfNumbers[index] + ".svg";
                index++;
            }
        }

        timer = new System.Timers.Timer(100);

        switch (settings.difficulty)
        {
            case 0:
                timeSEC = 0;
                timer.Elapsed += TimeUPEvent;
                timer.Enabled = true;
                break;
            case 1:
                switch (settings.amount)
                {
                    case 2:
                        timeSEC = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        timeSEC = 40;
                        difficultyTime = 40;
                        break;
                    case 6:
                        timeSEC = 90;
                        difficultyTime = 90;
                        break;
                    case 8:
                        timeSEC = 160;
                        difficultyTime = 160;
                        break;
                    default:
                        break;
                }
                timer.Elapsed += TimeDOWNEvent;
                timer.Enabled = true;
                break;
            case 2:
                switch (settings.amount)
                {
                    case 2:
                        timeSEC = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        timeSEC = 80;
                        difficultyTime = 80;
                        break;
                    case 6:
                        timeSEC = 180;
                        difficultyTime = 180;
                        break;
                    case 8:
                        timeSEC = 320;
                        difficultyTime = 320;
                        break;
                    default:
                        break;
                }
                timer.Elapsed += TimeDOWNEvent;
                timer.Enabled = true;
                break;
            default:
                break;
        }

        flippeCardPairIndex = new int[2, 2];
        flippeCardPairIndex[0, 0] = -1;
        flippeCardPairIndex[0, 1] = -1;
        flippeCardPairIndex[1, 0] = -1;
        flippeCardPairIndex[1, 1] = -1;
        flippedCardsMatrix = new bool[settings.amount, settings.amount];
        gameOverStyle = "";
        timer.Start();
        StateHasChanged();
    }

    private async Task FlipCard(string index, int i, int j)
    {
        if (!isFlipCardRunning)
        {
            isFlipCardRunning = true;

            if (!flippedCardsMatrix[i, j])
            {
                if (flippeCardPairIndex[0, 0] == -1)            //if there is no
                {
                    await JsRuntime.InvokeAsync<string>("flip", index);
                    flippedCardsMatrix[i, j] = true;
                    flippeCardPairIndex[0, 0] = i;
                    flippeCardPairIndex[0, 1] = j;
                }
                else                                          //if one card is flipped
                {
                    await JsRuntime.InvokeAsync<string>("flip", index);
                    await Task.Delay(500);
                    flippedCardsMatrix[i, j] = true;
                    flippeCardPairIndex[1, 0] = i;
                    flippeCardPairIndex[1, 1] = j;

                    //if cards are different
                    if (iconsPathMatrix[flippeCardPairIndex[0, 0], flippeCardPairIndex[0, 1]] != iconsPathMatrix[i, j])
                    {

                        //if difficulty is hard (then flipback all cards)
                        if (settings.difficulty==2)
                        {
                            for (int k = 0; k < flippedCardsMatrix.GetLength(0); k++)
                            {
                                for (int l = 0; l < flippedCardsMatrix.GetLength(1); l++)
                                {
                                    if (flippedCardsMatrix[k, l])
                                    {
                                        flippedCardsMatrix[k, l] = false;
                                        await JsRuntime.InvokeAsync<string>("flipback", k.ToString() + l.ToString());
                                    }
                                }
                            }
                            await Task.Delay(500);
                        }
                        //else flipback only last pair
                        else                            
                        {
                            await JsRuntime.InvokeAsync<string>("flipback", flippeCardPairIndex[0, 0].ToString() + flippeCardPairIndex[0, 1].ToString());
                            await JsRuntime.InvokeAsync<string>("flipback", flippeCardPairIndex[1, 0].ToString() + flippeCardPairIndex[1, 1].ToString());
                            flippedCardsMatrix[i, j] = false;
                            flippedCardsMatrix[flippeCardPairIndex[0, 0], flippeCardPairIndex[0, 1]] = false;
                        }
                    }
                    //if two cards matches
                    else
                    {
                        if (IsGameCompleted())
                        {
                            timer.Stop();
                            var bestOldScore = await BrowserStorage.GetAsync<string>("Score_" + settings.amount+"_"+settings.difficulty);
                            if (bestOldScore.Success)
                            {
                                //to convert to TimeSpan i need to add '0:' to string
                                TimeSpan ts = TimeSpan.Parse("0:" + bestOldScore.Value);
                                switch (settings.difficulty)
                                {
                                    case 0:
                                        int resultEasy = TimeSpan.Compare(ts, TimeSpan.Parse("0:" + ConvertTime(timeSEC)));
                                        if (resultEasy == 1)
                                        {
                                            await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, ConvertTime(timeSEC));
                                            bestTime = ConvertTime(timeSEC);
                                        }
                                        break;
                                    case 1:
                                        int resultNormal = TimeSpan.Compare(ts, TimeSpan.Parse("0:" + ConvertTime(difficultyTime - timeSEC)));
                                        if (resultNormal == 1)
                                        {
                                            await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, ConvertTime(difficultyTime - timeSEC));
                                            bestTime = ConvertTime(difficultyTime - timeSEC);
                                        }
                                        break;
                                    case 2:
                                        int resultHard = TimeSpan.Compare(ts, TimeSpan.Parse("0:" + ConvertTime(difficultyTime - timeSEC)));
                                        if (resultHard == 1)
                                        {
                                            await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, ConvertTime(difficultyTime - timeSEC));
                                            bestTime = ConvertTime(difficultyTime - timeSEC);
                                        }
                                        break;
                                    default:
                                        break;
                                }

                            }
                            else
                            {
                                switch (settings.difficulty)
                                {
                                    case 0:
                                        await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, ConvertTime(timeSEC));
                                        bestTime = ConvertTime(timeSEC);
                                        break;
                                    case 1:
                                        await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, ConvertTime(difficultyTime - timeSEC));
                                        bestTime = ConvertTime(difficultyTime - timeSEC);
                                        break;
                                    case 2:
                                        await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, ConvertTime(difficultyTime - timeSEC));
                                        bestTime = ConvertTime(difficultyTime - timeSEC);
                                        break;
                                    default:
                                        break;
                                }

                            }
                            StateHasChanged();
                        }
                    }

                    flippeCardPairIndex[0, 0] = -1;
                    flippeCardPairIndex[0, 1] = -1;
                    flippeCardPairIndex[1, 0] = -1;
                    flippeCardPairIndex[1, 1] = -1;
                }
            }

            isFlipCardRunning = false;
        }
    }

    private bool IsGameCompleted()
    {
        for (int i = 0; i < flippedCardsMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < flippedCardsMatrix.GetLength(1); j++)
            {
                if (!flippedCardsMatrix[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ComponentsService componentsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.Settings settings { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage BrowserStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
