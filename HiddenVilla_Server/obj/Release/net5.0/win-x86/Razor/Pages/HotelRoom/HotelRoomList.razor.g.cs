#pragma checksum "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df8873f08b20f5632495e41b44d883881a43833b"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
           [Authorize(Roles = Common.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room")]
    public partial class HotelRoomList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Hotel Room\'s</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "hotel-room/create");
            __builder.AddAttribute(7, "class", "btn btn-info form-control");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Add New Room");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><th>Name</th>\r\n                    <th>Occupancy</th>\r\n                    <th>Rate</th>\r\n                    <th>\r\n                        Sqft\r\n                    </th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 34 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                 if (HotelRooms.Any())
                {
                    foreach (var room in HotelRooms)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 39 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 40 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.Occupancy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 41 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.RegularRate.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 42 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                 room.SqFt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 44 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                 $"hotel-room/edit/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                                         ()=>HandleDelete(room.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<tr><td colspan=\"5\">No records found</td></tr>");
#nullable restore
#line 55 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Shared.DeleteConfirmation>(45);
            __builder.AddAttribute(46, "IsParentComponentProcessing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                 IsProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 62 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                                                                    ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
       
    private IEnumerable<HotelRoomDTO> HotelRooms { get; set; } = new List<HotelRoomDTO>();
    private int? DeleteRoomId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;
    protected override async Task OnInitializedAsync()
    {
        HotelRooms = await HotelRoomRepository.GetAllHotelRooms();
    }


    private async Task HandleDelete(int roomId)
    {
        DeleteRoomId = roomId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }

    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteRoomId != null)
        {
            HotelRoomDTO hotelRoom = await HotelRoomRepository.GetHotelRoom(DeleteRoomId.Value);
            foreach (var image in hotelRoom.HotelRoomImages)
            {
                var imageName = image.RoomImageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");
                FileUpload.DeleteFile(imageName);
            }

            await HotelRoomRepository.DeleteHotelRoom(DeleteRoomId.Value);
            await JsRuntime.ToastrSuccess("Hotel Room Deleted successfully");
            HotelRooms = await HotelRoomRepository.GetAllHotelRooms();
        }
        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HiddenVilla_Server.Service.IService.IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591
