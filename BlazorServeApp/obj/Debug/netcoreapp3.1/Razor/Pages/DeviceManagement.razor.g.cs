#pragma checksum "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb11785d318c855ed4f6720d0f425b0db501ab2"
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
#line 9 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
using BlazorServeApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
using BlazorServeApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
using BlazorServeApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeviceManagement")]
    public partial class DeviceManagement : OwningComponentBase<GroupsListService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Device Management Page</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Add, edit, or delete a device.</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label for=\"IMEI\">  IMEI *</label>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<label for=\"User\"> User *</label>\r\n        ");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", true);
            __builder.AddContent(18, "-- Select User --");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
             if (usrobj != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
                 foreach (var item in usrobj)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                    ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
                                    item.Email

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 37 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
__builder.AddContent(23, item.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-md-6");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<label for=\"Group\"> Select Group *</label>\r\n\r\n        ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "onchange", true);
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", true);
            __builder.AddContent(42, "-- Select Group --");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 53 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
             if (grobj != null)
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
                 foreach (var item in grobj)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                    ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", 
#nullable restore
#line 56 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
                                    item.Groups

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 56 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
__builder.AddContent(47, item.Groups);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 57 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "            }\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n    ");
            __builder.AddMarkupContent(53, "<div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label for=\"Auhtorisation\"> Auhtorisation *</label>\r\n        </div>\r\n    </div>\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.AddMarkupContent(55, "<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Administrator\source\repos\BlazorServeApp\BlazorServeApp\Pages\DeviceManagement.razor"
       

    //[Parameter]
    //public string Id { get; set; }
    //Device device = new Device();

    //protected async Task Save()
    //{
    //   await DeviceService.SaveAsync(device);
    //    NavigationManager.NavigateTo("DeviceList"); //navigation link to table page after device has been added
    //}
    //void Cancel()
    //{
    //    NavigationManager.NavigateTo("DeviceList"); // navigation link to table page after cancel btn has been clicked
    //}

    List<GroupsListClass> grobj;
    List<UserListClass> usrobj;

    //List<UserListClass> users = new List<UserListClass>();


    protected override void OnInitialized()
    {
        //base.OnInitialized();
        grobj = Service.groupsobj();
        usrobj = Service.usersobj();
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
