#pragma checksum "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa40b37d985bd8d989105153cd048ca835b06c4e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
using citaccount.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
using citaccount.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createtran")]
    public partial class Createtran : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ລົງການເຄື່ອນໄຫວບັນຊີປະຈຳ</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                 tran

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                      AddTran

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label for=\"Code\">ລົງວັນທີ, ເດືອນ, ປີ:</label>\r\n                ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "date");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "ວັນທີ");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                                tran.CreateDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tran.CreateDate = __value, tran.CreateDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 22 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                          () => tran.CreateDate

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col");
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<label for=\"Code\">ເລກທີອ້າງອີງ:</label>\r\n                ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "placeholder", "ເລກທີ");
                __builder2.AddAttribute(41, "autofocus", true);
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                                tran.TranNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tran.TranNo = __value, tran.TranNo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 29 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                          () => tran.TranNo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-row");
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col");
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.AddMarkupContent(57, "<label for=\"Code\">ບັນຊີໜີ້:</label>\r\n                ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "type", "text");
                __builder2.AddAttribute(60, "list", "textDebitsearch");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                                                      tran.AccDebit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tran.AccDebit = __value, tran.AccDebit));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateValidationMessage_2(__builder2, 65, 66, 
#nullable restore
#line 37 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                          () => tran.AccDebit

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "datalist");
                __builder2.AddAttribute(69, "id", "textDebitsearch");
                __builder2.AddMarkupContent(70, "\r\n");
#nullable restore
#line 39 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                     foreach(var a in acc)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(71, "                        ");
                __builder2.OpenElement(72, "option");
                __builder2.AddAttribute(73, "value", 
#nullable restore
#line 41 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                        a.AccNo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 42 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col");
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.AddMarkupContent(81, "<label for=\"Code\">ບັນຊີມີ:</label>\r\n            ");
                __builder2.OpenElement(82, "input");
                __builder2.AddAttribute(83, "type", "text");
                __builder2.AddAttribute(84, "list", "textCrebitsearch");
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                                                   tran.AccCredit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tran.AccCredit = __value, tran.AccCredit));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n            ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateValidationMessage_3(__builder2, 89, 90, 
#nullable restore
#line 48 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                      () => tran.AccCredit

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.OpenElement(92, "datalist");
                __builder2.AddAttribute(93, "id", "textCrebitsearch");
                __builder2.AddMarkupContent(94, "\r\n");
#nullable restore
#line 50 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                 foreach (var a in acc)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(95, "                    ");
                __builder2.OpenElement(96, "option");
                __builder2.AddAttribute(97, "value", 
#nullable restore
#line 52 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                    a.AccNo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n");
#nullable restore
#line 53 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(99, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col");
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.AddMarkupContent(105, "<label for=\"Code\">ຈຳນວນເງິນ:</label>\r\n            ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateOceanNumericInput_4(__builder2, 106, 107, "N", 108, 
#nullable restore
#line 58 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                                       2

#line default
#line hidden
#nullable disable
                , 109, "ຈຳນວນເງິນ", 110, "form-control", 111, 
#nullable restore
#line 58 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                                                        tran.Amount

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tran.Amount = __value, tran.Amount)), 113, () => tran.Amount);
                __builder2.AddMarkupContent(114, "\r\n            ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateValidationMessage_5(__builder2, 115, 116, 
#nullable restore
#line 59 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                      () => tran.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(117, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n    ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-group");
                __builder2.AddMarkupContent(122, "\r\n        ");
                __builder2.AddMarkupContent(123, "<label for=\"Name\">ເນື້ອໃນການເຄື່ອນໄຫວ:</label>\r\n        ");
                __builder2.OpenElement(124, "input");
                __builder2.AddAttribute(125, "type", "text");
                __builder2.AddAttribute(126, "class", "form-control");
                __builder2.AddAttribute(127, "placeholder", "ເນື້ອໃນການເຄື່ອນໄຫວ");
                __builder2.AddAttribute(128, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                       tran.Des

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(129, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tran.Des = __value, tran.Des));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n        ");
                __Blazor.citaccount.Pages.Transections.Createtran.TypeInference.CreateValidationMessage_6(__builder2, 131, 132, 
#nullable restore
#line 66 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                  () => tran.Des

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(133, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n\r\n    ");
                __builder2.AddMarkupContent(135, "<button type=\"submit\" class=\"btn btn-primary\">ບັນທຶກ</button>\r\n    ");
                __builder2.OpenElement(136, "button");
                __builder2.AddAttribute(137, "type", "button");
                __builder2.AddAttribute(138, "class", "btn btn-warning");
                __builder2.AddAttribute(139, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
                                                             goBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(140, "ກັບຄືນ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\Projects\citaccount\citaccount\Pages\Transections\Createtran.razor"
       

    TblTransection tran = new TblTransection();
    List<TblAcc> acc;

    protected override void OnInitialized()
    {
        tran.TranNo = DateTime.Now.ToString("yyMMddHHmmss");
        tran.CreateDate = DateTime.Now;
        acc = settingService.ShowAllAcc();
    }

    protected void AddTran()
    {
        tran.StatusId = 1; // 1 ແມ່ນສະຖານະ ລໍຖ້າ ອານຸມັດ
        tran.UserId = 1;
        tran.CurrencyId = 1;
        tran.BranchId = 1;

        tranService.CreateTran(tran);
        nav.NavigateTo("transection");
        toastService.ShowSuccess($"ທ່ານເພີ່ມຂໍ້ມູນ {tran.Des} ສຳເລັດ!", "ການເຄື່ອນໄຫວ");
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
namespace __Blazor.citaccount.Pages.Transections.Createtran
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateOceanNumericInput_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Oceanware.Ocean.Blazor.OceanNumericInput<TValue>>(seq);
        __builder.AddAttribute(__seq0, "FormatString", __arg0);
        __builder.AddAttribute(__seq1, "NumberOfDecimalPlaces", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
