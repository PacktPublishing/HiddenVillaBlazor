#pragma checksum "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Areas\Identity\Pages\Account\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17397f8d5463143ad93f745809ed0728c9cba148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using HiddenVilla_Server.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using HiddenVilla_Server.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HiddenVilla_Server.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Areas\Identity\Pages\Account\Logout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17397f8d5463143ad93f745809ed0728c9cba148", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbaacbd41b2d7014eb9a5a381661a53193e94c4", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a11e7d5eb0b20ccab668ef62fbd2c39b9b8d18a8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\bhrug\OneDrive\Desktop\Udemy Course Code\Lecture Code\HiddenVilla\HiddenVilla\HiddenVilla_Server\Areas\Identity\Pages\Account\Logout.cshtml"
           

    public async Task<IActionResult> OnGet()
    {
        if (SignInManager.IsSignedIn(User))
        {
            await SignInManager.SignOutAsync();
        }

        return Redirect("~/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Logout> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Logout> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Logout>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Logout Model => ViewData.Model;
    }
}
#pragma warning restore 1591
