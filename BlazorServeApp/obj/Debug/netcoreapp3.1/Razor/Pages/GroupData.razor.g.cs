#pragma checksum "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1269b43cf6664a68b969bfc5832864da8b2dbb2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServeApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using BlazorServeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\_Imports.razor"
using BlazorServeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
using BlazorServeApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
using BlazorServeApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
using BlazorServeApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/groupdata")]
    public partial class GroupData : OwningComponentBase<GroupsService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Group Data In Dropdown List</h3>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <label for=\"Imei\" class=\"control-label\">IMEI *</label>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <label asp-for=\"User\" class=\"control-label\">User *</label>\r\n    </div>\r\n</div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "style", "padding-top:10px");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<div class=\"col-md-4\">\r\n        <input type=\"text\" name=\"imei\" class=\"form-control\">\r\n    </div>\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "onchange", true);
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", true);
            __builder.AddContent(16, "-- Select User --");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.AddMarkupContent(21, "<div class=\"row\" style=\"padding-top:50px\">\r\n\r\n</div> ");
            __builder.AddMarkupContent(22, @"<div class=""row"">
    <div class=""col-md-4"">
        <label for=""Group"" class=""control-label"">Group *</label>
    </div>
    <div class=""col-md-4"">
        <label asp-for=""Authorization"" class=""control-label"">Authorization *</label>
    </div>
</div>
");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddAttribute(25, "style", "padding-top:10px");
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.AddMarkupContent(27, "<div class=\"col-md-4\">\r\n        <input class=\"form-control\" type=\"text\" name=\"authorization\">\r\n    </div>\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-4");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "select");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "onchange", true);
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", true);
            __builder.AddContent(37, "-- Select Group --");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            \r\n");
#nullable restore
#line 61 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
                     foreach (var item in grobj)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                        ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", 
#nullable restore
#line 63 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
                                        item.Groups

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 63 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
__builder.AddContent(42, item.Groups);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 64 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "               \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\GroupData.razor"
       

    List<GroupsClass> grobj;


    protected override void OnInitialized()
    {
        //base.OnInitialized();
        grobj = Service.groupsobj();
        
    }

 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591