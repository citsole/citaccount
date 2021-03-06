#pragma checksum "D:\Projects\citaccount\citaccount\Pages\Transections\Viewtran.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcac62a1fbae9570480673283c30b3804c6883f3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace citaccount.Pages.Transections
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
#line 3 "D:\Projects\citaccount\citaccount\Pages\Transections\Viewtran.razor"
using citaccount.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\Pages\Transections\Viewtran.razor"
using citaccount.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewtran/{currentID}")]
    public partial class Viewtran : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\Projects\citaccount\citaccount\Pages\Transections\Viewtran.razor"
       
    [Parameter]
    public string currentId { get; set; }

    TblTransection tran = new TblTransection();
    List<TblAcc> acc;

    protected override void OnInitialized()
    {
        tran.TranNo = DateTime.Now.ToString("yyMMddHHmmss");
        tran.CreateDate = DateTime.Now;

        acc = settingService.ShowAllAcc();
        tran = tranService.GetTranById(Convert.ToInt32(currentId));
    }

    protected void Approved()
    {
        tran.StatusId = 2; //2 ແມ່ນສະຖານະ ອານຸມັດ ແລ້ວ
        tran.UserId = 1;
        tran.CurrencyId = 1;
        tran.BranchId = 1;
        tran.UserApproveId = 1;

        tranService.UpdateTran(tran);
        nav.NavigateTo("transection");
        toastService.ShowSuccess($"ທ່ານໄດ້ອານຸມັດ ທຸລະກຳເລກທີ {tran.TranNo} - {tran.Des} ສຳເລັດ!", "ການເຄື່ອນໄຫວ");
    }
    protected void Rejected()
    {
        tran.StatusId = 3; //3 ແມ່ນສະຖານະ ຍົກເລີກ
        tran.UserId = 1;
        tran.CurrencyId = 1;
        tran.BranchId = 1;
        tran.UserApproveId = 1;

        tranService.UpdateTran(tran);
        nav.NavigateTo("transection");
        toastService.ShowError($"ທ່ານໄດ້ຍົກເລີກ ທຸລະກຳເລກທີ {tran.TranNo} - {tran.Des} ສຳເລັດ!", "ການເຄື່ອນໄຫວ");
    }

    void goBack()
    {
        nav.NavigateTo("transection");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SettingService settingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TransectionService tranService { get; set; }
    }
}
#pragma warning restore 1591
