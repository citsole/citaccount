#pragma checksum "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30a4a2e1ac4840e8376e9966d9e0ce30bfd009d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>ເພີ່ມໃໝ່</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                  acc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                      AddGroupAcc

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<label for=\"Code\">ເລກບັນຊີ:</label>\r\n        ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "placeholder", "ເລກບັນຊີ");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                                        acc.AccNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => acc.AccNo = __value, acc.AccNo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __Blazor.citaccount.Pages.Settings.Account.Createaccount.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 17 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                  () => acc.AccNo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<label for=\"Name\">ຊື່ບັນຊີ:</label>\r\n        ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "placeholder", "ຊື່ບັນຊີ");
                __builder2.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                                       acc.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => acc.Name = __value, acc.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __Blazor.citaccount.Pages.Settings.Account.Createaccount.TypeInference.CreateValidationMessage_1(__builder2, 34, 35, 
#nullable restore
#line 22 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                  () => acc.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.AddMarkupContent(41, "<label for=\"Name\">ລົງໜີ້:</label>\r\n        ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "checkbox");
                __builder2.AddAttribute(44, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                       acc.BalDebit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => acc.BalDebit = __value, acc.BalDebit));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.AddMarkupContent(47, "<label for=\"Name\">ລົງມີ:</label>\r\n        ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "checkbox");
                __builder2.AddAttribute(50, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                       acc.BalCredit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => acc.BalCredit = __value, acc.BalCredit));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n    ");
                __builder2.AddMarkupContent(54, "<button type=\"submit\" class=\"btn btn-primary\">ບັນທຶກ</button>\r\n    ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "type", "button");
                __builder2.AddAttribute(57, "class", "btn btn-warning");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Projects\citaccount\citaccount\Pages\Settings\Account\Createaccount.razor"
                                                             goBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(59, "ກັບຄືນ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.citaccount.Pages.Settings.Account.Createaccount
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
