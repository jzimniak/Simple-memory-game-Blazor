#pragma checksum "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b28019d7c3e4b6b3bedbb70166b861bfc7faf5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "game");
            __builder.AddAttribute(2, "b-zv4ssyz2yc");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "width:100vw; background-color:aqua;");
            __builder.AddAttribute(5, "class", "d-flex justify-content-center");
            __builder.AddAttribute(6, "b-zv4ssyz2yc");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "top-menu-game d-flex flex-row");
            __builder.AddAttribute(9, "b-zv4ssyz2yc");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "h-100 d-flex justify-content-center align-items-center");
            __builder.AddAttribute(12, "style", "width:60%");
            __builder.AddAttribute(13, "b-zv4ssyz2yc");
#nullable restore
#line 13 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                 if (bestTime is not null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "style", "font-family: cursive; font-size: 2rem;");
            __builder.AddAttribute(16, "b-zv4ssyz2yc");
            __builder.AddMarkupContent(17, "\r\n                        Personal best time: ");
            __builder.AddContent(18, 
#nullable restore
#line 16 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                             bestTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<span style=\"font-family: cursive; font-size: 1.7rem;\" b-zv4ssyz2yc>\r\n                        Complete the game to have personal best\r\n                    </span>");
#nullable restore
#line 24 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "h-100 d-flex justify-content-center align-items-center");
            __builder.AddAttribute(23, "style", "width:20%");
            __builder.AddAttribute(24, "b-zv4ssyz2yc");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "w-100 h-100 ");
            __builder.AddAttribute(27, "style", "outline:none;background-color:transparent;");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                                                                                          resetGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "b-zv4ssyz2yc");
            __builder.AddMarkupContent(30, "<i class=\"fas fa-redo-alt\" style=\" font-size: 2.5rem;\" b-zv4ssyz2yc></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "h-100 d-flex justify-content-center align-items-center");
            __builder.AddAttribute(34, "style", "width:20%");
            __builder.AddAttribute(35, "b-zv4ssyz2yc");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "w-100 h-100 ");
            __builder.AddAttribute(38, "style", "outline:none;background-color:transparent;");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                                                                                          (() => { componentsService.homePage.OpenMenu(); })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "b-zv4ssyz2yc");
            __builder.AddMarkupContent(41, "<i class=\"fas fa-cog font-size-icon-sett\" style=\" font-size: 2.5rem;\" b-zv4ssyz2yc></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "display:flex;flex-direction:column;height:100%;width:100%;justify-content:center;");
            __builder.AddAttribute(45, "b-zv4ssyz2yc");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "timer d-flex justify-content-center align-items-center");
            __builder.AddAttribute(48, "b-zv4ssyz2yc");
#nullable restore
#line 40 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
             if (gameover)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<span style=\"font-family: cursive; font-size: 3rem;color:red;\" b-zv4ssyz2yc>\r\n                    Game Over!!!\r\n                </span>");
