#pragma checksum "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e1cdc189fd71c8d737f723de0e20fcf3e9cf5a"
// <auto-generated/>
#pragma warning disable 1591
namespace MemoryGame.Pages
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
#line 2 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class HomePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
 if (isMenuClosed)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MemoryGame.Component.GameComponent>(0);
            __builder.AddAttribute(1, "iconsPathMatrix", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[,]>(
#nullable restore
#line 10 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                     iconsPathMatrix

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "start-menu");
            __builder.AddAttribute(4, "style", 
#nullable restore
#line 15 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                    startMenuStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "b-l4g5sfkfl7");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 h-100 p-0");
            __builder.AddAttribute(8, "b-l4g5sfkfl7");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "d-flex justify-content-center align-items-end h-55");
            __builder.AddAttribute(11, "b-l4g5sfkfl7");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                  (() => CreateOrderOfIcons())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "play-button");
            __builder.AddAttribute(15, "b-l4g5sfkfl7");
            __builder.AddMarkupContent(16, "<i class=\"fas fa-play font-size-play icon-style text-white\" b-l4g5sfkfl7></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "d-flex justify-content-center align-items-center flex-column h-45");
            __builder.AddAttribute(20, "b-l4g5sfkfl7");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                  (()=> { startMenuStyle = "width:0;";settingsAnimationStyle = "width:100%";  settingsMenuStyle = "visibility:visible;"; })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "settings-button");
            __builder.AddAttribute(24, "b-l4g5sfkfl7");
            __builder.AddMarkupContent(25, "<div class=\"d-flex justify-content-end w-20\" b-l4g5sfkfl7><i class=\"fas fa-cog font-size-icon-sett con-style\" b-l4g5sfkfl7></i></div>\r\n                    ");
            __builder.AddMarkupContent(26, "<div class=\"font-size-settings font-cursive w-80 d-flex justify-content-center\" b-l4g5sfkfl7><span class=\"font-settings\" b-l4g5sfkfl7>\r\n                            SETTINGS\r\n                        </span></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, @"<div class=""mt-3 w-75 h-10"" b-l4g5sfkfl7><div class=""text-center font-size-flags-info"" b-l4g5sfkfl7>Flags made by <a href=""https://www.freepik.com"" title=""Freepik"" b-l4g5sfkfl7>Freepik</a> from <a href=""https://www.flaticon.com/"" title=""Flaticon"" b-l4g5sfkfl7>www.flaticon.com</a></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "settings-menu");
            __builder.AddAttribute(32, "style", 
#nullable restore
#line 39 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                       settingsMenuStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "b-l4g5sfkfl7");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "settings-anim");
            __builder.AddAttribute(36, "style", 
#nullable restore
#line 40 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                           settingsAnimationStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "b-l4g5sfkfl7");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "d-flex w-100 justify-content-center text-white");
            __builder.AddAttribute(40, "style", "border-radius: 2rem 2rem 0 0; height: 12%; background-color: #597454;");
            __builder.AddAttribute(41, "b-l4g5sfkfl7");
            __builder.AddMarkupContent(42, @"<div class=""d-flex justify-content-center align-items-center font-size-settings text-center"" style=""width:85%;"" b-l4g5sfkfl7><span class=""font-settings font-cursive"" style=""margin-left: calc(((100%*100)/75)*0.125);"" b-l4g5sfkfl7>
                        SETTINGS
                    </span></div>
                ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                  (()=> {CloseSettings();})

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "close-settings-button");
            __builder.AddAttribute(46, "b-l4g5sfkfl7");
            __builder.AddMarkupContent(47, "<i class=\"fas fa-times\" style=\"font-size:1.5rem;\" b-l4g5sfkfl7></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "d-flex justify-content-center align-items-center flex-column");
            __builder.AddAttribute(51, "style", "height:88%;");
            __builder.AddAttribute(52, "b-l4g5sfkfl7");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "d-flex justify-content-center align-items-center w-100");
            __builder.AddAttribute(55, "style", "height:15%;");
            __builder.AddAttribute(56, "b-l4g5sfkfl7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(57);
            __builder.AddAttribute(58, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 53 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                     settings.amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "style", "width:20%;height:70%;");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.MemoryGame.Pages.HomePage.TypeInference.CreateInputSelect_0(__builder2, 61, 62, "width: 100%; height: 100%; border-radius: 10px; outline: none; cursor: pointer; ", 63, 
#nullable restore
#line 54 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                  settings.amount

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => settings.amount = __value, settings.amount)), 65, () => settings.amount, 66, (__builder3) => {
                    __builder3.AddMarkupContent(67, "<option value=\"2\" b-l4g5sfkfl7>2x2</option>\r\n                            ");
                    __builder3.AddMarkupContent(68, "<option value=\"4\" b-l4g5sfkfl7>4x4</option>\r\n                            ");
                    __builder3.AddMarkupContent(69, "<option value=\"6\" b-l4g5sfkfl7>6x6</option>\r\n                            ");
                    __builder3.AddMarkupContent(70, "<option value=\"8\" b-l4g5sfkfl7>8x8</option>");
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "style", "height:70%;");
            __builder.AddAttribute(74, "class", "d-flex justify-content-center w-100");
            __builder.AddAttribute(75, "b-l4g5sfkfl7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(76);
            __builder.AddAttribute(77, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 63 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                     settings.difficulty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "class", "w-80");
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-check w-100 p-0");
                __builder2.AddAttribute(82, "style", "height: 33%;");
                __builder2.AddAttribute(83, "b-l4g5sfkfl7");
                __builder2.OpenElement(84, "label");
                __builder2.AddAttribute(85, "class", "radio w-100 m-0");
                __builder2.AddAttribute(86, "for", "radio1");
                __builder2.AddAttribute(87, "style", "height:90%;");
                __builder2.AddAttribute(88, "b-l4g5sfkfl7");
                __builder2.OpenElement(89, "input");
                __builder2.AddAttribute(90, "type", "radio");
                __builder2.AddAttribute(91, "class", "radio__input");
                __builder2.AddAttribute(92, "id", "radio1");
                __builder2.AddAttribute(93, "name", "exampleRadios");
                __builder2.AddAttribute(94, "value", "0");
                __builder2.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                                                                                               OnChangeInputRadio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "checked", 
#nullable restore
#line 66 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                                                                                                                              "0".Equals(settings.difficulty.ToString())

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(97, "b-l4g5sfkfl7");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                                ");
                __builder2.AddMarkupContent(99, @"<div class=""radio_radio w-100 h-100 d-flex align-items-center bcg-green"" b-l4g5sfkfl7><div class=""d-flex w-100 flex-column"" style=""height:90%;"" b-l4g5sfkfl7><div class=""d-flex w-100"" style=""height:80%"" b-l4g5sfkfl7><div class=""d-flex justify-content-center align-items-center w-20"" b-l4g5sfkfl7><i class=""fas fa-smile icon-size-diff"" b-l4g5sfkfl7></i></div>
                                            <div class=""w-60 d-flex justify-content-center align-items-center font-cursive"" b-l4g5sfkfl7><span class=""font-size-diff"" b-l4g5sfkfl7>
                                                    EASY
                                                </span></div>
                                            <div class=""d-flex justify-content-center align-items-center w-20"" b-l4g5sfkfl7><i class=""fas fa-smile  icon-size-diff"" b-l4g5sfkfl7></i></div></div>
                                        <div class=""d-flex w-100"" style=""height:20%"" b-l4g5sfkfl7><div class=""w-20"" b-l4g5sfkfl7></div>
                                            <div style=""font-size:0.75rem;"" class=""d-flex justify-content-center align-items-center w-60 font-cursive"" b-l4g5sfkfl7><span b-l4g5sfkfl7>
                                                    No pressure, just play :)
                                                </span></div>
                                            <div class=""w-20"" b-l4g5sfkfl7></div></div></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-check w-100 p-0");
                __builder2.AddAttribute(103, "style", "height:33%;");
                __builder2.AddAttribute(104, "b-l4g5sfkfl7");
                __builder2.OpenElement(105, "label");
                __builder2.AddAttribute(106, "class", "radio w-100 m-0");
                __builder2.AddAttribute(107, "for", "radio2");
                __builder2.AddAttribute(108, "style", "height:90%;");
                __builder2.AddAttribute(109, "b-l4g5sfkfl7");
                __builder2.OpenElement(110, "input");
                __builder2.AddAttribute(111, "type", "radio");
                __builder2.AddAttribute(112, "class", "radio__input");
                __builder2.AddAttribute(113, "id", "radio2");
                __builder2.AddAttribute(114, "name", "exampleRadios");
                __builder2.AddAttribute(115, "value", "1");
                __builder2.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                                                                                                OnChangeInputRadio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(117, "checked", 
#nullable restore
#line 101 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                                                                                                                               "1".Equals(settings.difficulty.ToString())

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(118, "b-l4g5sfkfl7");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                ");
                __builder2.AddMarkupContent(120, @"<div class=""radio_radio w-100 h-100 d-flex align-items-center bcg-orange"" b-l4g5sfkfl7><div class=""d-flex w-100 flex-column"" style=""height:90%;"" b-l4g5sfkfl7><div class=""d-flex w-100"" style=""height:80%"" b-l4g5sfkfl7><div style=""width:20%;"" class=""d-flex justify-content-center align-items-center"" b-l4g5sfkfl7><i class=""fas fa-stopwatch icon-size-diff"" style=""transform-origin: 50% 59%;"" b-l4g5sfkfl7></i></div>
                                            <div class=""d-flex justify-content-center align-items-center w-60 font-cursive"" b-l4g5sfkfl7><span class=""font-size-diff"" b-l4g5sfkfl7>
                                                    NORMAL
                                                </span></div>
                                            <div class=""d-flex justify-content-center align-items-center w-20"" b-l4g5sfkfl7><i class=""fas fa-stopwatch icon-size-diff"" style=""transform-origin: 50% 59%;"" b-l4g5sfkfl7></i></div></div>
                                        <div class=""d-flex w-100"" style=""height:20%"" b-l4g5sfkfl7><div class=""w-20"" b-l4g5sfkfl7></div>
                                            <div style=""font-size:0.75rem;"" class=""d-flex justify-content-center align-items-center font-cursive w-60"" b-l4g5sfkfl7><span b-l4g5sfkfl7>
                                                    Time Limit
                                                </span></div>
                                            <div class=""w-20"" b-l4g5sfkfl7></div></div></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                        ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-check w-100 p-0");
                __builder2.AddAttribute(124, "style", "height: 33%;");
                __builder2.AddAttribute(125, "b-l4g5sfkfl7");
                __builder2.OpenElement(126, "label");
                __builder2.AddAttribute(127, "class", "radio w-100 m-0");
                __builder2.AddAttribute(128, "for", "radio3");
                __builder2.AddAttribute(129, "style", "height:90%;");
                __builder2.AddAttribute(130, "b-l4g5sfkfl7");
                __builder2.OpenElement(131, "input");
                __builder2.AddAttribute(132, "type", "radio");
                __builder2.AddAttribute(133, "class", "radio__input");
                __builder2.AddAttribute(134, "id", "radio3");
                __builder2.AddAttribute(135, "name", "exampleRadios");
                __builder2.AddAttribute(136, "value", "2");
                __builder2.AddAttribute(137, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 136 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                                                                                                OnChangeInputRadio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "checked", 
#nullable restore
#line 136 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
                                                                                                                                                               "2".Equals(settings.difficulty.ToString())

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(139, "b-l4g5sfkfl7");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                                ");
                __builder2.AddMarkupContent(141, @"<div class=""radio_radio w-100 h-100 d-flex align-items-center bcg-red"" b-l4g5sfkfl7><div class=""d-flex w-100 flex-column"" style=""height:90%;"" b-l4g5sfkfl7><div class=""d-flex w-100"" style=""height:80%"" b-l4g5sfkfl7><div class=""d-flex justify-content-center align-items-center w-20"" b-l4g5sfkfl7><i class=""fas fa-bomb icon-size-diff"" style=""transform-origin: 39.5% 58.3%;"" b-l4g5sfkfl7></i></div>
                                            <div class=""d-flex justify-content-center align-items-center font-cursive w-60"" b-l4g5sfkfl7><span class=""font-size-diff"" b-l4g5sfkfl7>
                                                    HARD
                                                </span></div>
                                            <div class=""d-flex justify-content-center align-items-center w-20"" b-l4g5sfkfl7><i class=""fas fa-bomb icon-size-diff"" style=""transform-origin: 39.5% 58.3%;"" b-l4g5sfkfl7></i></div></div>
                                        <div class=""d-flex w-100"" style=""height:20%"" b-l4g5sfkfl7><div style=""width:20%;"" b-l4g5sfkfl7></div>
                                            <div style=""font-size:0.75rem;"" class=""d-flex justify-content-center align-items-center font-cursive w-60"" b-l4g5sfkfl7><span b-l4g5sfkfl7>
                                                    No mistakes!
                                                </span></div>
                                            <div sclass=""w-20"" b-l4g5sfkfl7></div></div></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 174 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 176 "C:\Users\jarek\Documents\repos\simple-memory-game\MemoryGame\MemoryGame\Pages\HomePage.razor"
       
    private string startMenuStyle { get; set; }
    private string settingsMenuStyle { get; set; }
    private string settingsAnimationStyle { get; set; }
    private bool isMenuClosed { get; set; }
    private string[,] iconsPathMatrix { get; set; }

    protected override void OnInitialized()
    {
        componentsService.homePage = this;

        //default game settings
        settings.amount = 6;            //6x6
        settings.difficulty = 1;        //Normal
    }

    private void OnChangeInputRadio(ChangeEventArgs args)
    {
        settings.difficulty = Convert.ToInt32(args.Value.ToString());
    }

    private async Task CloseSettings()
    {
        //Menu on top
        startMenuStyle = "z-index:4;";
        //Remove width:100%
        settingsAnimationStyle = "";
        //Required to play animation
        await Task.Delay(900);
        //Hide settings
        settingsMenuStyle = "visibility:hidden;";
    }

    private void CreateOrderOfIcons()
    {
        iconsPathMatrix = new string[settings.amount, settings.amount];
        var random = new Random();

        //Explanation: 
        //If game is created with the size 4x4. That means there is 16 squares. In this 16 squares, we got 8 pairs. File (svg) names are from 0 to 31 (because max size of board is 8x8 => 64 => 32).
        //Back to our example 4x4. We take Enumebable with indexes from 0 to 8 concat that with the same numbers, so we got 8 pairs and then just place them in the random order.
        var randomOrderOfNumbers = Enumerable.Range(0, 32).Select(x => x).OrderBy(x => random.Next()).Take(settings.amount*settings.amount/2).ToList();
        randomOrderOfNumbers = randomOrderOfNumbers.Concat(randomOrderOfNumbers).OrderBy(x => random.Next()).ToList();

        //index to go through the list.
        int index = 0;

        //fill the matrix with icons paths.
        for (int i = 0; i < settings.amount; i++)
        {
            for (int j = 0; j < settings.amount; j++)
            {
                iconsPathMatrix[i, j] ="\\icons\\"+ randomOrderOfNumbers[index]+".svg";
                index++;
            }
        }

        //After generate matrix show the game component.
        isMenuClosed = true;
    }

    public async Task OpenMenu()
    {
        startMenuStyle = "width:5%;";
        isMenuClosed = false;
        await Task.Delay(100);
        StateHasChanged();
        startMenuStyle = "";
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ComponentsService componentsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.Settings settings { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
    }
}
namespace __Blazor.MemoryGame.Pages.HomePage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
