// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Server.Pages.HotelAmenity
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
#line 3 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\AmenityUpsert.razor"
using Business.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\AmenityUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-amenity/edit/{Id:int}")]
    public partial class AmenityUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\AmenityUpsert.razor"
 
    [Parameter]
    public int? Id { get; set; }
    //instantiate right away
    internal HotelAmenityRequestDTO HotelAmenityModel { get; set; } = new HotelAmenityRequestDTO();
    internal HotelAmenityDTO HotelAmenityDetails { get; set; } = new HotelAmenityDTO();

    internal string Title { get; set; } = "Create";

    internal bool IsProcessingStart { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            //we work with update
            Title = "Update";

            HotelAmenityDetails = await AmenityRepository.GetHotelAmenity(Id.Value);
        }
        else
        {
            HotelAmenityDetails = new HotelAmenityDTO();
        }
        Mapper.Map(HotelAmenityDetails, HotelAmenityModel);


    }



    internal async Task HandleHotelAmenityCreate()
    {
        try
        {
            IsProcessingStart = true;

            if (HotelAmenityModel.Id != 0 && Title == "Update")
            {
                var amenityDetailsByName = await AmenityRepository.IsSameNameAmenityAlreadyExists(HotelAmenityModel.Name);
                if (amenityDetailsByName != null && amenityDetailsByName.Id != HotelAmenityModel.Id)
                {
                    await jsRuntime.ToastrError("Hotel Amenity already exists.");
                    return;
                }
                //Update the hotel amenity here
                var updateAmenityResult = await AmenityRepository.UpdateHotelAmenity(HotelAmenityModel.Id, HotelAmenityModel);


                await jsRuntime.ToastrSuccess("Hotel Amenity updated successfully.");
            }
            else
            {

                var amenityDetailsByName = await AmenityRepository.IsSameNameAmenityAlreadyExists(HotelAmenityModel.Name);
                if (amenityDetailsByName != null)
                {
                    await jsRuntime.ToastrError("Hotel Amenity name is already exists.");
                }


                //Create new Hotel Amenity here
                var createdResult = await AmenityRepository.CreateHotelAmenity(HotelAmenityModel);
                HotelAmenityModel = new HotelAmenityRequestDTO();
                HotelAmenityDetails = new HotelAmenityDTO();
                await jsRuntime.ToastrSuccess("Hotel amenity created successfully.");

            }
            NavigationManager.NavigateTo("hotel-amenity");
            IsProcessingStart = false;

        }
        catch (Exception e)
        {
            IsProcessingStart = false;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoMapper.IMapper Mapper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAmenityRepository AmenityRepository { get; set; }
    }
}
#pragma warning restore 1591