#nullable restore
#line 45 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "style", "font-family: cursive; font-size: 3rem;");
            __builder.AddAttribute(52, "b-zv4ssyz2yc");
            __builder.AddContent(53, 
#nullable restore
#line 49 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                     convertTime(test)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "display:" + " flex;" + " width:" + " 100%;" + " aspect-ratio:" + " 1/1;" + " flex-direction:column;" + (
#nullable restore
#line 53 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                                                                          styleGameOver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "b-zv4ssyz2yc");
#nullable restore
#line 54 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
             for (int i = 0; i < settings.amount; i++)
            {
                var percentage = ((decimal)100 / settings.amount).ToString(CultureInfo.InvariantCulture);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "d-flex w-100 position-relative");
            __builder.AddAttribute(60, "style", "height:" + (
#nullable restore
#line 57 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                                                           percentage

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(61, "b-zv4ssyz2yc");
#nullable restore
#line 58 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                     for (int j = 0; j < settings.amount; j++)
                    {
                        var iT = i;
                        var jT = j;
                        var x = i.ToString() + j.ToString();
                        var idf = "front" + x;
                        var idb = "back" + x;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "d-flex h-100 justify-content-center align-items-center t");
            __builder.AddAttribute(64, "style", "width:" + (
#nullable restore
#line 65 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                                                                                            percentage

#line default
#line hidden
#nullable disable
            ) + "%;" + " perspective:1000px");
            __builder.AddAttribute(65, "b-zv4ssyz2yc");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "id", 
#nullable restore
#line 66 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                      idf

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "class", "front");
            __builder.AddAttribute(69, "style", "width: 93%;");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                                                                       (() => flip(x,iT,jT))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "b-zv4ssyz2yc");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                            ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "id", 
#nullable restore
#line 68 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                      idb

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(75, "class", "back d-flex justify-content-center align-items-center");
            __builder.AddAttribute(76, "style", "width: 93%;");
            __builder.AddAttribute(77, "b-zv4ssyz2yc");
#nullable restore
#line 69 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                  var path = names[i, j]; 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "img");
            __builder.AddAttribute(79, "src", 
#nullable restore
#line 70 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                                           path

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "style", "max-height:80%;max-width:80%;");
            __builder.AddAttribute(81, "b-zv4ssyz2yc");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
       
    [Parameter]
    public string[,] names { get; set; }

    private bool[,] flipped { get; set; }
    private int[,] flippedindex { get; set; }
    private bool isfunctionrunning { get; set; }
    private System.Timers.Timer timer { get; set; }
    private double test = 0;
    private double difficultyTime { get; set; }
    private string bestTime { get; set; }
    private string styleGameOver { get; set; }
    private bool gameover { get; set; }

    protected async override Task OnInitializedAsync()
    {
        componentsService.gameComponent = this;
        var result = await BrowserStorage.GetAsync<string>("Score_" + settings.amount + "_" + settings.difficulty);
        if (result.Success)
        {
            bestTime = result.Value;
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
                        test = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        test = 40;
                        difficultyTime = 40;
                        break;
                    case 6:
                        test = 90;
                        difficultyTime = 90;
                        break;
                    case 8:
                        test = 160;
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
                        test = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        test = 80;
                        difficultyTime = 80;
                        break;
                    case 6:
                        test = 180;
                        difficultyTime = 180;
                        break;
                    case 8:
                        test = 320;
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

        flippedindex = new int[2, 2];
        flippedindex[0, 0] = -1;
        flippedindex[0, 1] = -1;
        flippedindex[1, 0] = -1;
        flippedindex[1, 1] = -1;
        flipped = new bool[settings.amount, settings.amount];
    }

    private string convertTime(double miliseconds)
    {
        TimeSpan t = TimeSpan.FromSeconds(miliseconds);

        return string.Format(@"{0:mm\:ss\.f}", t);
    }

    private void TimeUPEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        test += 0.1;
        InvokeAsync(StateHasChanged);

    }

    private void TimeDOWNEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
        test -= 0.1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
         if (test <= 0)
        {
            timer.Stop();
            gameover = true;
            styleGameOver = "pointer-events: none;";
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Component\GameComponent.razor"
         
        InvokeAsync(StateHasChanged);
    }

    private async Task resetGame()
    {
        timer.Stop();
        gameover = false;
        styleGameOver = "pointer-events: none;";
        StateHasChanged();

        for (int i = 0; i < flipped.GetLength(0); i++)
        {
            for (int j = 0; j < flipped.GetLength(1); j++)
            {
                if (flipped[i, j])
                {
                    await JsRuntime.InvokeAsync<string>("flipback", i.ToString() + j.ToString());
                }
            }
        }
        await Task.Delay(500);

        names = new string[settings.amount, settings.amount];
        var rnd = new Random();
        var randomNumbers = Enumerable.Range(0, settings.amount * settings.amount / 2).Select(x => x).Concat(Enumerable.Range(0, settings.amount * settings.amount / 2).Select(x => x)).OrderBy(x => rnd.Next()).Take(settings.amount * settings.amount).ToList();
        int index = 0;

        for (int i = 0; i < settings.amount; i++)
        {
            for (int j = 0; j < settings.amount; j++)
            {
                names[i, j] = "\\icons\\" + randomNumbers[index] + ".svg";
                index++;
            }
        }

        timer = new System.Timers.Timer(100);

        switch (settings.difficulty)
        {
            case 0:
                test = 0;
                timer.Elapsed += TimeUPEvent;
                timer.Enabled = true;
                break;
            case 1:
                switch (settings.amount)
                {
                    case 2:
                        test = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        test = 40;
                        difficultyTime = 40;
                        break;
                    case 6:
                        test = 90;
                        difficultyTime = 90;
                        break;
                    case 8:
                        test = 160;
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
                        test = 10;
                        difficultyTime = 10;
                        break;
                    case 4:
                        test = 80;
                        difficultyTime = 80;
                        break;
                    case 6:
                        test = 180;
                        difficultyTime = 180;
                        break;
                    case 8:
                        test = 320;
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

        flippedindex = new int[2, 2];
        flippedindex[0, 0] = -1;
        flippedindex[0, 1] = -1;
        flippedindex[1, 0] = -1;
        flippedindex[1, 1] = -1;
        flipped = new bool[settings.amount, settings.amount];
        styleGameOver = "";
        timer.Start();
        StateHasChanged();
    }

    private async Task flip(string index, int i, int j)
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
                    await Task.Delay(500);
                    flipped[i, j] = true;
                    flippedindex[1, 0] = i;
                    flippedindex[1, 1] = j;
                    if (names[flippedindex[0, 0], flippedindex[0, 1]] != names[i, j])
                    {
                        if (settings.difficulty==2)
                        {
                            for (int k = 0; k < flipped.GetLength(0); k++)
                            {
                                for (int l = 0; l < flipped.GetLength(1); l++)
                                {
                                    if (flipped[k, l])
                                    {
                                        flipped[k, l] = false;
                                        await JsRuntime.InvokeAsync<string>("flipback", k.ToString() + l.ToString());
                                    }
                                }
                            }
                            await Task.Delay(500);
                        }
                        else
                        {
                            await JsRuntime.InvokeAsync<string>("flipback", flippedindex[0, 0].ToString() + flippedindex[0, 1].ToString());
                            await JsRuntime.InvokeAsync<string>("flipback", flippedindex[1, 0].ToString() + flippedindex[1, 1].ToString());
                            flipped[i, j] = false;
                            flipped[flippedindex[0, 0], flippedindex[0, 1]] = false;
                        }
                    }
                    else
                    {
                        if (gameCompleted())
                        {
                            timer.Stop();
                            var result = await BrowserStorage.GetAsync<string>("Score_" + settings.amount+"_"+settings.difficulty);
                            if (result.Success)
                            {
                                TimeSpan ts = TimeSpan.Parse("0:" + result.Value);
                                switch (settings.difficulty)
                                {
                                    case 0:
                                        int resultEasy = TimeSpan.Compare(ts, TimeSpan.Parse("0:" + convertTime(test)));
                                        if (resultEasy == 1)
                                        {
                                            await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, convertTime(test));
                                            bestTime = convertTime(test);
                                        }
                                        break;
                                    case 1:
                                        int resultNormal = TimeSpan.Compare(ts, TimeSpan.Parse("0:" + convertTime(difficultyTime - test)));
                                        if (resultNormal == 1)
                                        {
                                            await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, convertTime(difficultyTime - test));
                                            bestTime = convertTime(difficultyTime - test);
                                        }
                                        break;
                                    case 2:
                                        int resultHard = TimeSpan.Compare(ts, TimeSpan.Parse("0:" + convertTime(difficultyTime - test)));
                                        if (resultHard == 1)
                                        {
                                            await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, convertTime(difficultyTime - test));
                                            bestTime = convertTime(difficultyTime - test);
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
                                        await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, convertTime(test));
                                        bestTime = convertTime(test);
                                        break;
                                    case 1:
                                        await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, convertTime(difficultyTime - test));
                                        bestTime = convertTime(difficultyTime - test);
                                        break;
                                    case 2:
                                        await BrowserStorage.SetAsync("Score_" + settings.amount + "_" + settings.difficulty, convertTime(difficultyTime - test));
                                        bestTime = convertTime(difficultyTime - test);
                                        break;
                                    default:
                                        break;
                                }

                            }
                            StateHasChanged();
                        }
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

    private bool gameCompleted()
    {
        for (int i = 0; i < flipped.GetLength(0); i++)
        {
            for (int j = 0; j < flipped.GetLength(1); j++)
            {
                if (!flipped[i, j])
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
