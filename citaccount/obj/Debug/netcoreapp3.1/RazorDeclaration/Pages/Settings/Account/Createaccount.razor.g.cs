#pragma checksum "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30a4a2e1ac4840e8376e9966d9e0ce30bfd009d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace citaccount.Pages.Settings.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\citaccount\citaccount\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\citaccount\citaccount\_Imports.razor"
using citaccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\citaccount\citaccount\_Imports.razor"
using citaccount.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\citaccount\citaccount\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\citaccount\citaccount\_Imports.razor"
using Oceanware.Ocean.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
using citaccount.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
using citaccount.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createaccount")]
    public partial class Createaccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
       
    TblAcc acc = new TblAcc();

    protected void AddGroupAcc()
    {
        settingService.CreateAcc(acc);
        nav.NavigateTo("account");
        toastService.ShowSuccess($"ທ່ານເພີ່ມຂໍ້ມູນ {acc.Name} ສຳເລັດ!", "ກູ່ມບັນຊີ");
    }
    void goBack()
    {
        nav.NavigateTo("account");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SettingService settingService { get; set; }
    }
}
#pragma warning restore 1591
